using Sonartez.Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonartez.Helpdesk.Bussiness
{
    public class BBLUpdate
    {
        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Sonartez.App.Properties.Settings.SonartezClientConnectionString"].ConnectionString;

       
        public TblUpdate GetCurrent()
        {
            TblUpdate  u = new TblUpdate();
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var q =
                from a in db.TblUpdate
                select a;
                u = q.FirstOrDefault();
            }
            return u;
        }

        public TblUpdate Update(TblUpdate data)
        {
            Exception cex = null;
            TblUpdate res = null;
            var conn = new System.Data.SqlServerCe.SqlCeConnection(connectionString);
            using (Sonartez_server db = new Sonartez_server(conn))
            {
                var matchedObj = (from c in db.TblUpdate
                                  where c.ID == data.ID
                                  select c).SingleOrDefault();

                if (matchedObj == null)
                {
                    try
                    {
                        // does not exist
                        Table<TblUpdate> TblObj = db.TblUpdate;                       
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
                        matchedObj.LastActivityLogUpdate = data.LastActivityLogUpdate;
                        matchedObj.LastClientUpdate = data.LastClientUpdate;
                        matchedObj.LastConsutantUpdate = data.LastConsutantUpdate;
                        matchedObj.LastInfoUpdate = data.LastInfoUpdate;
                        matchedObj.LastUserPermissionUpdate = data.LastUserPermissionUpdate;
                        matchedObj.LastUserUpdate = data.LastUserUpdate;
                        matchedObj.LocalActivityLogUpdate = data.LocalActivityLogUpdate;
                        matchedObj.LocalClientUpdate = data.LocalClientUpdate;
                        matchedObj.LocalConsutantUpdate = data.LocalConsutantUpdate;
                        matchedObj.LocalInfoUpdate = data.LocalInfoUpdate;
                        matchedObj.LocalUserUpdate = data.LocalUserUpdate;
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
