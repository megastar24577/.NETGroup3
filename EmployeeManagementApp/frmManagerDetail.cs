using BusinessObject;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmManagerDetail : Form
    {
        public frmManagerDetail()
        {
            InitializeComponent();
        }

        //----------------------------------------------------
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberInfo { get; set; }

        //----------------------------------------------------

        private void FrmMemberDetail_Load(object sender, EventArgs e)
        {
            txtManagerMemberID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtManagerMemberID.Text = MemberInfo.MemberId.ToString();
                txtManagerCountry.Text = MemberInfo.CompanyName;
                txtManagerName.Text = MemberInfo.Email;
                txtManagerPassword.Text = MemberInfo.Password;
                txtCity.Text = MemberInfo.City;
                txtManagerEmail.Text = MemberInfo.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Member = new MemberObject
                {
                    MemberId = int.Parse(txtManagerMemberID.Text),
                    CompanyName = txtManagerCountry.Text,
                    Password = txtManagerPassword.Text,
                    Email = txtManagerName.Text,
                    City = txtCity.Text,
                    Country = txtManagerEmail.Text
                };
                Console.WriteLine("Form member detail: " + Member);
                if(InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(Member);
                }
                else
                {
                    MemberRepository.Update(Member);
                }
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add Member" : "Update a Member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
