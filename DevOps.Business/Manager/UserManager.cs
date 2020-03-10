using DevOps.Business.Interfaces;
using DevOps.Data.Interfaces;
using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Business.Manager
{
    public class UserManager : IUserManager
    {
        private IUserDataRepository _userDataRepository;

        public UserManager() { }

        public UserManager(IUserDataRepository userDataRepository)
        {
            _userDataRepository = userDataRepository;
        }

        public List<User> GetAllUsers()
        {
            return _userDataRepository.GetAllUsers();
        }

        public User GetUser(int userId)
        {
            return _userDataRepository.GetUser(userId);
        }

        public bool InsertUser(User user)
        {
            return _userDataRepository.InsertUser(user);
        }

        public bool UpdateUser(User user)
        {
            return _userDataRepository.UpdateUser(user);
        }

        public bool DeleteUser(int id)
        {
            return _userDataRepository.DeleteUser(id);
        }
    }
}
