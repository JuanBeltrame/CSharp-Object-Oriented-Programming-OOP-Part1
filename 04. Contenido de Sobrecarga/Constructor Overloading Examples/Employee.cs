using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading_Examples
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsManager { get; set; }
        public Employee Manager { get; set; }


        public Employee(string name, int age, bool isManager, Employee manager)
        {
            Name = name;
            Age = age;
            IsManager = isManager;
            Manager = manager;
        }
        public Employee(string name, int age, bool isManager)
            :this(name, age, isManager, null)
        {
           
        }

    }
}
