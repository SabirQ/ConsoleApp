using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Employee
    {
        private string _username;
        private string _password;
        private string _fullname;
        private string _email;
        private Departament _departament;
        public Departament Departament
        {
            get
            {
                return _departament;
            }
            set
            {
                _departament = value;
            }
        }
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
        public Employee(string username, string email, string password, string fullname,Departament dep)
        {
            Username = username;
            Email = email;
            Password = password;
            Fullname = fullname;
            Departament = dep;
        }
    }
}
