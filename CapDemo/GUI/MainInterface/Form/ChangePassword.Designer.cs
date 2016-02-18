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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.btn_Change = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.lbl_NewPass = new System.Windows.Forms.Label();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.lbl_CònirmPass = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.White;
            this.btn_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Change.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.ForeColor = System.Drawing.Color.Blue;
            this.btn_Change.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Change.ImageKey = "save-512.png";
            this.btn_Change.ImageList = this.imageList1;
            this.btn_Change.Location = new System.Drawing.Point(248, 189);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(100, 30);
            this.btn_Change.TabIndex = 49;
            this.btn_Change.Text = "Thay đổi";
            this.btn_Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            this.imageList1.Images.SetKeyName(1, "red-edit-icon-glossy-md.png");
            this.imageList1.Images.SetKeyName(2, "add.png");
            this.imageList1.Images.SetKeyName(3, "save-512.png");
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Blue;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.imageList1;
            this.btn_Cancel.Location = new System.Drawing.Point(354, 189);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 30);
            this.btn_Cancel.TabIndex = 48;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(152, 52);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(302, 27);
            this.txt_Password.TabIndex = 47;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.Color.White;
            this.lbl_Pass.Location = new System.Drawing.Point(73, 63);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(74, 16);
            this.lbl_Pass.TabIndex = 45;
            this.lbl_Pass.Text = "Mật khẩu";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.Location = new System.Drawing.Point(152, 93);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(302, 27);
            this.txt_NewPass.TabIndex = 51;
            this.txt_NewPass.UseSystemPasswordChar = true;
            this.txt_NewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NewPass_KeyDown);
            // 
            // lbl_NewPass
            // 
            this.lbl_NewPass.AutoSize = true;
            this.lbl_NewPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NewPass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPass.ForeColor = System.Drawing.Color.White;
            this.lbl_NewPass.Location = new System.Drawing.Point(43, 104);
            this.lbl_NewPass.Name = "lbl_NewPass";
            this.lbl_NewPass.Size = new System.Drawing.Size(103, 16);
            this.lbl_NewPass.TabIndex = 50;
            this.lbl_NewPass.Text = "Mật khẩu Mới";
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPass.Location = new System.Drawing.Point(152, 134);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(302, 27);
            this.txt_ConfirmPass.TabIndex = 53;
            this.txt_ConfirmPass.UseSystemPasswordChar = true;
            this.txt_ConfirmPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ConfirmPass_KeyDown);
            // 
            // lbl_CònirmPass
            // 
            this.lbl_CònirmPass.AutoSize = true;
            this.lbl_CònirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CònirmPass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CònirmPass.ForeColor = System.Drawing.Color.White;
            this.lbl_CònirmPass.Location = new System.Drawing.Point(2, 145);
            this.lbl_CònirmPass.Name = "lbl_CònirmPass";
            this.lbl_CònirmPass.Size = new System.Drawing.Size(146, 16);
            this.lbl_CònirmPass.TabIndex = 52;
            this.lbl_CònirmPass.Text = "Xác Nhận Mật khẩu";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl1.ImageIndex = 0;
            this.lbl1.Location = new System.Drawing.Point(41, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(377, 25);
            this.lbl1.TabIndex = 54;
            this.lbl1.Text = "Thay Đổi Mật Khẩu Người Dùng";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(466, 231);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt_ConfirmPass);
            this.Controls.Add(this.lbl_CònirmPass);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.lbl_NewPass);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Pass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.Label lbl_NewPass;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.Label lbl_CònirmPass;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl1;
    }
}