using WebAPIDemo.Entities;
using WebAPIDemo.Model;
using System.Collections.Generic;
using System.Linq;
namespace WebAPIDemo.Repositories
{
    public class EmployeeRepositoy:IEmployeeRepository
    {
        RepositoriesContext context;
        public EmployeeRepositoy(RepositoriesContext context) //DI
        {
            this.context = context;
        }
        public int AddEmployee(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();  
            return 1;
        }

        public int DeleteEmployee(int id)
        {
            var emp = context.Employees.Where(e => e.Id == id).SingleOrDefault();
            if (emp != null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public int ModifyEmployee(Employee emp)
        {
            var employee = context.Employees.Where(e => e.Id == emp.Id).SingleOrDefault();
            if (employee != null)
            {
                employee.Name=emp.Name;
                employee.Salary = emp.Salary;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
