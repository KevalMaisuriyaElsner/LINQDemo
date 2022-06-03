using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> strList = new List<string>() { "Keval", "Maisuriya" };

            //var methodResult = strList.SelectMany(x => x).ToList();

            //var queryResuy = (from str in strList
            //                  from st in str
            //                  select st).ToList();






            //var dataSource = new List<Employee>
            //{
            //    new Employee(){Id=1, Name="Tom", Email="tom@gmail.com",Programming=new List<string>(){ "C#","Java","PHP"} },
            //    new Employee(){Id=1, Name="Kim", Email="kim@gmail.com",Programming=new List<string>(){ "LINQ","Java","MVC"} },
            //    new Employee(){Id=1, Name="Harry", Email="harry@gmail.com",Programming=new List<string>(){ "C#","SQL","VB"} }
            //};

            //var methodSyntax = dataSource.SelectMany(emp => emp.Programming).ToList();

            //var querySyntax = (from emp in dataSource
            //                   from skill in emp.Programming
            //                   select skill).ToList();


            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine("Programming " + item);
            //}

            //var queryResult = (from ds in dataSource
            //                   select ds).ToList();


            #region Where in LINQ
            //Where in LINQ

            //var dataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var querySyntax = (from number in dataSource
            //                   where number < 5
            //                   select number).ToList() ;

            //var methodSyntax = dataSource.Where(num => num < 5).ToList();
            //foreach(var item in dataSource)
            //{
            //    Console.WriteLine(dataSource);
            //} 
            #endregion Where in LINQ

            #region Sorting Operator
            //Sorting Operator

            //var dataSourceInt = new List<int>() { 5, 7, 8, 9, 3, 6, 2, 1, 4 };

            //var querySyntax = (from num in dataSourceInt
            //                   where num > 7
            //                   orderby num 
            //                   select num).ToList();

            //var methodSyntax = dataSourceInt.Where(num => num < 9).OrderBy(num => num).ToList();

            //foreach(var item in methodSyntax)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion Sorting Operator

            #region Reverse in LINQ
            //Reverse in LINQ
            //int[] rollNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var mq = rollNums.Reverse();

            //var qs = (from num in rollNums
            //         select num).Reverse();

            //foreach (var item in mq)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion Reverse in LINQ

            #region Paging using skip take operators
            // Start Paging using skip and take operators (Pagination)
            //do
            //{
            //    IEnumerable<Student> students = Student.GetAllStudents();

            //    Console.WriteLine("Please Enter the page number between the 1,2,3 and 4");
            //    int pageNumber = 0;

            //    if (int.TryParse(Console.ReadLine(), out pageNumber))
            //    {
            //        if (pageNumber >= 1 && pageNumber <= 4)
            //        {
            //            int pageSize = 3;
            //            IEnumerable<Student> result = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            //            Console.WriteLine();
            //            Console.WriteLine("Displying Page" + pageNumber);
            //            foreach (Student s in result)
            //            {
            //                Console.WriteLine(s.StudentId + "\t" + s.Name + "\t" + s.TotalMarks);
            //            }
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please number must be an integer between 1 and 4");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please number must be an integer between 1 and 4");
            //    }
            //} while (1 == 1);
            // End Paging using skip and take operators (Pagination)
            #endregion Paging using skip take operators

            #region Group BY
            // Start Group By in Linq

            //This is Method Syntax
            //var employeeGroups = Employee.GetAllEmployees().GroupBy(x => x.Department);

            //This is Query Syntax
            //var employeeGroups = from employee in Employee.GetAllEmployees()
            //                     group employee by employee.Department into eGroup
            //                     orderby eGroup.Key
            //                     select new
            //                     {
            //                         Key = eGroup.Key,
            //                         Employee = eGroup.OrderBy(x => x.Name)
            //                     };

            //foreach(var group in employeeGroups)
            //{
            // Count the Total male in department
            //Console.WriteLine("{0} - {1}", group.Key, group.Count(x => x.Gender == "Male"));   

            // Find the Maximuml(Max)/Minimum(Min)/Sum(Total salary) Salary of each department
            //Console.WriteLine("{0} - {1}", group.Key, group.Max(x => x.Salary));

            // Total count of the employee
            //    Console.WriteLine("{0} - {1}", group.Key, group.Employee.Count());
            //    Console.WriteLine("-------------");
            //    foreach(var employee in group.Employee)
            //    {
            //        // Print the Employee Name and Department
            //        Console.WriteLine(employee.Name +  "\t" + employee.Department);
            //    }
            //    // Print the blank line
            //    Console.WriteLine();Console.WriteLine();


            //}

            // End Group By in Linq
            #endregion Group BY

            #region Group By Multiple Key in Linq
            //var emloyeeGroups = from employee in Employee.GetAllEmployees()
            //                        group employee by new { employee.Department, employee.Gender } into eGroup
            //                    orderby eGroup.Key.Department, eGroup.Key.Gender
            //                    select new
            //                    {
            //                        Dept = eGroup.Key.Department,
            //                        Gender = eGroup.Key.Gender,
            //                        Employees = eGroup.OrderBy(x => x.Name)
            //                    };  

            //foreach(var group in emloyeeGroups)
            //{
            //    Console.WriteLine("{0} department {1} employees count = (2)",
            //        group.Dept, group.Gender, group.Employees.Count());
            //    Console.WriteLine("------------------------------------------");
            //    foreach(var employee in group.Employees)
            //    {
            //        Console.WriteLine(employee.Name + "\t" + employee.Gender + "\t" + employee.Department);
            //    }
            //    Console.WriteLine(); Console.WriteLine();
            //}


            #endregion Group By Multiple Key in Linq

            #region Group Join in Linq

            //Method Syntax

            //var employeesByDepartment = Department.GetAllDepartments()
            //                          .GroupJoin(Employee.GetAllEmployees(),
            //                                    d => d.ID,
            //                                    e => e.DepartmentId,
            //                                    (department, employees) => new
            //                                    {
            //                                        Department = department,
            //                                        Employees = employees
            //                                    });

            //foreach(var department in employeesByDepartment)
            //{
            //    Console.WriteLine(department.Department.Name);
            //    foreach (var employee in department.Employees)
            //    {
            //        Console.WriteLine(" " + employee.Name);
            //    }
            //    Console.WriteLine();
            //}

            //End Method Syntax

            // Query Syntax

            var employeesByDepartment = from d in Department.GetAllDepartments()
                                        join e in Employee.GetAllEmployees()
                                        on d.ID equals e.DepartmentId into eGroup
                                        select new
                                        {
                                            Department = d,
                                            Employee = eGroup
                                        };

            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name);
                foreach (var employee in department.Employee)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine();
            }

            // End Query Syntax

            #endregion Group Join in Linq
            //Console.ReadLine();
        }
    }
}
