using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratory
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            
            context.Database.EnsureDeleted();
            
            context.Database.EnsureCreated();
            
            context.SaveChanges();

            int start_salary = 100;
            int finish_salary = 500;
            string filial = "filial";

            IQueryable<Employee> employees_1 = from employee in context.Employees
                where (employee.ByHours == true)
                select employee;
            
            IQueryable<Employee> employees_2 = from employee in context.Employees
                where (employee.Salary >= start_salary) && (employee.Salary <= finish_salary)
                select employee;
            
            IQueryable<Employee> employees_3 = from employee in context.Employees
                where employee.MainOffice.TitleOfCompany == filial
                select employee;
            
            List <Employee> list_1 = employees_1.ToList();
            foreach (Employee employee in employees_1)
            {
                Console.WriteLine(employee.FullName);
                Console.WriteLine(employee.Id);
            }

            List <Employee> list_2 = employees_2.ToList();
            foreach (Employee employee in employees_2)
            {
                Console.WriteLine(employee.FullName);
                Console.WriteLine(employee.Salary);
            }

            List <Employee> list_3 = employees_3.ToList();
            foreach (Employee employee in employees_3)
            {
                Console.WriteLine(employee.FullName);
                Console.WriteLine(employee.MainOffice);
            }
            
            context.Dispose();
        }
    }
}

/*База зарплат (Все сотрудники с зарплатой в диапазоне, все сотрудники с филиала, все сотрудники с зарплатой по часам)*/
