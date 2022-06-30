using WebAPIDemo.Entities;
using WebAPIDemo.Model;
using System.Collections.Generic;
using System.Linq;
namespace WebAPIDemo.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        int AddEmployee(Employee emp);
        int ModifyEmployee(Employee emp);
        int DeleteEmployee(int id);
    }
}
