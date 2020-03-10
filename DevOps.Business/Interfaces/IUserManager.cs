using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Business.Interfaces
{
    public interface IUserManager
    {
        List<User> GetAllUsers();
        User GetUser(int userId);
        bool InsertUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
    }
}
