using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Models
{
    class Departament
    {
        List<Employee> _employees = new List<Employee>();
        public List<Employee> Employees => _employees;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Departament(string name)
        {
            Name = name;
        }
        

    }
}
