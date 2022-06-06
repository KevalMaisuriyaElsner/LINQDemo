using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo
{
    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }


        public string Gender { get; set; }

        public int Salary { get; set; }
        public string Department { get; set; }

        public int DepartmentId { get; set; }
        //public List<string> Programming { get; set; }

        public List<Techs> Programming { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { Id=1, Name="Mark", Gender="Male",Department="IT", Salary=45000, DepartmentId = 1},
                new Employee { Id=2, Name="Stevey", Gender="Female",Department="HR", Salary=50000, DepartmentId = 2},
                new Employee { Id=3, Name="Ben", Gender="Male",Department="IT", Salary=65000, DepartmentId = 1},
                new Employee { Id=4, Name="Philip", Gender="Male",Department="HR", Salary=75000, DepartmentId = 1},
                new Employee { Id=5, Name="Jeny", Gender="Female",Department="IT", Salary=70000, DepartmentId = 2},
                new Employee { Id=6, Name="Palmy", Gender="Female",Department="HR", Salary=55000, DepartmentId = 1},
                new Employee { Id=7, Name="Rock", Gender="Male",Department="HR", Salary=40000, DepartmentId = 2},
                new Employee { Id=8, Name="Pauly", Gender="Female",Department="HR", Salary=35000, DepartmentId = 1},
                new Employee { Id=9, Name="Andy", Gender="Male",Department="IT", Salary=47000, DepartmentId = 1},
                new Employee { Id=10, Name="Mary", Gender="Female",Department="HR", Salary=58000}
            };

        }
    }

    public class Techs
    {
        public string Technology { get; set; }
    }
}
