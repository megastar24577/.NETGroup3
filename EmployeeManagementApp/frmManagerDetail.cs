﻿using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLayer.Models;

namespace MyStoreWinApp
{
    public partial class frmManagerDetail : Form
    {
        private RoleRepository roleRepository;

        private EmployeeRepository employeeRepository;

        private DeparmentRepository deparmentRepository;
        public bool isUpdate { get; set; }

        public Employee employeeInfomation { get; set; }

        public frmManagerDetail()
        {
            InitializeComponent();
            roleRepository = new RoleRepository();
            employeeRepository = new EmployeeRepository();
            deparmentRepository = new DeparmentRepository();
        }
        

        private void FrmMemberDetail_Load(object sender, EventArgs e)
        {

            //Add all role to combo box
            List<Role> listOfRoles = roleRepository.GetRoles();
            foreach (var role in listOfRoles)
            {
                roleCombobox.Items.Add(role.RoleName);
            }

            List<Department> listOfDepartments = deparmentRepository.GetAllDepartments();
            foreach (var depart in listOfDepartments)
            {
                deparmentCombobox.Items.Add(depart.DepartmentId);
            }

            txtEmployeeId.Enabled = !isUpdate;
            if (isUpdate)
            {
                string currentUserRole = roleRepository.GetRoleNameByRoleId(employeeInfomation.RoleId);

                txtEmployeeId.Text = employeeInfomation.EmployeeId;
                txtEmployeeName.Text = employeeInfomation.Fullname;
                txtEmail.Text = employeeInfomation.Email;
                txtPassword.Text = employeeInfomation.Password;
                if (employeeInfomation.BirthDate.HasValue)
                {
                    dtpBirthDate.Value = employeeInfomation.BirthDate.Value;

                }
                txtPhone.Text = employeeInfomation.Phone;
                txtAddress.Text = employeeInfomation.Address;
                roleCombobox.SelectedText = currentUserRole;
                if (employeeInfomation.DepartmentId != null)
                {
                    deparmentCombobox.SelectedItem = employeeInfomation.DepartmentId;

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Role selectedRole = roleRepository.GetRoleIdByRoleName(roleCombobox.Text);
            Employee newEmployee = new Employee()
            {
                //Convert Role name to roleId

                EmployeeId = txtEmployeeId.Text,
                Fullname = txtEmployeeName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                BirthDate = dtpBirthDate.Value.Date,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                RoleId = selectedRole.RoleId,
                DepartmentId = deparmentCombobox.Text,
            };

            if (isUpdate)
            {
                employeeRepository.UpdateEmployee(newEmployee);
            }
            else
            {
                employeeRepository.AddEmployee(newEmployee);
            }

            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
