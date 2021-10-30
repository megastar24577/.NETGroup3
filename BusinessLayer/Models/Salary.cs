using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer.Models
{
    public partial class Salary
    {
        public string SalaryId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime SalaryDate { get; set; }
        public int WorkHour { get; set; }

        public Employee Employee { get; set; }
    }
}
