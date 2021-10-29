using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EmployeeDAO
    {
        private EManagerPRNContext _databaseContext;

        public List<Employee> GetEmployees()
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Employees.Include(e => e.Salaries).ToList();
            }
        }

        public List<Employee> GetManager(string roleId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Employees
                    .Where(employee => employee.RoleId == roleId).ToList();
            }
        }

        public Employee GetEmployeeById(string employeeId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Employees
                    .FirstOrDefault(employee => employee.EmployeeId == employeeId);
            }
        }

        public void AddEmployee(Employee newEmployee)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Add(newEmployee);
                _databaseContext.SaveChanges();
            }
        }

        public void DeleteEmployee(Employee deleteEmployee)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Remove<Employee>(deleteEmployee);
                _databaseContext.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee updateEmployee)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Update<Employee>(updateEmployee);

                //Commit to Database
                _databaseContext.SaveChanges();
            }
        }
    }
}
