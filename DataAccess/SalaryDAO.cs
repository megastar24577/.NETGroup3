using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Models;

namespace DataAccess
{
    public class SalaryDAO
    {
        private EManagerPRNContext _databaseContext;

        public List<Salary> GetSalaries()
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Salaries.ToList();
            }
        }

        public Salary GetSalaryById(string salaryId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Salaries.Find(salaryId);
            }
        }

        public Salary GetSalaryByEmployeeId(string employeeId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Salaries
                    .FirstOrDefault(salary => salary.EmployeeId == employeeId);
            }
        }

        public void NewSalary(Salary newSalary)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Add(newSalary);
                _databaseContext.SaveChanges();
            }
        }

        public void DeleteSalary(Salary deleteSalary)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Remove(deleteSalary);
                _databaseContext.SaveChanges();
            }
        }

        public void UpdateSalary(Salary updateSalary)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Add(updateSalary);
                _databaseContext.SaveChanges();
            }
        }
    }
}