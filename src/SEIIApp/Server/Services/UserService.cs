﻿using System;
using System.Collections.Generic;
using System.Linq;
using SEIIApp.Server.Domain;
using System.Threading.Tasks;
using SEIIApp.Server.DataAccess;

namespace SEIIApp.Server.Services
{
    public class UserService
    {
        private DatabaseContext DatabaseContext { get; set; }

        public UserService(DatabaseContext db)
        {
            this.DatabaseContext = db;
        }

        private IQueryable<User> GetQueryableForUser()
        {
            return DatabaseContext.User;
        }

        public User[] GetAllUser()
        {
            return GetQueryableForUser().ToArray();
        }

        public User GetUserWithId(int id)
        {
            return GetQueryableForUser().Where(user => user.UserId == id).FirstOrDefault();
        }

        public User GetUserWithName(string name)
        {
            return GetQueryableForUser().Where(user => user.Name.Equals(name)).FirstOrDefault();
        }

        public User AddUser(User user)
        {
            DatabaseContext.User.Add(user);
            DatabaseContext.SaveChanges();
            return user;
        }

    }
}
