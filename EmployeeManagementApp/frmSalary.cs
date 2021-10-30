using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementApp
{
    public partial class frmSalary : UserControl
    {

        //Singleton
        private static frmSalary _instance;

        public static frmSalary Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new frmSalary();
                }

                return _instance;
            }
        }
        public frmSalary()
        {
            InitializeComponent();
        }

        private void grvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
