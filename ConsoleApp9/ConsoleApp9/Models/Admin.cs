using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Admin
    {
        private string _password;
        private string _username;
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
        public Admin(string a, string b)
        {
            Username = a;
            Password = b;
        }
    }
}
