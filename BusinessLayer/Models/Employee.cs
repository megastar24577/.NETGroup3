using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Departments = new HashSet<Department>();
            Salaries = new HashSet<Salary>();
        }

        public string EmployeeId { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public string RoleId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DepartmentId { get; set; }

        public Department Department { get; set; }
        public Role Role { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<Salary> Salaries { get; set; }
    }
}
