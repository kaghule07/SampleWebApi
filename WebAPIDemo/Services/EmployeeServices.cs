using WebAPIDemo.Model;
using WebAPIDemo.Repositories;
using System;
using System.Collections.Generic;
namespace WebAPIDemo.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository _iEmployeeRepo;
        public EmployeeServices(IEmployeeRepository iEmployeeRepo)
        {
            _iEmployeeRepo = iEmployeeRepo; 
        }
        public int AddEmployee(Employee emp)
        {
            return _iEmployeeRepo.AddEmployee(emp);
        }

        public int DeleteEmployee(int id)
        {
            return _iEmployeeRepo.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _iEmployeeRepo.GetAllEmployees();
        }

        public int ModifyEmployee(Employee emp)
        {
            return _iEmployeeRepo.ModifyEmployee(emp);  
        }
    }
}
