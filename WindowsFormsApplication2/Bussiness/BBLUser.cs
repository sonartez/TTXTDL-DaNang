using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Sonartez.Hepldesk.Bussiness
{
    public class BBLUser
    {
        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Sonartez.App.Properties.Settings.SonartezClientConnectionString"].ConnectionString;

        public IEnumerable<TblUser> GetUser()
        {
            List<TblUser> u = new List<TblUser>();
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var q =
                from a in db.TblUser
                where a.IsDeleted == 0
                select a;
                u = q.ToList();
            }
            return u;
        }

        public IEnumerable<TblUser> GetAllUser()
        {
            List<TblUser> u = new List<TblUser>();
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var q =
                from a in db.TblUser
                select a;
                u = q.ToList();
            }
            return u;
        }

        public TblUser GetUserByID(Guid userId)
        {
            TblUser u = new TblUser();
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var q =
                from a in db.TblUser
                where a.UserID == userId
                select a;
                u = q.FirstOrDefault();
            }
            return u;
        }

        internal TblUser SaveUser(TblUser data)
        {
            Exception cex = null;
            TblUser res = null;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblUser
                                  where c.UserID == data.UserID
                                  select c).SingleOrDefault();

                if (matchedObj == null)
                {
                    try
                    {
                        // does not exist
                        Table<TblUser> TblObj = db.TblUser;
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
            }

            if (cex != null)
                throw cex;
            else
                return res;
        }

        internal TblUser UpdateUser(TblUser data)
        {
            Exception cex = null;
            TblUser res = null;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblUser
                                  where c.UserID == data.UserID
                                  select c).SingleOrDefault();

                if (matchedObj == null)
                {
                    throw new Exception("Không tìm thấy thông tin người dùng này nữa!");
                }
                else
                {
                    try
                    {
                        matchedObj.Active = data.Active;
                        matchedObj.Email = data.Email;
                        matchedObj.FullName = data.FullName;
                        matchedObj.Permission = data.Permission;
                        matchedObj.Password = data.Password;
                        matchedObj.PhoneNumber = data.PhoneNumber;
                        matchedObj.UpdateDate = DateTime.Now;
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

        internal bool Delete(TblUser data)
        {
            Exception cex = null;
            bool res = false;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblUser
                                  where c.UserID == data.UserID
                                  select c).SingleOrDefault();

                if (matchedObj != null)
                {
                    try
                    {
                        // does not exist
                        db.TblUser.DeleteOnSubmit(matchedObj);
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

        internal TblUser Login(string username, string pass)
        {

            TblUser res = null;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblUser
                                  where c.UserName == username && c.Password == pass
                                  select c).SingleOrDefault();

                if (matchedObj != null)
                {
                    res = matchedObj;
                }

            }
            return res;
        }

        internal void UpdateFromServer(string baseHost)
        {
            // Lấy last update
            TblUpdate lastUpdate = GetLastUpdate();

            var data = GetUpdateUser(baseHost, lastUpdate.LastUserUpdate.Value);

            if (data != null && data.Count() > 0)
            {
                // update 

                foreach (var item in data)
                {
                    InsertOrUpdate(item);
                }

            }

        }

        private TblUser InsertOrUpdate(TblUser data)
        {
            Exception cex = null;
            TblUser res = null;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblUser
                                  where c.UserID == data.UserID
                                  select c).SingleOrDefault();

                if (matchedObj == null)
                {
                    try
                    {
                        // does not exist
                        Table<TblUser> TblObj = db.TblUser;
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
                        matchedObj.Active = data.Active;
                        matchedObj.Email = data.Email;
                        matchedObj.FullName = data.FullName;
                        matchedObj.Password = data.Password;
                        matchedObj.Permission = data.Permission;
                        matchedObj.PhoneNumber = data.PhoneNumber;
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

        static IEnumerable<TblUser> GetUpdateUser(string uri, DateTime date)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);
                string callUrl = string.Format("api/Update/GetUser?lastUpdateDate={0}", date.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
                var resp = client.GetAsync(callUrl).Result;
                resp.EnsureSuccessStatusCode();

                var data = resp.Content.ReadAsAsync<IEnumerable<TblUser>>().Result;

                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal APIResult PostUpdateToServer(string uri, IEnumerable<TblUser> postData)
        {
            APIResult data = new APIResult() { Message = "Error", Success = false, UpdateDate = DateTime.Parse("2000/01/01") };

            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);

                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsJsonAsync("api/Update/UpdateUsers", postData).Result;
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

       

        internal void ServiceUpdate(string baseHost)
        {
            //1 -  Lấy giờ 
            TblUpdate lastUpdate = GetLastUpdate();
          

            //2 -  Kéo về
            var data = GetUpdateUser(baseHost, lastUpdate.LastUserUpdate.Value);

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
            var postData = GetAllUser().Where(x => x.UpdateDate >= lastUpdate.LocalUserUpdate.Value).ToList();
            DateTime updateDate = DateTime.Now;

            //5 -  Đẩy lên
            var res = PostUpdateToServer(baseHost, postData);

            //6 -  Lưu giờ
            if (res.Success) {
                BBLUpdate upData = new BBLUpdate();
                TblUpdate u = upData.GetCurrent();
                if (u == null)
                {
                    u = new TblUpdate();
                    DateTime mindate = DateTime.Parse("2000/01/01");
                    u.LastActivityLogUpdate = mindate;
                    u.LastUserUpdate =res.UpdateDate;
                    u.LastConsutantUpdate = mindate;
                    u.LastInfoUpdate = mindate;
                    u.LastUserPermissionUpdate = mindate;
                    u.LastClientUpdate = mindate;

                    u.LocalConsutantUpdate = mindate;
                    u.LocalClientUpdate = mindate;
                    u.LocalActivityLogUpdate = mindate;
                    u.LocalInfoUpdate = mindate;
                    u.LocalUserUpdate = updateDate;
                }
                else
                {
                    u.LastUserUpdate = res.UpdateDate;

                    u.LocalUserUpdate = updateDate;
                }
                upData.Update(u);
            }
        }
    }
}
