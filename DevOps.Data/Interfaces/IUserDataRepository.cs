using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Data.Interfaces
{
    public interface IUserDataRepository
    {
        List<User> GetAllUsers();
        User GetUser(int userId);
        bool InsertUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
    }
}
