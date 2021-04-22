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

            Func<Employee, string> selector = employee => "Name = " + employee.Name;
            IEnumerable<string> names = employees.Select(selector);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
