using DataAccess.Repository;
using System;
using System.Windows.Forms;
using BusinessLayer.Models;

namespace MyStoreWinApp
{
    public partial class frmManagerDetail : Form
    { 
        public bool isUpdate { get; set; }

        public Employee employeeInfomation { get; set; }

        public frmManagerDetail()
        {
            InitializeComponent();
        }
        

        private void FrmMemberDetail_Load(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
