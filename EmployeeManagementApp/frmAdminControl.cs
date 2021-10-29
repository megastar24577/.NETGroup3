using System;
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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyStoreWinApp;

namespace EmployeeManagementApp
{
    public partial class frmAdminControl : UserControl
    {
        private IEmployeeRepository employeeRepository;
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


    }
}
