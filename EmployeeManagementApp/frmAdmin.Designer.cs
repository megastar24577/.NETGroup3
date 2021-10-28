
namespace EmployeeManagementApp
{
    partial class frmAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchByID = new System.Windows.Forms.MaskedTextBox();
            this.lbSearchByID = new System.Windows.Forms.Label();
            this.lbFilterByName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grvMemberList = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMemID = new System.Windows.Forms.MaskedTextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbMemName = new System.Windows.Forms.Label();
            this.lbMemID = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMemberList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearchByID);
            this.panel2.Controls.Add(this.lbSearchByID);
            this.panel2.Controls.Add(this.lbFilterByName);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtFilterByName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.grvMemberList);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(12, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 333);
            this.panel2.TabIndex = 3;
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(450, 88);
            this.txtSearchByID.Mask = "00000";
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(146, 27);
            this.txtSearchByID.TabIndex = 9;
            this.txtSearchByID.ValidatingType = typeof(int);
            // 
            // lbSearchByID
            // 
            this.lbSearchByID.AutoSize = true;
            this.lbSearchByID.Location = new System.Drawing.Point(450, 67);
            this.lbSearchByID.Name = "lbSearchByID";
            this.lbSearchByID.Size = new System.Drawing.Size(104, 20);
            this.lbSearchByID.TabIndex = 8;
            this.lbSearchByID.Text = "Search with ID";
            // 
            // lbFilterByName
            // 
            this.lbFilterByName.AutoSize = true;
            this.lbFilterByName.Location = new System.Drawing.Point(305, 67);
            this.lbFilterByName.Name = "lbFilterByName";
            this.lbFilterByName.Size = new System.Drawing.Size(106, 20);
            this.lbFilterByName.TabIndex = 7;
            this.lbFilterByName.Text = "Filter by Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(107, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Location = new System.Drawing.Point(305, 88);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(139, 27);
            this.txtFilterByName.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(602, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(7, 53);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grvMemberList
            // 
            this.grvMemberList.AllowUserToAddRows = false;
            this.grvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMemberList.Location = new System.Drawing.Point(-1, 123);
            this.grvMemberList.Name = "grvMemberList";
            this.grvMemberList.ReadOnly = true;
            this.grvMemberList.RowHeadersWidth = 51;
            this.grvMemberList.RowTemplate.Height = 29;
            this.grvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvMemberList.Size = new System.Drawing.Size(698, 207);
            this.grvMemberList.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(7, 88);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMemID);
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.lbCity);
            this.panel1.Controls.Add(this.lbMemName);
            this.panel1.Controls.Add(this.lbMemID);
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtMemName);
            this.panel1.Location = new System.Drawing.Point(15, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 165);
            this.panel1.TabIndex = 4;
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(113, 3);
            this.txtMemID.Mask = "00000";
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(227, 27);
            this.txtMemID.TabIndex = 13;
            this.txtMemID.ValidatingType = typeof(int);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(381, 47);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 12;
            this.lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(371, 6);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 11;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(61, 131);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "Email";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(73, 89);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 9;
            this.lbCity.Text = "City";
            // 
            // lbMemName
            // 
            this.lbMemName.AutoSize = true;
            this.lbMemName.Location = new System.Drawing.Point(3, 49);
            this.lbMemName.Name = "lbMemName";
            this.lbMemName.Size = new System.Drawing.Size(109, 20);
            this.lbMemName.TabIndex = 8;
            this.lbMemName.Text = "Member Name";
            // 
            // lbMemID
            // 
            this.lbMemID.AutoSize = true;
            this.lbMemID.Location = new System.Drawing.Point(23, 10);
            this.lbMemID.Name = "lbMemID";
            this.lbMemID.Size = new System.Drawing.Size(84, 20);
            this.lbMemID.TabIndex = 7;
            this.lbMemID.Text = "Member ID";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(447, 44);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(227, 27);
            this.txtCountry.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(447, 7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(113, 89);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(227, 27);
            this.txtCity.TabIndex = 2;
            // 
            // txtMemName
            // 
            this.txtMemName.Location = new System.Drawing.Point(113, 46);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(227, 27);
            this.txtMemName.TabIndex = 1;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmAdmin";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMemberList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtSearchByID;
        private System.Windows.Forms.Label lbSearchByID;
        private System.Windows.Forms.Label lbFilterByName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView grvMemberList;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtMemID;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbMemName;
        private System.Windows.Forms.Label lbMemID;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtMemName;
    }
}

