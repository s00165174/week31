using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using week31.Models;

namespace week31.DAL
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<User> GetUsers();
        User GetUserByID(int userID);
        void InsertUser(User user);
        void UpdateUSer(User user);
        void DeleteUSer(int userID);
        void Save();
    }
}