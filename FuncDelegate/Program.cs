using System;
using System.Collections.Generic;

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
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
