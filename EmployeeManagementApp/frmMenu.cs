﻿using System;
using System.Windows.Forms;
using BusinessLayer.Models;
using DataAccess.Repository;
using MyStoreWinApp;

namespace EmployeeManagementApp
{
    public partial class frmMenu : Form
    {
        //Singleton
        private static frmMenu _instance;
        private readonly IEmployeeRepository employeeRepository;
        private IRoleRepository roleRepository;

        public frmMenu()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            roleRepository = new RoleRepository();
        }

        public Employee CurrentMember { get; set; }


        public bool IsAdmin { get; set; }

        public static frmMenu Instance
        {
            get
            {
                if (_instance is null) _instance = new frmMenu();

                return _instance;
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the is no frm control then create new else bring it to front
            if (!panel.Controls.Contains(frmAdminControl.Instance))
            {
                panel.Controls.Add(frmAdminControl.Instance);
                frmAdminControl.Instance.Dock = DockStyle.Fill;
                frmAdminControl.Instance.BringToFront();
            }
            else
            {
                frmAdminControl.Instance.BringToFront();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Role memberRole = roleRepository.GetRoleIdByRoleName("Member");
            //If logged in user not admin then invisible admin tool strip
            if (IsAdmin == false)
            {
                adminToolStripMenuItem.Visible = false;
                //If logged in user is member then invisible manager and salary tool strip

                if (CurrentMember.RoleId == memberRole.RoleId)
                {
                    managerToolStripMenuItem.Visible = false;
                    salaryToolStripMenuItem.Visible = false;
                }
                else
                {
                    ownSalaryToolStripMenuItem.Visible = false;
                }
            }
            else
            {
                //If admin only show admin tool strip

                managerToolStripMenuItem.Visible = false;
                salaryToolStripMenuItem.Visible = false;
                profileToolStripMenuItem.Visible = false;
                ownSalaryToolStripMenuItem.Visible = false;
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAdmin)
            {
                var employeeInf = employeeRepository.GetEmployeeById(CurrentMember.EmployeeId);
                var frmManagerDetail = new frmManagerDetail
                {
                    isUpdate = true,
                    isMember = true,
                    employeeInfomation = employeeInf
                };
                frmManagerDetail.Show();
            }
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the is no frm control then create new else bring it to front
            if (!panel.Controls.Contains(from.Instance))
            {
                panel.Controls.Add(from.Instance);
                from.Instance.Dock = DockStyle.Fill;
                from.Instance.CurrentUser = CurrentMember;
                from.Instance.BringToFront();
            }
            else
            {
                from.Instance.BringToFront();
            }
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the is no frm control then create new else bring it to front
            if (!panel.Controls.Contains(frmManager.Instance))
            {
                panel.Controls.Add(frmManager.Instance);
                frmManager.Instance.Dock = DockStyle.Fill;
                frmManager.Instance.CurrentUser = CurrentMember;
                frmManager.Instance.BringToFront();
            }
            else
            {
                frmManager.Instance.BringToFront();
            }
        }

        private void ownSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmOwnSalary = new OwnSalary
            {
                CurrentEmployee = CurrentMember
            };
            frmOwnSalary.Show();
        }
    }
}