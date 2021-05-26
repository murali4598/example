using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password );
        void UpdatePassword(User user, ChangePassword changePassword);
        public void UpdatePasswordOtp(User user, string changePassword);
        void Delete(int id);
    }

}
