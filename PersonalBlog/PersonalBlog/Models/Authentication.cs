using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PersonalBlog.Models
{
    public class Authentication : IAuth
    {
        public bool DoLogin(string username, string password)
        {
            PersonalBlogEntities entities = new PersonalBlogEntities();
            var user = entities.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {

                return true;
            }
            return false;
        }
    }
}