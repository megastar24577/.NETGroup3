﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Models;
using DataAccess.Repository;
using MyStoreWinApp;

namespace EmployeeManagementApp
{
    public partial class frmMenu : Form
    {
        private IEmployeeRepository employeeRepository;
        public Employee CurrentMember { get; set; }

        public bool IsAdmin { get; set; }


        //Singleton
        private static frmMenu _instance;

        public static frmMenu Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new frmMenu();
                }

                return _instance;
            }
        }
        public frmMenu()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
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
            if (IsAdmin == false)
            {
                adminToolStripMenuItem.Visible = false;
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAdmin)
            {
                Employee employeeInf = employeeRepository.GetEmployeeById(CurrentMember.EmployeeId);
                frmManagerDetail frmManagerDetail = new frmManagerDetail()
                {
                    isUpdate = true,
                    isMember = true,
                    employeeInfomation = employeeInf,
                };
                frmManagerDetail.Show();
            }
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the is no frm control then create new else bring it to front
            if (!panel.Controls.Contains(frmSalary.Instance))
            {
                panel.Controls.Add(frmSalary.Instance);
                frmSalary.Instance.Dock = DockStyle.Fill;
                frmSalary.Instance.BringToFront();
            }
            else
            {
                frmSalary.Instance.BringToFront();
            }
        }
    }
}
