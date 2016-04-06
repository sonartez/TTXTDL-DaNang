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
    public class BBLClient
    {
        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Sonartez.App.Properties.Settings.SonartezClientConnectionString"].ConnectionString;

        public IEnumerable<TblClient> GetAll()
        {
            List<TblClient> u = new List<TblClient>();
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var q =
                from a in db.TblClient
                select a;
                u = q.ToList();
            }
            return u;
        }

        public TblUpdate GetClientLastUpdate()
        {
            DateTime min = DateTime.Parse("2000/01/01");
            TblUpdate novalue = new TblUpdate() { 
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

        public TblClient InsertOrUpdate(TblClient data)
        {

            Exception cex = null;
            TblClient res = null;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblClient
                                  where c.ClientID == data.ClientID
                                  select c).SingleOrDefault();

                if (matchedObj == null)
                {
                    try
                    {
                        // does not exist
                        Table<TblClient> TblObj = db.TblClient;
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
                        matchedObj.ClientCode = data.ClientCode;
                        matchedObj.ClientName = data.ClientName;
                        matchedObj.Descriptions = data.Descriptions;
                        matchedObj.LocationCode = data.LocationCode;
                        matchedObj.LocationName = data.LocationName;
                        matchedObj.UpdateDate = DateTime.Now;
                        matchedObj.IsDeleted = data.IsDeleted;
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

        internal void UpdateFromServer(string baseHost)
        {
            // Lấy last update
            TblUpdate lastUpdate = GetClientLastUpdate();
           
            var data = GetUpdateClients(baseHost, lastUpdate.LastClientUpdate.Value);

            if (data != null && data.Count() > 0)
            {
                // update 

                foreach (var item in data)
                {
                    InsertOrUpdate(item);
                }

            }

        }

        static IEnumerable<TblClient> GetUpdateClients(string uri, DateTime date)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);
                string callUrl = string.Format("api/Update/GetClient?lastUpdateDate={0}", date.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
                var resp = client.GetAsync(callUrl).Result;
                resp.EnsureSuccessStatusCode();

                var data = resp.Content.ReadAsAsync<IEnumerable<TblClient>>().Result;

                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        static bool PostUpdateClients(string uri, DateTime date)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);

                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
                BBLClient clientData = new BBLClient();
                var postData = clientData.GetAll().Where(x => x.UpdateDate >= date);

                var response = client.PostAsJsonAsync("api/Update/UpdateClients", postData).Result;
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    APIResult data = response.Content.ReadAsAsync<APIResult>().Result;
                    if (data.Success == true)
                    {
                        BBLUpdate upData = new BBLUpdate();
                        TblUpdate u = upData.GetCurrent();
                        if (u == null)
                        {
                            u = new TblUpdate();
                            DateTime mindate = DateTime.Parse("2000/01/01");
                            u.LastActivityLogUpdate = mindate;
                            u.LastClientUpdate = DateTime.Now;
                            u.LastConsutantUpdate = mindate;
                            u.LastInfoUpdate = mindate;
                            u.LastUserPermissionUpdate = mindate;
                            u.LastUserUpdate = mindate;
                        }
                        else {
                            u.LastClientUpdate = DateTime.Now;
                        }
                        upData.Update(u);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal void ServiceUpdate(string baseHost)
        {
            //1 -  Lấy giờ 
            TblUpdate lastUpdate = GetClientLastUpdate();
            DateTime updateDate = DateTime.Now;

            //2 -  Kéo về
            var data = GetUpdateClients(baseHost, lastUpdate.LastClientUpdate.Value);

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
            var postData = GetAll().Where(x => x.UpdateDate >= lastUpdate.LocalClientUpdate).ToList();


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
                    u.LastInfoUpdate = mindate;
                    u.LastUserPermissionUpdate = mindate;
                    u.LastClientUpdate = res.UpdateDate;

                    u.LocalClientUpdate = updateDate;
                    u.LocalConsutantUpdate = mindate;
                    u.LocalInfoUpdate = mindate;
                    u.LocalUserUpdate = mindate;
                    u.LocalActivityLogUpdate = mindate;
                }
                else
                {
                    u.LastClientUpdate = res.UpdateDate;

                    u.LocalClientUpdate = updateDate;
                }
                upData.Update(u);
            }
        }

        private APIResult PostUpdateToServer(string uri, IEnumerable<TblClient> postData)
        {
            APIResult data = new APIResult() { Message = "Error", Success = false, UpdateDate = DateTime.Parse("2000/01/01") };

            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);

                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsJsonAsync("api/Update/UpdateClients", postData).Result;
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

        private bool Delete(TblClient data)
        {
           
            Exception cex = null;
            bool res = false;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblClient
                                  where c.ClientID == data.ClientID
                                  select c).SingleOrDefault();

                if (matchedObj != null)
                {
                    try
                    {
                        // does not exist
                        db.TblClient.DeleteOnSubmit(matchedObj);
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
    }
}
