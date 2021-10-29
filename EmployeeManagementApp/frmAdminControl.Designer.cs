﻿
namespace EmployeeManagementApp
{
    partial class frmAdminControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDepartmentBaseSalary = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.lbDeparmentId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartmentId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadDepartment = new System.Windows.Forms.Button();
            this.btnNewDepartment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchDepartment = new System.Windows.Forms.TextBox();
            this.btnSearchDepartment = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(902, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "DEPARTMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(270, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "MANAGER";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.46259F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.53741F));
            this.tableLayoutPanel3.Controls.Add(this.txtDepartmentBaseSalary, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtDepartmentName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbDeparmentId, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtDepartmentId, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(724, 111);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(558, 221);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // txtDepartmentBaseSalary
            // 
            this.txtDepartmentBaseSalary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDepartmentBaseSalary.Location = new System.Drawing.Point(178, 178);
            this.txtDepartmentBaseSalary.Name = "txtDepartmentBaseSalary";
            this.txtDepartmentBaseSalary.Size = new System.Drawing.Size(341, 27);
            this.txtDepartmentBaseSalary.TabIndex = 5;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDepartmentName.Location = new System.Drawing.Point(178, 108);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(341, 27);
            this.txtDepartmentName.TabIndex = 4;
            // 
            // lbDeparmentId
            // 
            this.lbDeparmentId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDeparmentId.AutoSize = true;
            this.lbDeparmentId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDeparmentId.Location = new System.Drawing.Point(3, 26);
            this.lbDeparmentId.Name = "lbDeparmentId";
            this.lbDeparmentId.Size = new System.Drawing.Size(145, 28);
            this.lbDeparmentId.TabIndex = 0;
            this.lbDeparmentId.Text = "Department ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base Salary:";
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDepartmentId.Location = new System.Drawing.Point(178, 27);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(144, 27);
            this.txtDepartmentId.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnLoadDepartment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNewDepartment, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(724, 346);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 32);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnLoadDepartment
            // 
            this.btnLoadDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadDepartment.Location = new System.Drawing.Point(124, 3);
            this.btnLoadDepartment.Name = "btnLoadDepartment";
            this.btnLoadDepartment.Size = new System.Drawing.Size(94, 26);
            this.btnLoadDepartment.TabIndex = 1;
            this.btnLoadDepartment.Text = "Load";
            this.btnLoadDepartment.UseVisualStyleBackColor = true;
            // 
            // btnNewDepartment
            // 
            this.btnNewDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewDepartment.Location = new System.Drawing.Point(10, 3);
            this.btnNewDepartment.Name = "btnNewDepartment";
            this.btnNewDepartment.Size = new System.Drawing.Size(94, 26);
            this.btnNewDepartment.TabIndex = 0;
            this.btnNewDepartment.Text = "New";
            this.btnNewDepartment.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(724, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(558, 242);
            this.dataGridView1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel2.Controls.Add(this.txtSearchDepartment, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearchDepartment, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1051, 346);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(231, 32);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // txtSearchDepartment
            // 
            this.txtSearchDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchDepartment.Location = new System.Drawing.Point(3, 3);
            this.txtSearchDepartment.Name = "txtSearchDepartment";
            this.txtSearchDepartment.Size = new System.Drawing.Size(136, 27);
            this.txtSearchDepartment.TabIndex = 0;
            // 
            // btnSearchDepartment
            // 
            this.btnSearchDepartment.Location = new System.Drawing.Point(145, 3);
            this.btnSearchDepartment.Name = "btnSearchDepartment";
            this.btnSearchDepartment.Size = new System.Drawing.Size(83, 26);
            this.btnSearchDepartment.TabIndex = 1;
            this.btnSearchDepartment.Text = "Search";
            this.btnSearchDepartment.UseVisualStyleBackColor = true;
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
            this.panel2.Location = new System.Drawing.Point(17, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 518);
            this.panel2.TabIndex = 11;
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(449, 90);
            this.txtSearchByID.Mask = "00000";
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(146, 27);
            this.txtSearchByID.TabIndex = 9;
            this.txtSearchByID.ValidatingType = typeof(int);
            // 
            // lbSearchByID
            // 
            this.lbSearchByID.AutoSize = true;
            this.lbSearchByID.Location = new System.Drawing.Point(449, 69);
            this.lbSearchByID.Name = "lbSearchByID";
            this.lbSearchByID.Size = new System.Drawing.Size(104, 20);
            this.lbSearchByID.TabIndex = 8;
            this.lbSearchByID.Text = "Search with ID";
            // 
            // lbFilterByName
            // 
            this.lbFilterByName.AutoSize = true;
            this.lbFilterByName.Location = new System.Drawing.Point(304, 69);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Location = new System.Drawing.Point(304, 90);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(139, 27);
            this.txtFilterByName.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(601, 90);
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
            this.grvMemberList.Size = new System.Drawing.Size(698, 392);
            this.grvMemberList.TabIndex = 0;
            this.grvMemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvMemberList_CellDoubleClick);
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
            // frmAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Name = "frmAdminControl";
            this.Size = new System.Drawing.Size(1300, 650);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtDepartmentBaseSalary;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label lbDeparmentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartmentId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLoadDepartment;
        private System.Windows.Forms.Button btnNewDepartment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSearchDepartment;
        private System.Windows.Forms.Button btnSearchDepartment;
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
    }
}