﻿namespace QuanLyCuaHangGear
{
    partial class Form_Admin
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
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pic_StoreLogo = new System.Windows.Forms.PictureBox();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Slide = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.panel_Head = new System.Windows.Forms.Panel();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_UserType = new System.Windows.Forms.Label();
            this.pic_UpperLogo = new System.Windows.Forms.PictureBox();
            this.label_UpperLogo = new System.Windows.Forms.Label();
            this.import_Control1 = new QuanLyCuaHangGear.View.Import_Control();
            this.bill_Control1 = new QuanLyCuaHangGear.Bill_Control();
            this.report_Control1 = new QuanLyCuaHangGear.Report_Control();
            this.product_Control1 = new QuanLyCuaHangGear.Product_Control();
            this.staff_Control1 = new QuanLyCuaHangGear.Staff_Control();
            this.welcome_Control1 = new QuanLyCuaHangGear.Welcome_Control();
            this.account_Control1 = new QuanLyCuaHangGear.View.Account_Control();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StoreLogo)).BeginInit();
            this.panel_Left.SuspendLayout();
            this.panel_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UpperLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.panel_Logo.Controls.Add(this.label_StoreName);
            this.panel_Logo.Controls.Add(this.pic_StoreLogo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(250, 100);
            this.panel_Logo.TabIndex = 1;
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_StoreName.Location = new System.Drawing.Point(98, 34);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(142, 24);
            this.label_StoreName.TabIndex = 2;
            this.label_StoreName.Text = "QuocAn Store";
            // 
            // pic_StoreLogo
            // 
            this.pic_StoreLogo.Image = global::QuanLyCuaHangGear.Properties.Resources.Store_Logo;
            this.pic_StoreLogo.Location = new System.Drawing.Point(3, 1);
            this.pic_StoreLogo.Name = "pic_StoreLogo";
            this.pic_StoreLogo.Size = new System.Drawing.Size(89, 97);
            this.pic_StoreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_StoreLogo.TabIndex = 2;
            this.pic_StoreLogo.TabStop = false;
            this.pic_StoreLogo.Click += new System.EventHandler(this.pic_StoreLogo_Click);
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.panel_Left.Controls.Add(this.panel_Slide);
            this.panel_Left.Controls.Add(this.panel_Logo);
            this.panel_Left.Controls.Add(this.btn_Exit);
            this.panel_Left.Controls.Add(this.btn_Import);
            this.panel_Left.Controls.Add(this.btn_Bill);
            this.panel_Left.Controls.Add(this.btn_Account);
            this.panel_Left.Controls.Add(this.btn_Report);
            this.panel_Left.Controls.Add(this.btn_Product);
            this.panel_Left.Controls.Add(this.btn_Staff);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(250, 788);
            this.panel_Left.TabIndex = 0;
            // 
            // panel_Slide
            // 
            this.panel_Slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel_Slide.Location = new System.Drawing.Point(3, 100);
            this.panel_Slide.Name = "panel_Slide";
            this.panel_Slide.Size = new System.Drawing.Size(10, 80);
            this.panel_Slide.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = global::QuanLyCuaHangGear.Properties.Resources.Exit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(0, 687);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btn_Exit.Size = new System.Drawing.Size(250, 80);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "   Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.FlatAppearance.BorderSize = 0;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.ForeColor = System.Drawing.Color.White;
            this.btn_Import.Image = global::QuanLyCuaHangGear.Properties.Resources.import;
            this.btn_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Import.Location = new System.Drawing.Point(0, 424);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btn_Import.Size = new System.Drawing.Size(250, 80);
            this.btn_Import.TabIndex = 0;
            this.btn_Import.Text = "   Nhập hàng         ";
            this.btn_Import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Bill
            // 
            this.btn_Bill.FlatAppearance.BorderSize = 0;
            this.btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.ForeColor = System.Drawing.Color.White;
            this.btn_Bill.Image = global::QuanLyCuaHangGear.Properties.Resources.bill;
            this.btn_Bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bill.Location = new System.Drawing.Point(0, 343);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btn_Bill.Size = new System.Drawing.Size(250, 80);
            this.btn_Bill.TabIndex = 0;
            this.btn_Bill.Text = "   Lập hóa đơn     ";
            this.btn_Bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bill.UseVisualStyleBackColor = true;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Image = global::QuanLyCuaHangGear.Properties.Resources.user;
            this.btn_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.Location = new System.Drawing.Point(0, 505);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.btn_Account.Size = new System.Drawing.Size(250, 80);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "   Tài khoản         ";
            this.btn_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Image = global::QuanLyCuaHangGear.Properties.Resources.money;
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Report.Location = new System.Drawing.Point(0, 262);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Padding = new System.Windows.Forms.Padding(15, 0, 25, 5);
            this.btn_Report.Size = new System.Drawing.Size(250, 80);
            this.btn_Report.TabIndex = 0;
            this.btn_Report.Text = "   Doanh thu          ";
            this.btn_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.FlatAppearance.BorderSize = 0;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.Image = global::QuanLyCuaHangGear.Properties.Resources.Product;
            this.btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.Location = new System.Drawing.Point(0, 181);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btn_Product.Size = new System.Drawing.Size(250, 80);
            this.btn_Product.TabIndex = 0;
            this.btn_Product.Text = "   Hàng hóa          ";
            this.btn_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Product.UseVisualStyleBackColor = true;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.FlatAppearance.BorderSize = 0;
            this.btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.White;
            this.btn_Staff.Image = global::QuanLyCuaHangGear.Properties.Resources.Staff;
            this.btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Staff.Location = new System.Drawing.Point(0, 100);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btn_Staff.Size = new System.Drawing.Size(250, 80);
            this.btn_Staff.TabIndex = 0;
            this.btn_Staff.Text = "   Nhân viên          ";
            this.btn_Staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Staff.UseVisualStyleBackColor = true;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // panel_Head
            // 
            this.panel_Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.panel_Head.Controls.Add(this.label_Name);
            this.panel_Head.Controls.Add(this.label_UserType);
            this.panel_Head.Controls.Add(this.pic_UpperLogo);
            this.panel_Head.Controls.Add(this.label_UpperLogo);
            this.panel_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Head.Location = new System.Drawing.Point(250, 0);
            this.panel_Head.Name = "panel_Head";
            this.panel_Head.Size = new System.Drawing.Size(1136, 100);
            this.panel_Head.TabIndex = 1;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.label_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_Name.Location = new System.Drawing.Point(1006, 39);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(142, 19);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Ngô Lưu Quốc Đạt";
            // 
            // label_UserType
            // 
            this.label_UserType.AutoSize = true;
            this.label_UserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.label_UserType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_UserType.Location = new System.Drawing.Point(919, 39);
            this.label_UserType.Name = "label_UserType";
            this.label_UserType.Size = new System.Drawing.Size(73, 19);
            this.label_UserType.TabIndex = 5;
            this.label_UserType.Text = "Quản lý:";
            // 
            // pic_UpperLogo
            // 
            this.pic_UpperLogo.Location = new System.Drawing.Point(42, 36);
            this.pic_UpperLogo.Name = "pic_UpperLogo";
            this.pic_UpperLogo.Size = new System.Drawing.Size(50, 50);
            this.pic_UpperLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_UpperLogo.TabIndex = 3;
            this.pic_UpperLogo.TabStop = false;
            // 
            // label_UpperLogo
            // 
            this.label_UpperLogo.AutoSize = true;
            this.label_UpperLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.label_UpperLogo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpperLogo.ForeColor = System.Drawing.Color.White;
            this.label_UpperLogo.Location = new System.Drawing.Point(109, 48);
            this.label_UpperLogo.Name = "label_UpperLogo";
            this.label_UpperLogo.Size = new System.Drawing.Size(105, 22);
            this.label_UpperLogo.TabIndex = 2;
            this.label_UpperLogo.Text = "                   ";
            // 
            // import_Control1
            // 
            this.import_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.import_Control1.Location = new System.Drawing.Point(250, 100);
            this.import_Control1.Name = "import_Control1";
            this.import_Control1.Size = new System.Drawing.Size(1250, 700);
            this.import_Control1.TabIndex = 7;
            // 
            // bill_Control1
            // 
            this.bill_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.bill_Control1.Location = new System.Drawing.Point(250, 100);
            this.bill_Control1.Name = "bill_Control1";
            this.bill_Control1.Size = new System.Drawing.Size(1250, 700);
            this.bill_Control1.TabIndex = 6;
            // 
            // report_Control1
            // 
            this.report_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.report_Control1.Location = new System.Drawing.Point(250, 100);
            this.report_Control1.Name = "report_Control1";
            this.report_Control1.Size = new System.Drawing.Size(1250, 700);
            this.report_Control1.TabIndex = 5;
            // 
            // product_Control1
            // 
            this.product_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.product_Control1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.product_Control1.Location = new System.Drawing.Point(250, 100);
            this.product_Control1.Name = "product_Control1";
            this.product_Control1.Size = new System.Drawing.Size(1250, 700);
            this.product_Control1.TabIndex = 4;
            // 
            // staff_Control1
            // 
            this.staff_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.staff_Control1.Location = new System.Drawing.Point(250, 100);
            this.staff_Control1.Name = "staff_Control1";
            this.staff_Control1.Size = new System.Drawing.Size(1250, 700);
            this.staff_Control1.TabIndex = 3;
            // 
            // welcome_Control1
            // 
            this.welcome_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.welcome_Control1.Location = new System.Drawing.Point(250, 100);
            this.welcome_Control1.Name = "welcome_Control1";
            this.welcome_Control1.Size = new System.Drawing.Size(1250, 700);
            this.welcome_Control1.TabIndex = 2;
            // 
            // account_Control1
            // 
            this.account_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.account_Control1.Location = new System.Drawing.Point(250, 100);
            this.account_Control1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.account_Control1.Name = "account_Control1";
            this.account_Control1.Size = new System.Drawing.Size(1250, 700);
            this.account_Control1.TabIndex = 8;
            // 
            // Form_Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.account_Control1);
            this.Controls.Add(this.import_Control1);
            this.Controls.Add(this.bill_Control1);
            this.Controls.Add(this.report_Control1);
            this.Controls.Add(this.product_Control1);
            this.Controls.Add(this.staff_Control1);
            this.Controls.Add(this.welcome_Control1);
            this.Controls.Add(this.panel_Head);
            this.Controls.Add(this.panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Admin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Admin_FormClosed);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StoreLogo)).EndInit();
            this.panel_Left.ResumeLayout(false);
            this.panel_Head.ResumeLayout(false);
            this.panel_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UpperLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Head;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Panel panel_Slide;
        private System.Windows.Forms.Label label_UpperLogo;
        private System.Windows.Forms.PictureBox pic_UpperLogo;
        private System.Windows.Forms.PictureBox pic_StoreLogo;
        private System.Windows.Forms.Label label_StoreName;
        private Welcome_Control welcome_Control1;
        private Staff_Control staff_Control1;
        private Product_Control product_Control1;
        private System.Windows.Forms.Label label_UserType;
        private System.Windows.Forms.Label label_Name;
        private Report_Control report_Control1;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Bill;
        private Bill_Control bill_Control1;
        private View.Import_Control import_Control1;
        private View.Account_Control account_Control1;
    }
}