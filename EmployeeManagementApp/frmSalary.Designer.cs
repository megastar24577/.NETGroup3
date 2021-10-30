
namespace EmployeeManagementApp
{
    partial class frmSalary
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchManagerWithId = new System.Windows.Forms.TextBox();
            this.lbSearchByID = new System.Windows.Forms.Label();
            this.lbFilterByName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grvMemberList = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearchManagerWithId);
            this.panel2.Controls.Add(this.lbSearchByID);
            this.panel2.Controls.Add(this.lbFilterByName);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtFilterByName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.grvMemberList);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(165, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 518);
            this.panel2.TabIndex = 12;
            // 
            // txtSearchManagerWithId
            // 
            this.txtSearchManagerWithId.Location = new System.Drawing.Point(704, 89);
            this.txtSearchManagerWithId.Name = "txtSearchManagerWithId";
            this.txtSearchManagerWithId.Size = new System.Drawing.Size(139, 27);
            this.txtSearchManagerWithId.TabIndex = 9;
            // 
            // lbSearchByID
            // 
            this.lbSearchByID.AutoSize = true;
            this.lbSearchByID.Location = new System.Drawing.Point(704, 67);
            this.lbSearchByID.Name = "lbSearchByID";
            this.lbSearchByID.Size = new System.Drawing.Size(104, 20);
            this.lbSearchByID.TabIndex = 8;
            this.lbSearchByID.Text = "Search with ID";
            // 
            // lbFilterByName
            // 
            this.lbFilterByName.AutoSize = true;
            this.lbFilterByName.Location = new System.Drawing.Point(559, 67);
            this.lbFilterByName.Name = "lbFilterByName";
            this.lbFilterByName.Size = new System.Drawing.Size(106, 20);
            this.lbFilterByName.TabIndex = 7;
            this.lbFilterByName.Text = "Filter by Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Location = new System.Drawing.Point(559, 88);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(139, 27);
            this.txtFilterByName.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(856, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(0, 53);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // grvMemberList
            // 
            this.grvMemberList.AllowUserToAddRows = false;
            this.grvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMemberList.Location = new System.Drawing.Point(3, 123);
            this.grvMemberList.Name = "grvMemberList";
            this.grvMemberList.ReadOnly = true;
            this.grvMemberList.RowHeadersWidth = 51;
            this.grvMemberList.RowTemplate.Height = 29;
            this.grvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvMemberList.Size = new System.Drawing.Size(947, 392);
            this.grvMemberList.TabIndex = 0;
            this.grvMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvMemberList_CellContentClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(0, 88);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(588, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "SALARY";
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Name = "frmSalary";
            this.Size = new System.Drawing.Size(1300, 650);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchManagerWithId;
        private System.Windows.Forms.Label lbSearchByID;
        private System.Windows.Forms.Label lbFilterByName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView grvMemberList;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
    }
}
