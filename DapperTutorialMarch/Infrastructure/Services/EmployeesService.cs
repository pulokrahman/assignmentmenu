using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Services;
namespace Infrastructure.Services
{
    public class EmployeesService : IEmployeesService
    {
        EmployeeRepository employeeRepository;
        public EmployeesService()
        { employeeRepository = new EmployeeRepository(); }
        public void AddEmployee()
        {
            Employees employees = new Employees();
            Console.WriteLine("Enter First Name: ");
            employees.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            employees.LastName = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            employees.Salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Deptid: ");
            employees.DeptId = Convert.ToInt32(Console.ReadLine());
            if (employeeRepository.Insert(employees) > 0) //Reflects the number of records impacted
            {
                Console.WriteLine("Successfully Inserted");
            }
            else
            {
                Console.WriteLine("Error");
            }





        }
        public void DeleteEmployees()
        {
            Console.WriteLine("What is the id to Delete");
            int id = Convert.ToInt32(Console.ReadLine());
            employeeRepository.DeleteById(id);

        }
        public void UpdateEmployee()
        {
            Employees employees = GetEmployeebyID();
            Console.WriteLine("Enter First Name: ");
            employees.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            employees.LastName = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            employees.Salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Deptid: ");
            employees.DeptId = Convert.ToInt32(Console.ReadLine());
            employeeRepository.Update(employees);


        }

        public Employees GetEmployeebyID()
        {
            Console.WriteLine("What is the id?");
            int id = Convert.ToInt32(Console.ReadLine());
            Employees e = employeeRepository.GetById(id);
            Console.WriteLine($"{e.Id} \t {e.FirstName} \t {e.LastName} \t $ {e.Salary}  \t  {e.DeptId}");
            return e;
        }
        public void GetAllEmployees()
        {
            IEnumerable<Employees> employees = employeeRepository.GetAll();
            foreach (Employees e in employees)
            {
                Console.WriteLine($"{e.Id} \t {e.FirstName} \t {e.LastName} \t $ {e.Salary}  \t  {e.DeptId}");
            }

        }
    }
}
