using WebAPIDemo.Entities;
using WebAPIDemo.Model;
using System.Collections.Generic;
using System.Linq;
namespace WebAPIDemo.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> GetAllEmployees();
        int AddEmployee(Employee emp);
        int ModifyEmployee(Employee emp);
        int DeleteEmployee(int id);
    }
}
