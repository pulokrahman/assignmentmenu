using ApplicationCore.Entities;
using Infrastructure.Services;
using DapperTutorialMarch.Menu;


namespace DapperTutorialMarch;

public class Program
{
    public static void Main()
    {
        //   DepartmentService e = new DepartmentService();
        //    e.AddDepartment();
        //e.DeleteDepartment();
        //e.GetAllDepartments();
        //e.UpdateDepartment();
        //e.GetDepartmentById();

            MenuSelection menu = new MenuSelection();
          menu.Run();
       // EmployeesService e = new EmployeesService();
        //    e.AddEmployee();
        //  e.GetAllEmployees();
        // e.GetEmployeebyID();
        // e.UpdateEmployee();
        // e.GetEmployeebyID();
      //  e.DeleteEmployees();
    //    e.GetAllEmployees();
    }
}