using System;

namespace PracticeDataStructAndALgo.LINQ
{
    public class Q4
    {
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int DepartmentId { get; set; }
            public double Salary { get; set; }
        }

        class Department
        {
            public int Id { get; set; }
            public string DepartmentName { get; set; }
        }
        public static void Run()
        {
            // Sample dataset
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", DepartmentId = 1, Salary = 60000 },
                new Employee { Id = 2, Name = "Bob",   DepartmentId = 2, Salary = 75000 },
                new Employee { Id = 3, Name = "Carol", DepartmentId = 1, Salary = 50000 },
                new Employee { Id = 4, Name = "David", DepartmentId = 3, Salary = 82000 },
                new Employee { Id = 5, Name = "Eve",   DepartmentId = 2, Salary = 70000 }
            };

            var departments = new List<Department>
            {
                new Department { Id = 1, DepartmentName = "IT" },
                new Department { Id = 2, DepartmentName = "HR" },
                new Department { Id = 3, DepartmentName = "Finance" }
            };
            //             Group employees by department.
            // For each department, calculate the average salary.
            // Return results ordered by average salary descending.
            var depData = employees.Join(departments, e => e.DepartmentId, d => d.Id, (e, d) => new { e, d })
            .GroupBy(d => d.d.DepartmentName).Select(i => new
            {
                department = i.Key,
                avg = i.Average(d => d.e.Salary)
            }).OrderByDescending(d => d.avg);

            foreach (var i in depData)
                Console.WriteLine($" department: {i.department} average sal: {i.avg}");
        }
    }
}