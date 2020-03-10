using DevOps.Data.Interfaces;
using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Data.DataRepository
{
    public class UserDataRepository : IUserDataRepository
    {
        DevOpsEntities DbContext;

        public UserDataRepository()
        {
            DbContext = new DevOpsEntities();
        }

        public List<User> GetAllUsers()
        {
            return DbContext.Users.ToList();
        }
        public User GetUser(int userId)
        {
            return DbContext.Users.Where(p => p.UserId == userId).FirstOrDefault();
        }
        public bool InsertUser(User user)
        {
            bool status;
          
            try
            {
               
                DbContext.Users.Add(user);
                DbContext.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public bool UpdateUser(User user)
        {
            bool status;
            try
            {
                User userTemp = DbContext.Users.Where(p => p.UserId == user.UserId).FirstOrDefault();
                if (userTemp != null)
                {
                    userTemp = user;
                    DbContext.Entry(userTemp).State = EntityState.Modified;
                    DbContext.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public bool DeleteUser(int id)
        {
            bool status;
            try
            {
                User user = DbContext.Users.Where(p => p.UserId == id).FirstOrDefault();
                if (user != null)
                {
                    DbContext.Users.Remove(user);
                    DbContext.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
    }
}
