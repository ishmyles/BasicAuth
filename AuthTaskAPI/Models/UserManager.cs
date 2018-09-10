using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthTaskAPI.Models
{
    public class UserManager
    {
        private AuthDemoDBEntities1 _Context;

        public UserManager()
        {
            _Context = new AuthDemoDBEntities1();
        }

        public bool ValidateUser(string userName, string password)
        {
            var result = _Context.Users.SingleOrDefault(x => x.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) && x.Password == password);

            return result != null ? true : false;
        }
    }
}