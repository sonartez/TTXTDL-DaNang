using Sonartez.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sonartez.Services.Reponsitories
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAll();
        User Get(Guid userID);
        User Add(User item);
        void Remove(Guid userID);
        bool Update(User item);
    }
}