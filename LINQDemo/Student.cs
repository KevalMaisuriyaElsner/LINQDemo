using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo
{
    class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int TotalMarks { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudent = new List<Student>
            {
            new Student
            {
                StudentId = 101, Name = "Tom", TotalMarks = 800
            },
            new Student
            {
                StudentId = 102, Name = "Max", TotalMarks = 900
            },
            new Student
            {
                StudentId = 103, Name = "Pam", TotalMarks = 700
            },
            new Student
            {
                StudentId = 104, Name = "Jerry", TotalMarks = 500
            },
            new Student
            {
                StudentId = 105, Name = "Paul", TotalMarks = 900
            },
             new Student
            {
                StudentId = 106, Name = "Harry", TotalMarks = 400
            },
            new Student
            {
                StudentId = 107, Name = "Thor", TotalMarks = 700
            },
            new Student
            {
                StudentId = 108, Name = "Parker", TotalMarks = 500
            },
            new Student
            {
                StudentId = 109, Name = "Jack", TotalMarks = 900
            },
            new Student
            {
                StudentId = 110, Name = "Potter", TotalMarks = 600
            }, 
            new Student
            {
                StudentId = 111, Name = "Walker", TotalMarks = 700
            },
        };
            return listStudent;
        }
    }
}
