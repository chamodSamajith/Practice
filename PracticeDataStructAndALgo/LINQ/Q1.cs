using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeDataStructAndALgo.LINQ
{
    //     You are given two collections:
    // A list of students, each with Id, Name, and Age.
    // A list of enrollments, each with a StudentId and CourseName.
    // 👉 Write a LINQ query using Join() to return the list of students with the courses they are enrolled in.
    // Only include students who have at least one course.
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

            var studentEnrollments = students
                .Join(enrollments,
                    s => s.Id,
                    e => e.StudentId,
                    (s, e) => new { StudentName = s.Name, Course = e.CourseName });

            foreach (var item in studentEnrollments)
                Console.WriteLine($"Name: {item.StudentName}, Enrolled in: {item.Course}");


        }
    }
}
