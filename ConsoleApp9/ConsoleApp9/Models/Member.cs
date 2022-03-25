using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    partial class Member  //Fields
    {
        private string _username;
        private string _password;
        private string _fullname;
        private string _email;
        
    }
    partial class Member  //Properties
    {
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
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            { 
                _email = value;
            }
        }
    }
    partial class Member  //Constructor
    {
        public Member(string username,string email,string password,string fullname)
        {
            Username = username;
            Email = email;
            Password = password;
            Fullname = fullname;
        }
    }
}
