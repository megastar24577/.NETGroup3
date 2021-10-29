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

namespace EmployeeManagementApp
{
    public partial class frmMenu : Form
    {
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
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
