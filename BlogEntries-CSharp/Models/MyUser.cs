using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEntries_CSharp.Models
{
    public class MyUser
    {
        private string _username;
        private string _password;
        private List<string> _roles = new List<string>();
        
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public List<string> Roles
        {
            get
            {
                return _roles;
            }
        }

        public MyUser()
        {
            AddRole("user");
        }

        public MyUser(string username, string password)
        {
            _username = username;
            _password = password;
            AddRole("user");
        }

        public void AddRole(string role)
        {
            _roles.Add(role);
        }

        public bool RemoveRole(string role)
        {
            return _roles.Remove(role);
        }

        public override bool Equals(object obj)
        {
            if (this.Equals(obj)) return true;
            MyUser that = (MyUser)obj;
            if (this.Username.Equals(that.Username)) return true;
            return false;
        }
    }
}