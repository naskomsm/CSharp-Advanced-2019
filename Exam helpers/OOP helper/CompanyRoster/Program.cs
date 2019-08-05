namespace CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string employeeName = employeeInfo[0];
                double employeeSalary = double.Parse(employeeInfo[1]);
                string employeePosition = employeeInfo[2];
                string employeeDepartment = employeeInfo[3];

                Employee employee = new Employee(employeeName, employeeSalary, employeePosition, employeeDepartment);

                if (employeeInfo.Length == 4)
                {
                    employee = new Employee(employeeName, employeeSalary, employeePosition, employeeDepartment);
                    employees.Add(employee);
                }
                else if (employeeInfo.Length == 5)
                {
                    if (employeeInfo[4].Contains("@"))
                    {
                        employees.Add(new Employee(employeeName, employeeSalary, employeePosition, employeeDepartment, employeeInfo[4]));
                    }
                    else
                    {
                        employees.Add(new Employee(employeeName, employeeSalary, employeePosition, employeeDepartment, int.Parse(employeeInfo[4])));
                    }
                }
                else if (employeeInfo.Length == 6)
                {
                    employees.Add(new Employee(employeeName, employeeSalary, employeePosition, employeeDepartment,employeeInfo[4],int.Parse(employeeInfo[5])));
                }
            }

            string bestPaidDept = employees
           .GroupBy(e => e.Department)
           .Select(g => new { Department = g.Key, AvgSalary = g.Average(e => e.Salary) })
           .OrderByDescending(o => o.AvgSalary)
           .First()
           .Department;

            Console.WriteLine($"Highest Average Salary: {bestPaidDept}");

            employees
          .Where(e => e.Department == bestPaidDept)
          .OrderByDescending(e => e.Salary)
          .ToList()
          .ForEach(Console.WriteLine);
        }
    }
}
