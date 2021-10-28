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
    public partial class frmAdminControl : UserControl
    {
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
        }
    }
}
