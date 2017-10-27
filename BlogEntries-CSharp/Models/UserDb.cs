using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEntries_CSharp.Models
{
    public class UserDb
    {
        private ISet<MyUser> users = new HashSet<MyUser>();

        public UserDb()
        {
            var user1 = new MyUser("user", "abc");
            var user2 = new MyUser("admin", "def");
            user2.AddRole("admin");
            users.Add(user1);
            users.Add(user2);
        }

        public bool AddUser(MyUser user)
        {
            return users.Add(user);
        }
    }
}