using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessLayer.Models;


namespace EmployeeManagementApp
{
    public partial class frmManager : UserControl
    {
        private IEmployeeRepository EmployeeRepository = new EmployeeRepository();
        private IEnumerable<Employee> list;
        private BindingSource source;

        //Singleton
        private static frmManager _instance;

        public static frmManager Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new frmManager();
                }

                return _instance;
            }
        }

        public frmManager()
        {
            InitializeComponent();
        }

        private void clearText()
        {
            txtEmployeeID.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtDepartmentID.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtFullName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            mtbPhone.Text = String.Empty;
            txtRoleID.Text = String.Empty;
        }
        public void LoadEmployeeList()
        {
            var employees = EmployeeRepository.GetAllEmployees();
            try
            {
                if (list.Count() == 0)
                {
                    // hien lable list trong 
                    btnDelete.Enabled = false;
                    clearText();
                }
                else
                {
                    //list khong trong
                    btnDelete.Enabled = true;
                }

                source = new BindingSource();
                source.DataSource = list;

                txtEmail.DataBindings.Clear();
                txtFullName.DataBindings.Clear();
                txtEmployeeID.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtDepartmentID.DataBindings.Clear();
                txtRoleID.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                mtbPhone.DataBindings.Clear();

                txtEmployeeID.DataBindings.Add("Text", source, "EmployeeId");
                txtFullName.DataBindings.Add("Text", source, "Fullname");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtDepartmentID.DataBindings.Add("Text", source, "DepartmentId");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtRoleID.DataBindings.Add("Text", source, "RoleId");

                dgvManager.DataSource = null;
                dgvManager.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }

        }

        private void Editable()
        {
            txtEmail.ReadOnly = false;
            txtFullName.ReadOnly = false;
            txtEmployeeID.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtDepartmentID.ReadOnly = false;
            txtRoleID.ReadOnly = false;
            txtAddress.ReadOnly = false;
            btnCancel.Visible = true;
            btnConfirm.Visible = true;
                
        }

        private void UnEditable()
        {
            txtEmail.ReadOnly = true;
            txtFullName.ReadOnly = true;
            txtEmployeeID.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtDepartmentID.ReadOnly = true;
            txtRoleID.ReadOnly = true;
            txtAddress.ReadOnly = true;
            btnCancel.Visible = false;
            btnConfirm.Visible = false;

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            list = EmployeeRepository.GetAllEmployees();
            LoadEmployeeList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Editable();
            clearText();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Employee deleteEmplyee = EmployeeRepository.GetEmployeeById(txtEmployeeID.Text);
                EmployeeRepository.DeleteEmployee(deleteEmplyee);
                list = EmployeeRepository.GetAllEmployees();
                LoadEmployeeList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deleted Employee");
            }
        }

        private void FilterMember()
        {
            Employee employee = new Employee();
            List<Employee> filterList = EmployeeRepository.GetEmployeesByDepartmentID(cboDepartmentID.Text);

            try
            {

                if (filterList.Count == 0)
                {
                    MessageBox.Show("No member matched", "No result");
                }
                else if (filterList.Count != 0)
                {
                    source = new BindingSource();
                    source.DataSource = filterList.OrderByDescending(employee =>  employee.Fullname);

                    txtEmployeeID.DataBindings.Clear();
                    txtFullName.DataBindings.Clear();
                    txtPassword.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    txtRoleID.DataBindings.Clear();
                    txtDepartmentID.DataBindings.Clear();
                    txtAddress.DataBindings.Clear();

                    txtEmployeeID.DataBindings.Add("Text", source, "EmployeeId");
                    txtFullName.DataBindings.Add("Text", source, "Fullname");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    txtPassword.DataBindings.Add("Text", source, "Password");
                    txtDepartmentID.DataBindings.Add("Text", source, "DepartmentId");
                    txtAddress.DataBindings.Add("Text", source, "Address");
                    txtRoleID.DataBindings.Add("Text", source, "RoleId");

                    dgvManager.DataSource = null;
                    dgvManager.DataSource = source;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

            private void LoadOneMember()
        {
            Employee employee = new Employee();
            var employees = EmployeeRepository.GetAllEmployees();
            try
            {
                        List<Employee> list = new List<Employee>();
                        list.Add(EmployeeRepository.GetEmployeeById(txtEmployeeID.Text));
                        source = new BindingSource();
                        source.DataSource = list;

                        txtEmployeeID.DataBindings.Clear();
                        txtFullName.DataBindings.Clear();
                        txtPassword.DataBindings.Clear();
                        txtEmail.DataBindings.Clear();
                        txtRoleID.DataBindings.Clear();
                        txtDepartmentID.DataBindings.Clear();
                        txtAddress.DataBindings.Clear();

                        txtEmployeeID.DataBindings.Add("Text", source, "EmployeeId");
                        txtFullName.DataBindings.Add("Text", source, "Fullname");
                        txtEmail.DataBindings.Add("Text", source, "Email");
                        txtPassword.DataBindings.Add("Text", source, "Password");
                        txtDepartmentID.DataBindings.Add("Text", source, "DepartmentId");
                        txtAddress.DataBindings.Add("Text", source, "Address");
                        txtRoleID.DataBindings.Add("Text", source, "RoleId");

                        dgvManager.DataSource = null;
                        dgvManager.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOneMember();
        }

        private void comboBoxDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    EmployeeId = txtEmployeeID.Text,
                    Fullname = txtFullName.Text,
                    Password = txtPassword.Text,
                    BirthDate = DateTime.Parse(dtpBirthday.Text),
                    RoleId = txtRoleID.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    //Phone = txtPhone_TextChanged.Text,
                    DepartmentId = txtDepartmentID.Text,
                };
                EmployeeRepository.AddEmployee(employee);
                list = EmployeeRepository.GetAllEmployees();
                LoadEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new Employee");
            }

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearText();
            UnEditable();
        }
    }
}
