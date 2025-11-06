using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    public static class MyClass
    {
        public static void Main()
        {
            //var employees = Enumerable.Range(1, 10).Select(GenerateEmployee);

            using var db = new EFContext();

            //foreach (var employee in employees)
            //{
            //    db.Employees.Add(employee);
            //}

            //db.SaveChanges();

            var result = db.Employees;
            foreach (var employee in result)
            {
                Console.WriteLine($"{employee.ID}\n{employee.Name}\n");
            }

            //var allEmployees = db.Employees.ToList();
            //db.Employees.RemoveRange(allEmployees);
            //db.SaveChanges();
        }
        public static Employee GenerateEmployee(int index)
        {
            return new Employee
            {
                Name = $"Name_{index}"
            };
        }
    }
}