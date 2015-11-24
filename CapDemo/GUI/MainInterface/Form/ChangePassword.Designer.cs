namespace CapDemo.GUI
{
    partial class ChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.lbl_NewPass = new System.Windows.Forms.Label();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.lbl_CònirmPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(373, 203);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(81, 27);
            this.btn_Change.TabIndex = 49;
            this.btn_Change.Text = "Thay đổi";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(255, 203);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(81, 27);
            this.btn_Cancel.TabIndex = 48;
            this.btn_Cancel.Text = "Hủy Bỏ";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(152, 60);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(302, 26);
            this.txt_Password.TabIndex = 47;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.Color.White;
            this.lbl_Pass.Location = new System.Drawing.Point(73, 63);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(73, 19);
            this.lbl_Pass.TabIndex = 45;
            this.lbl_Pass.Text = "Mật khẩu";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(16, 8);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(336, 33);
            this.lbl1.TabIndex = 43;
            this.lbl1.Text = "Tạo Tài Khoản Người Dùng";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.Location = new System.Drawing.Point(152, 101);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(302, 26);
            this.txt_NewPass.TabIndex = 51;
            this.txt_NewPass.UseSystemPasswordChar = true;
            this.txt_NewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NewPass_KeyDown);
            // 
            // lbl_NewPass
            // 
            this.lbl_NewPass.AutoSize = true;
            this.lbl_NewPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NewPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPass.ForeColor = System.Drawing.Color.White;
            this.lbl_NewPass.Location = new System.Drawing.Point(43, 104);
            this.lbl_NewPass.Name = "lbl_NewPass";
            this.lbl_NewPass.Size = new System.Drawing.Size(103, 19);
            this.lbl_NewPass.TabIndex = 50;
            this.lbl_NewPass.Text = "Mật khẩu Mới";
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPass.Location = new System.Drawing.Point(152, 142);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(302, 26);
            this.txt_ConfirmPass.TabIndex = 53;
            this.txt_ConfirmPass.UseSystemPasswordChar = true;
            this.txt_ConfirmPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ConfirmPass_KeyDown);
            // 
            // lbl_CònirmPass
            // 
            this.lbl_CònirmPass.AutoSize = true;
            this.lbl_CònirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CònirmPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CònirmPass.ForeColor = System.Drawing.Color.White;
            this.lbl_CònirmPass.Location = new System.Drawing.Point(2, 145);
            this.lbl_CònirmPass.Name = "lbl_CònirmPass";
            this.lbl_CònirmPass.Size = new System.Drawing.Size(144, 19);
            this.lbl_CònirmPass.TabIndex = 52;
            this.lbl_CònirmPass.Text = "Xác Nhận Mật khẩu";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(466, 242);
            this.Controls.Add(this.txt_ConfirmPass);
            this.Controls.Add(this.lbl_CònirmPass);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.lbl_NewPass);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.Label lbl_NewPass;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.Label lbl_CònirmPass;
    }
}