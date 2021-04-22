using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ Id = 101, Name="Mark"},
                new Employee{ Id = 102, Name="John"},
                new Employee{ Id = 102, Name="Mary"}
            };

            //Func<Employee, string> selector = employee => "Name = " + employee.Name;
            static string selector(Employee employee) => "Name = " + employee.Name;
            //IEnumerable<string> names = employees.Select(selector);
            IEnumerable<string> names = employees.Select(employee => "Name = " + employee.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Func<int, int, string> funcDelegate = (firstNumber, secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();

            static string sum(int firstNumber, int secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();

            string Sum(int firstNumber, int secondNumber)
            {
                return "Sum = " + (firstNumber + secondNumber).ToString();
            }

            Console.WriteLine(funcDelegate(10, 20));
            Console.WriteLine(sum(5, 6));
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GetIdentity()
        {
            return "Identity = " + Id + Name;
        }

        public string GetFullName() => Name + " " + Surname;
    }
}
