﻿namespace CapDemo.GUI.User_Controls
{
    partial class Add_Phase
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
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lblVong = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ccb_Catalogue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Number.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.ForeColor = System.Drawing.Color.White;
            this.lbl_Number.Location = new System.Drawing.Point(60, 15);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(31, 21);
            this.lbl_Number.TabIndex = 41;
            this.lbl_Number.Text = "Số";
            // 
            // lblVong
            // 
            this.lblVong.AutoSize = true;
            this.lblVong.BackColor = System.Drawing.Color.Transparent;
            this.lblVong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVong.ForeColor = System.Drawing.Color.White;
            this.lblVong.Location = new System.Drawing.Point(5, 15);
            this.lblVong.Name = "lblVong";
            this.lblVong.Size = new System.Drawing.Size(50, 19);
            this.lblVong.TabIndex = 40;
            this.lblVong.Text = "Vòng";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(287, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(20, 20);
            this.btn_Delete.TabIndex = 39;
            this.btn_Delete.Text = "X";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(218, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Điểm";
            // 
            // txt_Score
            // 
            this.txt_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Score.Location = new System.Drawing.Point(162, 118);
            this.txt_Score.Multiline = true;
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(50, 30);
            this.txt_Score.TabIndex = 37;
            this.txt_Score.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Score_KeyDown);
            this.txt_Score.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Score_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Điểm câu hỏi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Giây";
            // 
            // txt_Time
            // 
            this.txt_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Time.Location = new System.Drawing.Point(162, 80);
            this.txt_Time.Multiline = true;
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(50, 30);
            this.txt_Time.TabIndex = 34;
            this.txt_Time.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Time_KeyDown);
            this.txt_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Time_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Thời gian câu hỏi";
            // 
            // ccb_Catalogue
            // 
            this.ccb_Catalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_Catalogue.FormattingEnabled = true;
            this.ccb_Catalogue.Location = new System.Drawing.Point(78, 40);
            this.ccb_Catalogue.Name = "ccb_Catalogue";
            this.ccb_Catalogue.Size = new System.Drawing.Size(218, 28);
            this.ccb_Catalogue.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Chủ đề";
            // 
            // Add_Phase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lblVong);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ccb_Catalogue);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Add_Phase";
            this.Size = new System.Drawing.Size(310, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ccb_Catalogue;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_Number;
        public System.Windows.Forms.TextBox txt_Score;
        public System.Windows.Forms.TextBox txt_Time;
        public System.Windows.Forms.Button btn_Delete;
    }
}
