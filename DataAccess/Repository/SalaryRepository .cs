using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public class SalaryRepository : ISalaryRepository
    {
        private SalaryDAO salaryDao;

        public SalaryRepository()
        {
            salaryDao = new SalaryDAO();
        }

        public List<Salary> GetAllSalaries()
            => salaryDao.GetSalaries();

        public List<SalariesAndEmployeeDTO> GetSalariesWithMember(DateTime fromDate, DateTime toDate, string departId)
            => salaryDao.GetSalariesWithMember(fromDate,toDate,departId);

        public Salary GetSalaryById(string salaryId)
            => salaryDao.GetSalaryById(salaryId);

        public Salary GetSalaryByEmployeeId(string employeeId)
            => salaryDao.GetSalaryByEmployeeId(employeeId);

        public void UpdateSalary(Salary updateSalary)
            => salaryDao.UpdateSalary(updateSalary);

        public void DeleteSalary(Salary deleteSalary)
            => salaryDao.DeleteSalary(deleteSalary);

        public void NewSalary(Salary newSalary)
            => salaryDao.NewSalary(newSalary);
    }
}
