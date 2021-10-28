
namespace EmployeeManagementApp
{
    partial class MainPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Welcome = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminPage = new System.Windows.Forms.Button();
            this.btnManagerPage = new System.Windows.Forms.Button();
            this.btnEmployeePage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.95893F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.04108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Controls.Add(this.Welcome, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 103);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Welcome
            // 
            this.Welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Welcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Welcome.Location = new System.Drawing.Point(252, 21);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(228, 60);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "WELCOME";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnEmployeePage, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnManagerPage, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminPage, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(132, 151);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 226);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnAdminPage
            // 
            this.btnAdminPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminPage.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminPage.Location = new System.Drawing.Point(121, 11);
            this.btnAdminPage.Name = "btnAdminPage";
            this.btnAdminPage.Size = new System.Drawing.Size(232, 53);
            this.btnAdminPage.TabIndex = 4;
            this.btnAdminPage.Text = "Admin Page";
            this.btnAdminPage.UseVisualStyleBackColor = true;
            // 
            // btnManagerPage
            // 
            this.btnManagerPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManagerPage.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManagerPage.Location = new System.Drawing.Point(121, 85);
            this.btnManagerPage.Name = "btnManagerPage";
            this.btnManagerPage.Size = new System.Drawing.Size(232, 54);
            this.btnManagerPage.TabIndex = 5;
            this.btnManagerPage.Text = "Manager Page";
            this.btnManagerPage.UseVisualStyleBackColor = true;
            // 
            // btnEmployeePage
            // 
            this.btnEmployeePage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeePage.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeePage.Location = new System.Drawing.Point(121, 163);
            this.btnEmployeePage.Name = "btnEmployeePage";
            this.btnEmployeePage.Size = new System.Drawing.Size(232, 49);
            this.btnEmployeePage.TabIndex = 6;
            this.btnEmployeePage.Text = "Employee Page";
            this.btnEmployeePage.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 442);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEmployeePage;
        private System.Windows.Forms.Button btnManagerPage;
        private System.Windows.Forms.Button btnAdminPage;
    }
}