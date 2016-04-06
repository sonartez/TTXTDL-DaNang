using Sonartez.Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Sonartez.Helpdesk.Bussiness
{
    public class BBLInfo
    {
        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Sonartez.App.Properties.Settings.SonartezClientConnectionString"].ConnectionString;

        public IEnumerable<TblInfor> GetAll()
        {
            List<TblInfor> u = new List<TblInfor>();
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var q =
                from a in db.TblInfor
                select a;
                u = q.ToList();
            }
            return u;
        }

        public TblInfor InsertOrUpdate(TblInfor data)
        {
            Exception cex = null;
            TblInfor res = null;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblInfor
                                  where c.ID == data.ID
                                  select c).SingleOrDefault();

                if (matchedObj == null)
                {
                    try
                    {
                        // does not exist
                        Table<TblInfor> TblObj = db.TblInfor;
                        data.UpdateDate = DateTime.Now;
                        data.IsDeleted = 0;
                        TblObj.InsertOnSubmit(data);
                        TblObj.Context.SubmitChanges();
                        res = data;
                    }
                    catch (Exception ex)
                    {
                        cex = ex;
                    }
                }
                else
                {
                    try
                    {
                        matchedObj.BeginDate = data.BeginDate;
                        matchedObj.CreateDate = data.CreateDate;
                        matchedObj.CreateUserID = data.CreateUserID;
                        matchedObj.ExprieDate = data.ExprieDate;
                        matchedObj.InfoContentHtml = data.InfoContentHtml;
                        matchedObj.InfoContent = data.InfoContent;
                        matchedObj.InfoTag = data.InfoTag;
                        matchedObj.InfoTitle = data.InfoTitle;
                        matchedObj.InfoType = data.InfoType;
                        matchedObj.Status = data.Status;
                        matchedObj.UpdateDate = data.UpdateDate;
                        matchedObj.IsDeleted = data.IsDeleted.Value;
                        db.SubmitChanges();
                        res = matchedObj;
                      
                    }
                    catch (Exception ex)
                    {
                        cex = ex;
                    }
                }

            }

            if (cex != null)
                throw cex;
            else
                return res;
        }

        public bool Delete(TblInfor data)
        {
            Exception cex = null;
            bool res = false;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblInfor
                                  where c.ID == data.ID
                                  select c).SingleOrDefault();

                if (matchedObj != null)
                {
                    try
                    {
                        // does not exist
                        db.TblInfor.DeleteOnSubmit(matchedObj);
                        db.SubmitChanges();
                        res = true;
                    }
                    catch (Exception ex)
                    {
                        cex = ex;
                        res = false;
                    }
                }
                else
                {
                    res = true;
                }
            }

            if (cex != null)
                throw cex;
            else
                return res;
        }

        internal void ServiceUpdate(string baseHost)
        {
            //1 -  Lấy giờ 
           
            TblUpdate lastUpdate = GetLastUpdate();


            //2 -  Kéo về
            var data = GetUpdateInfo(baseHost, lastUpdate.LastInfoUpdate.Value);

            //3 -  Cập Nhập 
            if (data != null && data.Count() > 0)
            {
                // update 

                foreach (var item in data)
                {
                    if (item.IsDeleted.HasValue)
                    {
                        if (item.IsDeleted.Value == 0)
                        {
                            InsertOrUpdate(item);
                        }
                        else
                        {
                            Delete(item);
                        }
                    }
                }

            }
          
            //4 -  Lấy ra
            var postData = GetAll().Where(x => x.UpdateDate >= lastUpdate.LocalInfoUpdate.Value).ToList();

            DateTime updateDate = DateTime.Now;
            //5 -  Đẩy lên
            var res = PostUpdateToServer(baseHost, postData);

            //6 -  Lưu giờ
            if (res.Success)
            {
                BBLUpdate upData = new BBLUpdate();
                TblUpdate u = upData.GetCurrent();
                if (u == null)
                {
                    u = new TblUpdate();
                    DateTime mindate = DateTime.Parse("2000/01/01");
                    u.LastActivityLogUpdate = mindate;
                    u.LastUserUpdate = mindate;
                    u.LastConsutantUpdate = mindate;
                    u.LastInfoUpdate = res.UpdateDate;
                    u.LastUserPermissionUpdate = mindate;
                    u.LastClientUpdate = mindate;

                    u.LocalConsutantUpdate = mindate;
                    u.LocalClientUpdate = mindate;
                    u.LocalActivityLogUpdate = mindate;
                    u.LocalInfoUpdate = updateDate;
                    u.LocalUserUpdate = mindate;
                }
                else
                {
                    u.LastInfoUpdate = res.UpdateDate;

                    u.LocalInfoUpdate = updateDate;
                }
                upData.Update(u);
            }
        }

        internal APIResult PostUpdateToServer(string uri, IEnumerable<TblInfor> postData)
        {
            APIResult data = new APIResult() { Message = "Error", Success = false, UpdateDate = DateTime.Parse("2000/01/01") };

            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);

                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsJsonAsync("api/Update/UpdateInfors", postData).Result;
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    data = response.Content.ReadAsAsync<APIResult>().Result;
                }
                return data;
            }
            catch (Exception ex)
            {
                data.Message = ex.Message;
                return data;
            }
        }

        static IEnumerable<TblInfor> GetUpdateInfo(string uri, DateTime date)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);
                string callUrl = string.Format("api/Update/GetInfor?lastUpdateDate={0}", date.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
                var resp = client.GetAsync(callUrl).Result;
                resp.EnsureSuccessStatusCode();

                var data = resp.Content.ReadAsAsync<IEnumerable<TblInfor>>().Result;

                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private TblUpdate GetLastUpdate()
        {
            DateTime min = DateTime.Parse("2000/01/01");
            TblUpdate novalue = new TblUpdate()
            {
                LastActivityLogUpdate = min,
                LastClientUpdate = min,
                LastConsutantUpdate = min,
                LastInfoUpdate = min,
                LastUserPermissionUpdate = min,
                LocalActivityLogUpdate = min,
                LocalClientUpdate = min,
                LocalConsutantUpdate = min,
                LocalInfoUpdate = min,
                LocalUserUpdate = min
            };
            List<TblUpdate> u = new List<TblUpdate>();
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var q =
                from a in db.TblUpdate
                select a;
                u = q.ToList();
            }
            if (u.FirstOrDefault() != null)
            {
                if (u.FirstOrDefault().LastClientUpdate != null)
                    return u.FirstOrDefault();
                else
                    return novalue;
            }
            else
                return novalue;

        }
    }
}
