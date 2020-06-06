namespace QuanLyCuaHangGear.View
{
    partial class Account_Control
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
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_changePass = new System.Windows.Forms.Button();
            this.pic_User = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(819, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 1);
            this.panel2.TabIndex = 160;
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_DisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DisplayName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DisplayName.ForeColor = System.Drawing.Color.White;
            this.txt_DisplayName.Location = new System.Drawing.Point(819, 451);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.ReadOnly = true;
            this.txt_DisplayName.Size = new System.Drawing.Size(310, 27);
            this.txt_DisplayName.TabIndex = 151;
            this.txt_DisplayName.Text = "Ngô Lưu Quốc Đạt";
            this.txt_DisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.Color.White;
            this.txt_UserName.Location = new System.Drawing.Point(819, 399);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.Size = new System.Drawing.Size(310, 27);
            this.txt_UserName.TabIndex = 152;
            this.txt_UserName.Text = "nlqdat";
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label16.Location = new System.Drawing.Point(504, 449);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 29);
            this.label16.TabIndex = 154;
            this.label16.Text = "Tên hiển thị:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label15.Location = new System.Drawing.Point(504, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 29);
            this.label15.TabIndex = 153;
            this.label15.Text = "Tên tài khoản:";
            // 
            // btn_changePass
            // 
            this.btn_changePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_changePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_changePass.FlatAppearance.BorderSize = 0;
            this.btn_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePass.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePass.ForeColor = System.Drawing.Color.White;
            this.btn_changePass.Image = global::QuanLyCuaHangGear.Properties.Resources.reset;
            this.btn_changePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changePass.Location = new System.Drawing.Point(859, 537);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_changePass.Size = new System.Drawing.Size(239, 66);
            this.btn_changePass.TabIndex = 161;
            this.btn_changePass.Text = "     Đổi mật khẩu";
            this.btn_changePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changePass.UseVisualStyleBackColor = false;
            this.btn_changePass.Click += new System.EventHandler(this.btn_changePass_Click);
            // 
            // pic_User
            // 
            this.pic_User.Image = global::QuanLyCuaHangGear.Properties.Resources.Staff_account;
            this.pic_User.Location = new System.Drawing.Point(597, 48);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(451, 309);
            this.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_User.TabIndex = 147;
            this.pic_User.TabStop = false;
            // 
            // Account_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btn_changePass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_DisplayName);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pic_User);
            this.Name = "Account_Control";
            this.Size = new System.Drawing.Size(1250, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Button btn_changePass;
    }
}
