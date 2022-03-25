using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    partial class Operations  //Lists
    {
        List<Member> _members = new List<Member>();
       
       public List<Member> Members => _members;
        List<Departament> _departaments = new List<Departament>();

        public List<Departament> Departaments => _departaments;

    }
    partial class Operations  //Main methods
    {
        public void ShowEmployees()
        {
            foreach (var item in Departaments)
            {
                foreach (var item1 in item.Employees)
                {
                    Console.WriteLine(item1);
                }

            }
        }
        public void ShowMembers()
        {
            foreach (var item in Members)
            {
                Console.WriteLine(item);
            }
        }
        public void CreateDep()
        {
            string name = Console.ReadLine().Trim().ToLower();
            name = Capitalized(name);
            Departament departament = new Departament(name);
            Departaments.Add(departament);
        }
        public void Register()
        {
            Member member = new Member(CheckUsername(), CheckEmail(), CheckPassword(), CheckFullname());
            Members.Add(member);
            Console.WriteLine("Succesfully resgistered");
        }
        public void CreateEmployee(Departament dep)
        {
            Employee member = new Employee(CheckUsername(), CheckEmail(), CheckPassword(), CheckFullname(),dep);
            dep.Employees.Add(member);
            Console.WriteLine("Succesfully created");
        }
        public Member Login()
        {   
            tryagain:
            Console.WriteLine("Please enter email or username");
            string consol = Console.ReadLine().Trim();
            Member member = null;
            foreach (var item in Members)
            {
                if (item.Email==consol||item.Username==consol)
                {
                    member = item;
                }
            }
            if (member==null)
            {
                Console.WriteLine("There is no user with this email or username");
                goto tryagain;
            }
            try1:
            string pass = Console.ReadLine();
            if (member.Password!=pass)
            {
                Console.WriteLine("incorrect password");
                goto try1;
            }
            return member;

        }
        public Employee LoginEmployee(Departament dep)
        {
        tryagain:
            Console.WriteLine("Please enter email or username");
            string consol = Console.ReadLine().Trim();
            Employee member = null;
            foreach (var item in dep.Employees)
            {
                if (item.Email == consol || item.Username == consol)
                {
                    member = item;
                }
            }
            if (member == null)
            {
                Console.WriteLine("There is no employee with this email or username");
                goto tryagain;
            }
        try1:
            string pass = Console.ReadLine();
            if (member.Password != pass)
            {
                Console.WriteLine("incorrect password");
                goto try1;
            }
            return member;

        }
    }
    partial class Operations  //Additional methods
    {
        public string CheckPassword()
        {
            tryagain:
            Console.WriteLine("Please enter password");
            string consol = Console.ReadLine();
            if (consol.Length<8)
            {
                Console.WriteLine("incorrect value");
                goto tryagain;
            }
            bool result = false;
            bool result2 = false;
            bool result3 = false;            
            for (int i = 0; i < consol.Length; i++)
            {
                if (Char.IsDigit(consol[i]))
                {
                    result = true;
                }
                if (char.IsLetter(consol[i])&&char.IsLower(consol[i]))
                {
                    result2 = true;
                }
                if (char.IsUpper(consol[i]))
                {
                    result3 = true;
                }
            }
            if (result&&result2&&result3)
            {
                return consol;
            }
            else
            {
                Console.WriteLine("incorrect value");
                goto tryagain;
            }                      
        }
        public string CheckUsername()
        {
        tryagain:
            Console.WriteLine("Please enter username");
            string consol = Console.ReadLine().Trim();
            if (consol.Length < 5)
            {
                Console.WriteLine("incorrect value");
                goto tryagain;
            }
            foreach (var item in Members)
            {
                if (item.Username.ToLower()==consol.ToLower())
                {
                    Console.WriteLine("incorrect value");
                    goto tryagain;
                }
            }            
            return consol;
        }
        public string CheckFullname()
        {
        try1:
            Console.WriteLine("Please enter name");
            string name = Console.ReadLine().Trim().ToLower();
            if (name.Length<3)
            {
                Console.WriteLine("incorrect value");
                goto try1;
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                {
                    Console.WriteLine("incorrect value");
                    goto try1;
                }
            }
            name = Capitalized(name);

        try2:
            Console.WriteLine("Please enter surname");
            string surname = Console.ReadLine().Trim().ToLower();
            if (surname.Length < 3)
            {
                Console.WriteLine("incorrect value");
                goto try2;
            }
            for (int i = 0; i < surname.Length; i++)
            {
                if (!Char.IsLetter(surname[i]))
                {
                    Console.WriteLine("incorrect value");
                    goto try2;
                }
            }
            surname = Capitalized(surname);
            string fullname = name + " " + surname;
            return fullname;

        }
        public string CheckEmail()
        {
        tryagain:
            Console.WriteLine("Please enter email");
            string consol = Console.ReadLine().Trim().ToLower();
            if (!consol.Contains('@')||consol.Length<8)
            {
                Console.WriteLine("incorrect value");
                goto tryagain;
            }
            int index = 0;
            for (int i = 0; i < consol.Length; i++)
            {
                if (consol[i]=='@')
                {
                    index = i;
                }
            }
            if (!char.IsDigit(consol[0])&&!Char.IsLetter(consol[0])|| !char.IsDigit(consol[consol.Length-1]) && !Char.IsLetter(consol[consol.Length - 1])|| !char.IsDigit(consol[consol.Length - 2]) && !Char.IsLetter(consol[consol.Length - 2]))
            {
                Console.WriteLine("incorrect value");
                goto tryagain;
            }
            foreach (var item in Members)
            {
                if (item.Email == consol)
                {
                    Console.WriteLine("incorrect value");
                    goto tryagain;
                }
            }

            return consol;

        }
        public string Capitalized(string fullname)
        {
            StringBuilder str = new StringBuilder();
            str.Append(fullname[0]);
            for (int i = 1; i <fullname.Length; i++)
            {
                str.Append(fullname[i]);
            }
            return str.ToString();
        }
        public Departament Find()
        {try1:
            Console.WriteLine("Enter departament name");
            string dep = Console.ReadLine().Trim();
            Departament departament = null;
            foreach (var item in Departaments)
            {
                if (item.Name==Capitalized(dep))
                {
                    departament = item;
                }
            }
            if (departament==null)
            {
                goto try1;
            }
            return departament;
        }
    }
}
