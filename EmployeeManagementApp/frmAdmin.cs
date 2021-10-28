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

namespace EmployeeManagementApp
{
    public partial class frmAdmin : Form
    {
        private IEmployeeRepository employeeRepository;

        public bool IsAdmin { get; set; }

        private static frmAdmin _instance;

        public static frmAdmin Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new frmAdmin();
                }

                return _instance;
            }
        }
        private frmAdmin()
        {
            employeeRepository = new EmployeeRepository();
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            grvMemberList.DataSource = employeeRepository.GetAllManager("R2");
        }
    }
}
