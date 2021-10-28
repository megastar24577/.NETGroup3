using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public interface ISalaryRepository
    {
        List<Salary> GetAllSalaries();

        Salary GetSalaryById(string salaryId);

        Salary GetSalaryByEmployeeId(string employeeId);

        void UpdateSalary(Salary updateSalary);

        void DeleteSalary(Salary deleteSalary);

        void NewSalary(Salary newSalary);
    }
}
