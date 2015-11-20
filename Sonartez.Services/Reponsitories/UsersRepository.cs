using Sonartez.Services.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sonartez.Services.Reponsitories
{
    public class UsersRepository : IUsersRepository
    {
        public IEnumerable<Models.User> GetAll()
        {
            List<User> users = new List<User>();
            string query = string.Format("SELECT * FROM [tblUser]");

            using (SqlConnection con =
                    new SqlConnection(@"Data Source=.\sqlexpress;database=Sonartez_Server;uid=sonartez;pwd=123456"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User();
                        user.UserID = reader.GetGuid(0);
                        user.UserName = reader.GetString(1);
                        user.FullName = reader.GetString(2);
                        user.PhoneNumber = reader.GetString(3);
                        user.Email = reader.GetString(4);
                        user.Password = reader.GetString(5);
                        user.LastLoginTime = reader.GetDateTime(6);
                        user.Active = reader.GetInt32(7);                         
                       
                        users.Add(user);
                    }
                }
            }
            return users.ToArray();
        }

        public Models.User Get(Guid customerID)
        {
            throw new NotImplementedException();
        }

        public Models.User Add(Models.User item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid customerID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Models.User item)
        {
            throw new NotImplementedException();
        }
    }
}