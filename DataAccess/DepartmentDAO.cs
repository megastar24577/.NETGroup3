using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class DepartmentDAO
    {
        private EManagerPRNContext _databaseContext;

        public List<Department> GetAllDepartments()
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Departments.ToList();
            }
        }

        public Department GetDepartmentById(string departmentId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Departments.FirstOrDefault(depart => depart.DepartmentId == departmentId);
            }
        }

        public void CreateDepartment(Department department)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Add(department);
            }
        }

        public void DeleteDepartment(Department deletedDepartment)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Remove<Department>(deletedDepartment);
                _databaseContext.SaveChanges();
            }
        }

        public void UpdateDeparment(Department updatedDepartment)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Update<Department>(updatedDepartment);

                //Commit to Database
                _databaseContext.SaveChanges();
            }
        }
    }
}
