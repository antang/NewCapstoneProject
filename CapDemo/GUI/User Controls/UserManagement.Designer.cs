﻿namespace CapDemo.GUI.User_Controls
{
    partial class UserManagement
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgv_UserManagement = new System.Windows.Forms.DataGridView();
            this.lbl_Create = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(27, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(450, 33);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Danh sách tài khoản người dùng";
            // 
            // dgv_UserManagement
            // 
            this.dgv_UserManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserManagement.Location = new System.Drawing.Point(33, 135);
            this.dgv_UserManagement.Name = "dgv_UserManagement";
            this.dgv_UserManagement.Size = new System.Drawing.Size(606, 328);
            this.dgv_UserManagement.TabIndex = 11;
            // 
            // lbl_Create
            // 
            this.lbl_Create.AutoSize = true;
            this.lbl_Create.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Create.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Create.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Create.Location = new System.Drawing.Point(29, 99);
            this.lbl_Create.Name = "lbl_Create";
            this.lbl_Create.Size = new System.Drawing.Size(180, 23);
            this.lbl_Create.TabIndex = 12;
            this.lbl_Create.Text = "+ Tạo tài khoản mới";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Create);
            this.Controls.Add(this.dgv_UserManagement);
            this.Controls.Add(this.lbl1);
            this.Name = "UserManagement";
            this.Size = new System.Drawing.Size(710, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgv_UserManagement;
        private System.Windows.Forms.Label lbl_Create;
    }
}
