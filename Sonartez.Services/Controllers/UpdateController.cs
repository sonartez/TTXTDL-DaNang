using Sonartez.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sonartez.Services.Controllers
{
    public class UpdateController : ApiController
    {
        // GET api/update

        public string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        /// <summary>
        /// Get SERVER TABLE LASTUPDATE TIME
        /// </summary>
        /// <returns></returns>
        public TblUpdate GetUpdateStatus()
        {
            TblUpdate u = new TblUpdate();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var q =
                from a in db.TblUpdate
                select a;
                u = q.FirstOrDefault<TblUpdate>();
            }
            return u;
        }

        [HttpGet]
        public IEnumerable<TblClient> GetClient(DateTime lastUpdateDate)
        {
            List<TblClient> u = new List<TblClient>();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var q =
                from a in db.TblClient
                where a.ServerUpdate > lastUpdateDate
                select a;
                u = q.ToList();
            }
            return u;
        }

        [HttpGet]
        public IEnumerable<TblActivityLog> GetActivityLog(DateTime lastUpdateDate)
        {
            List<TblActivityLog> u = new List<TblActivityLog>();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var q =
                from a in db.TblActivityLog
                where a.ServerUpdate > lastUpdateDate
                select a;
                u = q.ToList();
            }
            return u;
        }

        [HttpGet]
        public IEnumerable<TblConsultantLog> GetConsultantLog(DateTime lastUpdateDate)
        {
            List<TblConsultantLog> u = new List<TblConsultantLog>();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var q =
                from a in db.TblConsultantLog
                where a.ServerUpdate > lastUpdateDate
                select a;
                u = q.ToList();
            }
            return u;
        }

        [HttpGet]
        public IEnumerable<TblInfor> GetInfor(DateTime lastUpdateDate)
        {
            List<TblInfor> u = new List<TblInfor>();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var q =
                from a in db.TblInfor
                where a.ServerUpdate > lastUpdateDate
                select a;
                u = q.ToList();
            }
            return u;
        }

        [HttpGet]
        public IEnumerable<TblUser> GetUser(DateTime lastUpdateDate)
        {
            List<TblUser> u = new List<TblUser>();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var q =
                from a in db.TblUser
                where a.ServerUpdate > lastUpdateDate
                select a;
                u = q.ToList();
            }
            return u;
        }

        [HttpGet]
        public IEnumerable<TblUser> GetAllUser()
        {
            List<TblUser> u = new List<TblUser>();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var q =
                from a in db.TblUser
                select a;
                u = q.ToList();
            }
            return u;
        }

        [HttpGet]
        public IEnumerable<TblUserPermission> GetUserPermission(DateTime lastUpdateDate)
        {
            List<TblUserPermission> u = new List<TblUserPermission>();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var q =
                from a in db.TblUserPermission
                where a.ServerUpdate > lastUpdateDate
                select a;
                u = q.ToList();
            }
            return u;
        }

        [HttpPost]
        public APIResult UpdateClient(TblClient data)
        {
            APIResult res = new APIResult();
            using (Sonartez_server db = new Sonartez_server(connectionString))
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
                        data.ServerUpdate = DateTime.Now;
                        TblObj.InsertOnSubmit(data);
                        TblObj.Context.SubmitChanges();

                        res.UpdateDate = data.UpdateDate.Value;
                        res.Success = true;

                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
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
                        matchedObj.ServerUpdate = DateTime.Now;
                        matchedObj.UpdateDate = data.UpdateDate;
                        db.SubmitChanges();

                        res.UpdateDate = data.ServerUpdate.Value;
                        res.Success = true;
                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }

            }
            return res;
        }

        [HttpPost]
        public APIResult UpdateActivityLog(TblActivityLog data)
        {
            APIResult res = new APIResult();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var matchedObj = (from c in db.TblActivityLog
                                  where c.ID == data.ID
                                  select c).SingleOrDefault();

                if (matchedObj == null)
                {
                    try
                    {
                        // does not exist
                        Table<TblActivityLog> TblObj = db.TblActivityLog;
                        data.ServerUpdate = DateTime.Now;                      
                        TblObj.InsertOnSubmit(data);
                        TblObj.Context.SubmitChanges();

                        res.UpdateDate = data.ServerUpdate.Value;
                        res.Success = true;

                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }
                else
                {
                    try
                    {
                        matchedObj.ActivityType = data.ActivityType;
                        matchedObj.ClientName = data.ClientName;
                        matchedObj.Descriptions = data.Descriptions;
                        matchedObj.ClientID = data.ClientID;
                        matchedObj.UserID = data.UserID;
                        matchedObj.UserName = data.UserName;
                        matchedObj.ServerUpdate = DateTime.Now;
                        matchedObj.CreateDate = data.CreateDate;
                        db.SubmitChanges();

                        res.UpdateDate = data.ServerUpdate.Value;
                        res.Success = true;
                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }

            }
            return res;
        }

        [HttpPost]
        public APIResult UpdateConsultantLog(TblConsultantLog data)
        {
            APIResult res = new APIResult();
            using (Sonartez_server db = new Sonartez_server(connectionString))
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
                        data.ServerUpdate = DateTime.Now;
                        TblObj.InsertOnSubmit(data);
                        TblObj.Context.SubmitChanges();

                        res.UpdateDate = data.ServerUpdate.Value;
                        res.Success = true;

                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }
                else
                {
                    try
                    {
                        matchedObj.AnswerRef = data.AnswerRef;
                        matchedObj.ClientCode = data.ClientCode;
                        matchedObj.ClientID = data.ClientID;
                        matchedObj.ClientName = data.ClientName;
                        matchedObj.ConsType = data.ConsType;
                        matchedObj.CreateDate = data.CreateDate;
                        matchedObj.Descriptions = data.Descriptions;
                        matchedObj.FinishDate = data.FinishDate;
                        matchedObj.FinishType = data.FinishType;
                        matchedObj.Question = data.Question;
                        matchedObj.Status = data.Status;
                        matchedObj.SubmitDate = data.SubmitDate;
                        matchedObj.TargetCount = data.TargetCount;
                        matchedObj.TargetCountry = data.TargetCountry;
                        matchedObj.TargetEmail = data.TargetEmail;
                        matchedObj.TargetName = data.TargetName;
                        matchedObj.TargetPhoneNumber = data.TargetPhoneNumber;
                        matchedObj.TargetType = data.TargetType;
                        matchedObj.UserID = data.UserID;
                        matchedObj.UserName = data.UserName;
                        matchedObj.ServerUpdate = DateTime.Now;
                        matchedObj.UpdateDate = data.UpdateDate;
                        db.SubmitChanges();

                        res.UpdateDate = data.ServerUpdate.Value;
                        res.Success = true;
                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }

            }
            return res;
        }

        [HttpPost]
        public APIResult UpdateInfor(TblInfor data)
        {
            APIResult res = new APIResult();
            using (Sonartez_server db = new Sonartez_server(connectionString))
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
                        data.ServerUpdate = DateTime.Now;
                        TblObj.InsertOnSubmit(data);
                        TblObj.Context.SubmitChanges();

                        res.UpdateDate = data.ServerUpdate.Value;
                        res.Success = true;

                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
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
                        matchedObj.InfoContent = data.InfoContent;
                        matchedObj.InfoTag = data.InfoTag;
                        matchedObj.InfoTitle = data.InfoTitle;
                        matchedObj.InfoType = data.InfoType;
                        matchedObj.Status = data.Status;
                        matchedObj.UpdateDate = data.UpdateDate;
                        matchedObj.ServerUpdate = DateTime.Now;
                        db.SubmitChanges();

                        res.UpdateDate = data.ServerUpdate.Value;
                        res.Success = true;
                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }

            }
            return res;
        }

        [HttpPost]
        public APIResult UpdateUser(TblUser data)
        {
            APIResult res = new APIResult();
            using (Sonartez_server db = new Sonartez_server(connectionString))
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
                        data.ServerUpdate = DateTime.Now;
                        TblObj.InsertOnSubmit(data);
                        TblObj.Context.SubmitChanges();

                        res.UpdateDate = data.ServerUpdate.Value;
                        res.Success = true;

                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }
                else
                {
                    try
                    {
                        matchedObj.Active = data.Active;
                        matchedObj.Email = data.Email;
                        matchedObj.FullName = data.FullName;
                        matchedObj.LastLoginTime = data.LastLoginTime;
                        matchedObj.Password = data.Password;
                        matchedObj.PhoneNumber = data.PhoneNumber;
                        matchedObj.UserName = data.UserName;
                        matchedObj.ServerUpdate = DateTime.Now;
                        matchedObj.UpdateDate = data.UpdateDate;
                        db.SubmitChanges();

                        res.UpdateDate = data.UpdateDate.Value;
                        res.Success = true;
                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }

            }
            return res;
        }

        [HttpPost]
        public APIResult UpdateClient(TblUserPermission data)
        {
            APIResult res = new APIResult();
            using (Sonartez_server db = new Sonartez_server(connectionString))
            {
                var matchedObj = (from c in db.TblUserPermission
                                  where c.ID == data.ID
                                  select c).SingleOrDefault();

                if (matchedObj == null)
                {
                    try
                    {
                        // does not exist
                        Table<TblUserPermission> TblObj = db.TblUserPermission;
                        data.ServerUpdate = DateTime.Now;
                        TblObj.InsertOnSubmit(data);
                        TblObj.Context.SubmitChanges();

                        res.UpdateDate = data.ServerUpdate.Value;
                        res.Success = true;

                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }
                else
                {
                    try
                    {
                        matchedObj.PermissionID = data.PermissionID;
                        matchedObj.PermissionName = data.PermissionName;
                        matchedObj.UserID = data.UserID;
                        matchedObj.ServerUpdate = DateTime.Now;
                        matchedObj.UpdateTime = data.UpdateTime;
                        db.SubmitChanges();

                        res.UpdateDate = data.UpdateTime.Value;
                        res.Success = true;
                    }
                    catch (Exception ex)
                    {
                        res.Message = ex.Message;
                        res.Success = false;
                    }
                }

            }
            return res;
        }
    }
}
