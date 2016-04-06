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
    public class BBLConsultant
    {
        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Sonartez.App.Properties.Settings.SonartezClientConnectionString"].ConnectionString;

        public IEnumerable<TblConsultantLog> GetAll()
        {
            List<TblConsultantLog> u = new List<TblConsultantLog>();
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var q =
                from a in db.TblConsultantLog
                select a;
                u = q.ToList();
            }
            return u;
        }

        public TblConsultantLog InsertOrUpdate(TblConsultantLog data)
        {
            Exception cex = null;
            TblConsultantLog res = null;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblConsultantLog
                                  where c.ID == data.ID
                                  select c).SingleOrDefault();

                if (matchedObj == null)
                {
                    try
                    {
                        // does not exist
                        Table<TblConsultantLog> TblObj = db.TblConsultantLog;
                        data.UpdateDate = DateTime.Now;
                        data.SubmitDate = DateTime.Now;
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
                        matchedObj.AnswerRef = data.AnswerRef;
                        matchedObj.CreateDate = data.CreateDate;
                        matchedObj.ClientCode = data.ClientCode;
                        matchedObj.ClientID = data.ClientID;
                        matchedObj.ClientName = data.ClientName;
                        matchedObj.ConsType = data.ConsType;
                        matchedObj.CreateDate = data.CreateDate;
                        matchedObj.Descriptions = data.Descriptions;
                        matchedObj.Status = data.Status;
                        matchedObj.FinishDate = data.FinishDate;
                        matchedObj.FinishType = data.FinishType;
                        matchedObj.IsDeleted = data.IsDeleted;
                        matchedObj.Question = data.Question;
                        matchedObj.SubmitDate = data.SubmitDate;
                        matchedObj.TargetCount = data.TargetCount;
                        matchedObj.SubmitDate = data.SubmitDate;
                        matchedObj.TargetCountry = data.TargetCountry;
                        matchedObj.TargetEmail = data.TargetEmail;
                        matchedObj.TargetName = data.TargetName;
                        matchedObj.TargetPhoneNumber = data.TargetPhoneNumber;
                        matchedObj.TargetType = data.TargetType;
                        matchedObj.UserID = data.UserID;
                        matchedObj.UserName = data.UserName;
                        matchedObj.UpdateDate = DateTime.Now;
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


        internal void ServiceUpdate(string baseHost)
        {
            //1 -  Lấy giờ 
            TblUpdate lastUpdate = GetClientLastUpdate();
            

            //2 -  Kéo về
            var data = GetUpdateConsultants(baseHost, lastUpdate.LastConsutantUpdate.Value);

            //3 -  Cập Nhập 
            if (data != null && data.Count() > 0)
            {
                // update 

                foreach (var item in data)
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

            //4 -  Lấy ra
            var postData = GetAll().Where(x => x.UpdateDate >= lastUpdate.LocalConsutantUpdate.Value).ToList();
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
                    u.LastConsutantUpdate = res.UpdateDate;
                    u.LastInfoUpdate = mindate;
                    u.LastUserPermissionUpdate = mindate;
                    u.LastClientUpdate = mindate;

                    u.LocalClientUpdate = mindate;
                    u.LocalActivityLogUpdate = mindate;
                    u.LocalInfoUpdate = mindate;
                    u.LocalUserUpdate = mindate;
                    u.LocalConsutantUpdate = updateDate;
                }
                else
                {
                    u.LastConsutantUpdate = res.UpdateDate;

                    u.LocalConsutantUpdate = updateDate;
                }
                upData.Update(u);
                
            }
        }

        private bool Delete(TblConsultantLog data)
        {
            Exception cex = null;
            bool res = false;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblConsultantLog
                                  where c.ID == data.ID
                                  select c).SingleOrDefault();

                if (matchedObj != null)
                {
                    try
                    {
                        // does not exist
                        db.TblConsultantLog.DeleteOnSubmit(matchedObj);
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

        internal APIResult PostUpdateToServer(string uri, IEnumerable<TblConsultantLog> postData)
        {
            APIResult data = new APIResult() { Message = "Error", Success = false, UpdateDate = DateTime.Parse("2000/01/01") };

            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);

                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsJsonAsync("api/Update/UpdateConsultantLogs", postData).Result;
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

        static IEnumerable<TblConsultantLog> GetUpdateConsultants(string uri, DateTime date)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);
                string callUrl = string.Format("api/Update/GetConsultantLog?lastUpdateDate={0}", date.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
                var resp = client.GetAsync(callUrl).Result;
                resp.EnsureSuccessStatusCode();

                var data = resp.Content.ReadAsAsync<IEnumerable<TblConsultantLog>>().Result;

                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public TblUpdate GetClientLastUpdate()
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
