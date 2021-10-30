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
    public partial class frmManager : UserControl
    {
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
    }
}
