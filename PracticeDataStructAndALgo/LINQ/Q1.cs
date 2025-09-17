using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeDataStructAndALgo.LINQ
{
    public static class Q1
    {
        public class Student
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public int Age { get; set; }
        }

        public class Enrollment
        {
            public int StudentId { get; set; }
            public string? CourseName { get; set; }
        }

        public static void Solve()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Alice", Age = 20 },
                new Student { Id = 2, Name = "Bob", Age = 21 },
                new Student { Id = 3, Name = "Charlie", Age = 19 }
            };

            var enrollments = new List<Enrollment>
            {
                new Enrollment { StudentId = 1, CourseName = "Math" },
                new Enrollment { StudentId = 1, CourseName = "Physics" },
                new Enrollment { StudentId = 2, CourseName = "Biology" }
            };

            Console.WriteLine("From Q1");
        }
    }
}
