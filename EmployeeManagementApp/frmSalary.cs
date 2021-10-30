using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Models;
using DataAccess.Repository;

namespace EmployeeManagementApp
{
    public partial class from : UserControl
    {
        private ISalaryRepository salaryRepository;

        BindingSource source;

        public Employee CurrentUser { get; set; }

        //Singleton
        private static from _instance;

        public static from Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new from();
                }

                return _instance;
            }
        }
        public from()
        {
            InitializeComponent();
            salaryRepository = new SalaryRepository();
        }

        private string getSelectedSalaryId()
        {
            //Get Id in gridview
            int index = grvSalary.CurrentCell.RowIndex;
            string id = grvSalary.Rows[index].Cells[0].Value.ToString();
            return id;
        }

        private void grvSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilterSalary_Click(object sender, EventArgs e)
        {
            loadSalaries();
        }

        private void loadSalaries()
        {
            source = new BindingSource();
            var fromDate = dtpFromDate.Value.Date;
            var toDate = dtpToDate.Value.Date;
            string managerDepartment = CurrentUser.DepartmentId;
            try
            {
                txtWorkHours.DataBindings.Clear();

                source.DataSource = salaryRepository.GetSalariesWithMember(fromDate, toDate, managerDepartment);
                txtWorkHours.DataBindings.Add("Text", source, "WorkHours");
                grvSalary.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updateWorkHours = Int32.Parse(txtWorkHours.Text);
            Salary salaryNeedUpdate = salaryRepository.GetSalaryById(getSelectedSalaryId());
            Salary updateSalary = new Salary()
            {
                SalaryId = salaryNeedUpdate.SalaryId,
                SalaryDate = salaryNeedUpdate.SalaryDate,
                EmployeeId = salaryNeedUpdate.EmployeeId,
                WorkHour = updateWorkHours,
            };
            salaryRepository.UpdateSalary(updateSalary);
            loadSalaries();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var dateNeedCreate = dtpNewSalaryDate.Value.Date;

        }
    }
}
