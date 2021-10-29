using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLayer.Models;
using DataAccess.Repository;
using MyStoreWinApp;

namespace EmployeeManagementApp
{
    public partial class frmAdminControl : UserControl
    {
        private IEmployeeRepository employeeRepository;

        private IDepartmentRepository departmentRepository;

        BindingSource source;
        //Singleton
        private static frmAdminControl _instance;

        public static frmAdminControl Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new frmAdminControl();
                }

                return _instance;
            }
        }
        public frmAdminControl()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            departmentRepository = new DeparmentRepository();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            grvMemberList.AutoGenerateColumns = true;
            loadManagerList();
        }

        private void grvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string employeeId = getSelectedEmployeeId();
            Employee updateEmployee = employeeRepository.GetEmployeeById(employeeId);
            frmManagerDetail frmManagerDetail = new frmManagerDetail()
            {
                isUpdate = true,
                employeeInfomation = updateEmployee
            };
            frmManagerDetail.Show();
            frmManagerDetail.Closed += (sender, e) =>
            {
                loadManagerList();
            };
        }

        private string getSelectedEmployeeId()
        {
            //Get Id in gridview
            int index = grvMemberList.CurrentCell.RowIndex;
            string emId = grvMemberList.Rows[index].Cells[0].Value.ToString();
            return emId; 
        }

        private void loadManagerList()
        {
            grvMemberList.DataSource = employeeRepository.GetAllManager("R2");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string employeeId = getSelectedEmployeeId();
            DialogResult d;
            d = MessageBox.Show("Are you sure wanted to delete manager?", "Admin Manager - Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (d == DialogResult.Yes)
            {
                Employee deleteEmployee = employeeRepository.GetEmployeeById(employeeId);
                employeeRepository.DeleteEmployee(deleteEmployee);
                loadManagerList();
            }
        }



        //---------------------------------------------------------------------------------------------


        private Department GetDepartment()
        {
            Department depart = null;
            depart = new Department
            {
                DepartmentId = txtDepartmentID.Text,
                DepartmentName = txtDepartmentName.Text,
                ManagerId = txtDeparmentManagerId.Text,
                BaseSalary = short.Parse(txtDepartmentBaseSalary.Text),
            };
            return depart;
        }

        private void LoadDepartmentList()
        {
            IEnumerable<Department> departments = null;
            departments = departmentRepository.GetAllDepartments();

            try
            {
                source = new BindingSource();
                source.DataSource = departments;

                txtDepartmentID.DataBindings.Clear();
                txtDepartmentName.DataBindings.Clear();
                txtDeparmentManagerId.DataBindings.Clear();
                txtDepartmentBaseSalary.DataBindings.Clear();


                txtDepartmentID.DataBindings.Add("Text", source, "DepartmentId");
                txtDepartmentName.DataBindings.Add("Text", source, "DepartmentName");
                txtDeparmentManagerId.DataBindings.Add("Text", source, "ManagerId");
                txtDepartmentBaseSalary.DataBindings.Add("Text", source, "BaseSalary");

                dgvDepartment.DataSource = null;
                dgvDepartment.DataSource = source;
                dgvDepartment.Columns[4].Visible = false;
                dgvDepartment.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load department list");
            }
        }

        private void btnLoadDepartment_Click(object sender, EventArgs e)
        {
            LoadDepartmentList();
        }

        private void btnNewDepartment_Click(object sender, EventArgs e)
        {
            frmDepartmentDetail frmDepartmentDetail = new frmDepartmentDetail
            {
                InsertOrUpdate = false,
                Text = "New Department",
                deparmentRepository = departmentRepository,
            };
            if(frmDepartmentDetail.ShowDialog() == DialogResult.OK)
            {
                LoadDepartmentList();
                source.Position = source.Count - 1;
            }
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDepartmentDetail frmDepartmentDetail = new frmDepartmentDetail
            {
                Text = "Update Department",
                InsertOrUpdate = true,
                deparmentRepository = departmentRepository,
                DepartmentInfo = GetDepartment()
            };
            if(frmDepartmentDetail.ShowDialog() == DialogResult.OK)
            {
                LoadDepartmentList();
                source.Position = source.Count - 1;
            }

        }

        private void btnDepartmentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Department depart = GetDepartment();
                departmentRepository.DeleteDepartment(depart);
                LoadDepartmentList();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Delete Department");
            }
        }

        private void frmAdminControl_Load(object sender, EventArgs e)
        {
            dgvDepartment.CellDoubleClick += dgvDepartment_CellContentClick;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmManagerDetail frmManagerDetail = new frmManagerDetail()
            {
                isUpdate = false,
            };
            frmManagerDetail.Show();
            frmManagerDetail.Closed += (sender, e) =>
            {
                loadManagerList();
            };
        }
    }
}
