using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sonartez.Services.Models
{
    public class User
    {
        public Guid UserID { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime LastLoginTime { get; set; }

        public int Active { get; set; }

        public string UserName { get; set; }
    }
}