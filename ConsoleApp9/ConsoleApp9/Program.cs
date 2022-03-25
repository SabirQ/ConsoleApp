using ConsoleApp9.Models;
using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operation = new Operations();
            Admin admin = new Admin("Sabir", "123456");           
            int num;            
            bool result = false;
            
           do
           {
                    Console.WriteLine("1.Member\n2.Employee\n3.Admin\n\n\n0.Exit");
                    string str = Console.ReadLine().Trim();
                     result = int.TryParse(str, out num);
                if (result)
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("1.Register\n2.login");
                            int num1;                            
                            bool result1 = false;                            
                            do
                            {
                               string str1 = Console.ReadLine().Trim();
                                result1 = int.TryParse(str1, out num1);
                                if (result1&& num1 == 1 || num1 == 2)
                                {
                                    switch (num1)
                                    {
                                        case 1:
                                            operation.Register();
                                            break;

                                        case 2:
                                           Member member= operation.Login();
                                            Console.WriteLine(member.Fullname+" "+member.Username);
                                            break;
                                    }
                                }
                                

                            } while (!result1 || num1 == 1 && num1 == 2);
                            break;
                        case 2:
                            Departament dep= operation.Find();
                            Employee emp=operation.LoginEmployee(dep);
                            break;
                        case 3:
                            string a = Console.ReadLine().Trim();
                            string b = Console.ReadLine();
                            if (a==admin.Username&&b==admin.Password)
                            {
                                
                                int num2;
                                bool result2 = false;
                                do
                                {
                                    Console.WriteLine("1.Create Employee\n2.Show members\n3.Show employees\n4.Create departament");
                                    string str2 = Console.ReadLine().Trim();
                                    result2 = int.TryParse(str2, out num2);
                                    if (result2 && num2 == 1 || num2 == 2 || num2==3 || num2 == 4)
                                    {
                                        switch (num2)
                                        {
                                            case 1:
                                                Departament dep1 = null;
                                                dep1 = operation.Find();
                                                operation.CreateEmployee(dep1);                                                
                                                break;
                                            case 2:
                                                operation.ShowMembers();
                                                break;
                                            case 3:
                                                operation.ShowEmployees();
                                                break;
                                            case 4:
                                                operation.CreateDep();
                                                break;
                                        }
                                    }

                                } while (!result2 || num2 == 1 && num2 == 2&&num2 ==3 && num2 == 4);
                            }
                            break;
                        case 0:

                            break;
                    }
                }
                    
           } while (!result||num != 0);
            
            
        }
    }
}
