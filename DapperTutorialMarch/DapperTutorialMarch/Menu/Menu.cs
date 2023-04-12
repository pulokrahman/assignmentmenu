using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialMarch.Menu
{
    public class MenuSelection
    {
        DepartmentService e;
        EmployeesService d;
        public MenuSelection() 
        {
            e = new DepartmentService();
            d = new EmployeesService();
        }
        public void Run()
        {
            int choice;
            int choice2=-1;
            do {
                choice = InputChoice();
                if (choice < 6 && choice > 0)
                    choice2 = EmployeesorDepartment();
                switch (choice)
                {

                    case 1:
                        switch (choice2)
                        {
                            case 1:
                                e.AddDepartment();
                                break;
                            case 2:
                                d.AddEmployee();
                                break;
                        }
                        break;
                    case 2:
                        switch (choice2)
                        {
                            case 1:
                                e.DeleteDepartment();
                                break;
                            case 2:
                                d.DeleteEmployees();
                                break;
                        }
                        break;
                    case 3:
                        switch (choice2) {
                            case 1:
                                e.GetAllDepartments();
                                break;
                            case 2:
                                d.GetAllEmployees();
                                break;
                        }
                        break;
                    case 4:
                        switch (choice2) {
                            case 1:
                                e.UpdateDepartment();
                                break;
                            case 2:
                                d.UpdateEmployee();
                                break;

                        }
                        break;
                    case 5:
                        switch (choice2) {
                            case 1: 
                            e.GetDepartmentById();
                                break;
                            case 2:
                                d.GetEmployeebyID();
                                break;
                }
                        break;
                   
                    
                }
            }
             while (choice!=6) ;
        }

        public int InputChoice()
        {
            Console.WriteLine("What do you want \n 1:Insert  \n 2:Delete   \n 3:Get all   \n 4:Update   \n 5. Get Single \n 6. Exit   ");

            do
            {
                try
                {
                    var choice = Convert.ToInt32(Console.ReadLine());
                    if (choice > 0 && choice < 7)
                        return choice;
                    Console.WriteLine("Not valid input");
                }
                catch
                {
                    Console.WriteLine("Not valid input");
                }
            } while (true);
            return 6;
               
        }
        public int EmployeesorDepartment()
        {
            Console.WriteLine("1:Departments \n 2:Employees");

            do
            {
                try
                {

                    var choice = Convert.ToInt32(Console.ReadLine());
                   if (choice==1 || choice==2)
                    return choice;
                    Console.WriteLine("Not valid input");
                }
                catch
                {
                    Console.WriteLine("Not valid input");
                }
            }
            while (true);
            return 3;
        }
    }
}
