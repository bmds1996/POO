using System;
using System.Collections.Generic;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();

            employees.Add(new Employee
            {
                BornDate = new Date(1974, 9, 23),
                FirstName = "Brayan",
                LastName = "Durango",
                HireDate = new Date(1996, 6, 14),
            });

            employees.Add(new Employee
            {
                BornDate = new Date(1974, 13, 45),
                FirstName = "Celia",
                LastName = "Cruz",
                HireDate = new Date(2001, 2, 29),
            });

            employees.Add(new Employee
            {
                BornDate = new Date(1984, 12, 42),
                FirstName = "Freddy",
                LastName = "Mercury",
                HireDate = new Date(2001, 2, 29),
            });

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
            Console.WriteLine("Hasta la vista baby.");

        }
    }
}
