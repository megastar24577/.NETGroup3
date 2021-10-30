
namespace EmployeeManagementApp
{
    partial class frmManager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFilter = new System.Windows.Forms.Label();
            this.comboBoxDepartmentID = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbEmployeeInfor = new System.Windows.Forms.GroupBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.DepartmentID = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbRodeID = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbEmployeeInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(489, 304);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(104, 20);
            this.lbFilter.TabIndex = 36;
            this.lbFilter.Text = "DepartmentID";
            // 
            // comboBoxDepartmentID
            // 
            this.comboBoxDepartmentID.FormattingEnabled = true;
            this.comboBoxDepartmentID.Location = new System.Drawing.Point(489, 327);
            this.comboBoxDepartmentID.Name = "comboBoxDepartmentID";
            this.comboBoxDepartmentID.Size = new System.Drawing.Size(186, 28);
            this.comboBoxDepartmentID.TabIndex = 35;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 26);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(257, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 26);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(914, 273);
            this.dataGridView1.TabIndex = 32;
            // 
            // gbEmployeeInfor
            // 
            this.gbEmployeeInfor.Controls.Add(this.mtbPhone);
            this.gbEmployeeInfor.Controls.Add(this.dtpBirthday);
            this.gbEmployeeInfor.Controls.Add(this.DepartmentID);
            this.gbEmployeeInfor.Controls.Add(this.lbFullName);
            this.gbEmployeeInfor.Controls.Add(this.lbPassword);
            this.gbEmployeeInfor.Controls.Add(this.lbBirthday);
            this.gbEmployeeInfor.Controls.Add(this.lbRodeID);
            this.gbEmployeeInfor.Controls.Add(this.lbPhone);
            this.gbEmployeeInfor.Controls.Add(this.lbEmail);
            this.gbEmployeeInfor.Controls.Add(this.lbAddress);
            this.gbEmployeeInfor.Controls.Add(this.lbEmployeeID);
            this.gbEmployeeInfor.Controls.Add(this.txtRoleID);
            this.gbEmployeeInfor.Controls.Add(this.txtEmployeeID);
            this.gbEmployeeInfor.Controls.Add(this.txtPassword);
            this.gbEmployeeInfor.Controls.Add(this.txtEmail);
            this.gbEmployeeInfor.Controls.Add(this.txtDepartmentID);
            this.gbEmployeeInfor.Controls.Add(this.txtAddress);
            this.gbEmployeeInfor.Controls.Add(this.txtFullName);
            this.gbEmployeeInfor.Location = new System.Drawing.Point(153, 15);
            this.gbEmployeeInfor.Name = "gbEmployeeInfor";
            this.gbEmployeeInfor.Size = new System.Drawing.Size(893, 282);
            this.gbEmployeeInfor.TabIndex = 31;
            this.gbEmployeeInfor.TabStop = false;
            this.gbEmployeeInfor.Text = "Employee\'s Information";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(616, 54);
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(222, 27);
            this.mtbPhone.TabIndex = 24;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(324, 52);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(221, 27);
            this.dtpBirthday.TabIndex = 23;
            // 
            // DepartmentID
            // 
            this.DepartmentID.AutoSize = true;
            this.DepartmentID.Location = new System.Drawing.Point(616, 204);
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Size = new System.Drawing.Size(104, 20);
            this.DepartmentID.TabIndex = 22;
            this.DepartmentID.Text = "DepartmentID";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(53, 113);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(76, 20);
            this.lbFullName.TabIndex = 21;
            this.lbFullName.Text = "Full Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(53, 204);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 20;
            this.lbPassword.Text = "Password";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(324, 29);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(64, 20);
            this.lbBirthday.TabIndex = 19;
            this.lbBirthday.Text = "Birthday";
            // 
            // lbRodeID
            // 
            this.lbRodeID.AutoSize = true;
            this.lbRodeID.Location = new System.Drawing.Point(324, 113);
            this.lbRodeID.Name = "lbRodeID";
            this.lbRodeID.Size = new System.Drawing.Size(54, 20);
            this.lbRodeID.TabIndex = 18;
            this.lbRodeID.Text = "RoleID";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(617, 29);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(50, 20);
            this.lbPhone.TabIndex = 17;
            this.lbPhone.Text = "Phone";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(617, 113);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Email";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(324, 204);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(62, 20);
            this.lbAddress.TabIndex = 15;
            this.lbAddress.Text = "Address";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(53, 29);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(90, 20);
            this.lbEmployeeID.TabIndex = 14;
            this.lbEmployeeID.Text = "EmployeeID";
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(324, 136);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(221, 27);
            this.txtRoleID.TabIndex = 12;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(53, 52);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(221, 27);
            this.txtEmployeeID.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(53, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 27);
            this.txtPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(617, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(616, 227);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(221, 27);
            this.txtDepartmentID.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(324, 227);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(221, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(53, 136);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(221, 27);
            this.txtFullName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(952, 325);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(153, 329);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 26);
            this.btnLoad.TabIndex = 28;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(743, 326);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 27);
            this.txtSearch.TabIndex = 30;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.comboBoxDepartmentID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbEmployeeInfor);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmManager";
            this.Size = new System.Drawing.Size(1300, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbEmployeeInfor.ResumeLayout(false);
            this.gbEmployeeInfor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.ComboBox comboBoxDepartmentID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbEmployeeInfor;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label DepartmentID;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbRodeID;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
