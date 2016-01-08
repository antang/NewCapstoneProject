namespace CapDemo.GUI.User_Controls
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
            this.lblVong = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Minus = new System.Windows.Forms.TextBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PhaseName = new System.Windows.Forms.TextBox();
            this.txt_Sequence = new System.Windows.Forms.TextBox();
            this.lbl_IDPhase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVong
            // 
            this.lblVong.AutoSize = true;
            this.lblVong.BackColor = System.Drawing.Color.Transparent;
            this.lblVong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVong.ForeColor = System.Drawing.Color.White;
            this.lblVong.Location = new System.Drawing.Point(13, 18);
            this.lblVong.Name = "lblVong";
            this.lblVong.Size = new System.Drawing.Size(55, 16);
            this.lblVong.TabIndex = 40;
            this.lblVong.Text = "Thứ tự";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(285, 7);
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
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(179, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Điểm";
            // 
            // txt_Score
            // 
            this.txt_Score.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Score.Location = new System.Drawing.Point(123, 81);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(50, 23);
            this.txt_Score.TabIndex = 37;
            this.txt_Score.Text = "20";
            this.txt_Score.TextChanged += new System.EventHandler(this.txt_Score_TextChanged);
            this.txt_Score.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Score_KeyDown);
            this.txt_Score.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Score_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Điểm cộng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Điểm trừ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên giai đoạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(179, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Điểm";
            // 
            // txt_Minus
            // 
            this.txt_Minus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Minus.Location = new System.Drawing.Point(123, 115);
            this.txt_Minus.Name = "txt_Minus";
            this.txt_Minus.Size = new System.Drawing.Size(50, 23);
            this.txt_Minus.TabIndex = 43;
            this.txt_Minus.Text = "0";
            this.txt_Minus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Minus_KeyDown);
            this.txt_Minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Minus_KeyPress);
            // 
            // txt_Time
            // 
            this.txt_Time.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Time.Location = new System.Drawing.Point(123, 144);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(50, 23);
            this.txt_Time.TabIndex = 46;
            this.txt_Time.Text = "30";
            this.txt_Time.TextChanged += new System.EventHandler(this.txt_Time_TextChanged);
            this.txt_Time.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Time_KeyDown);
            this.txt_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Time_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(184, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Giây";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Thời gian:";
            // 
            // txt_PhaseName
            // 
            this.txt_PhaseName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhaseName.Location = new System.Drawing.Point(123, 48);
            this.txt_PhaseName.Name = "txt_PhaseName";
            this.txt_PhaseName.Size = new System.Drawing.Size(139, 23);
            this.txt_PhaseName.TabIndex = 47;
            // 
            // txt_Sequence
            // 
            this.txt_Sequence.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sequence.Location = new System.Drawing.Point(123, 17);
            this.txt_Sequence.Name = "txt_Sequence";
            this.txt_Sequence.Size = new System.Drawing.Size(50, 23);
            this.txt_Sequence.TabIndex = 48;
            this.txt_Sequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Sequence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Sequence_KeyDown);
            this.txt_Sequence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sequence_KeyPress);
            // 
            // lbl_IDPhase
            // 
            this.lbl_IDPhase.AutoSize = true;
            this.lbl_IDPhase.Location = new System.Drawing.Point(270, 166);
            this.lbl_IDPhase.Name = "lbl_IDPhase";
            this.lbl_IDPhase.Size = new System.Drawing.Size(15, 13);
            this.lbl_IDPhase.TabIndex = 49;
            this.lbl_IDPhase.Text = "id";
            this.lbl_IDPhase.Visible = false;
            // 
            // Add_Phase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_IDPhase);
            this.Controls.Add(this.txt_Sequence);
            this.Controls.Add(this.txt_PhaseName);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Minus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVong);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Add_Phase";
            this.Size = new System.Drawing.Size(310, 190);
            this.Load += new System.EventHandler(this.Add_Phase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Score;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_Minus;
        public System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.TextBox txt_PhaseName;
        public System.Windows.Forms.TextBox txt_Sequence;
        public System.Windows.Forms.Label lbl_IDPhase;
    }
}
