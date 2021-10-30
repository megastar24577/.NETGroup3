using BusinessLayer.Models;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagementApp
{
    public partial class frmDepartmentDetail : Form
    {
        public frmDepartmentDetail()
        {
            InitializeComponent();
        }
        
        //---------------------------------------------------------------
        public IDepartmentRepository deparmentRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Department DepartmentInfo { get; set; }

        private void frmDepartmentDetail_Load(object sender, EventArgs e)
        {
            txtDepartmentID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtDepartmentID.Text = DepartmentInfo.DepartmentId;
                txtDepartmentName.Text = DepartmentInfo.DepartmentName;
                txtDepartmentManagerId.Text = DepartmentInfo.ManagerId;
                txtDepartmentBaseSalary.Text = DepartmentInfo.BaseSalary.ToString();
            }
        }


        //---------------------------------------------------------------

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var managerIdCheck = txtDepartmentManagerId.Text;
                if (managerIdCheck == "")
                {
                    managerIdCheck = null;
                }
                var Department = new Department
                {
                    DepartmentId = txtDepartmentID.Text.ToUpper(),
                    DepartmentName = txtDepartmentName.Text.ToUpper(),
                    ManagerId = managerIdCheck,
                    BaseSalary = short.Parse(txtDepartmentBaseSalary.Text),
                };

                if(InsertOrUpdate == false)
                {
                    deparmentRepository.AddDepartment(Department);
                } else
                {
                    deparmentRepository.UpdateDepartment(Department);
                }
                Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate ? "Insert Department" : "Update Department");
            }
        }

        //---------------------------------------------------------------

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
