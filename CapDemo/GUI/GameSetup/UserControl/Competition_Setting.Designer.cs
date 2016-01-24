namespace CapDemo.GUI.User_Controls
{
    partial class Competition_Setting
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NumTeam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ChallengeScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimeForSupport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số đội được thách đấu";
            // 
            // txt_NumTeam
            // 
            this.txt_NumTeam.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumTeam.Location = new System.Drawing.Point(198, 37);
            this.txt_NumTeam.Name = "txt_NumTeam";
            this.txt_NumTeam.Size = new System.Drawing.Size(67, 23);
            this.txt_NumTeam.TabIndex = 2;
            this.txt_NumTeam.Text = "1";
            this.txt_NumTeam.TextChanged += new System.EventHandler(this.txt_NumTeam_TextChanged);
            this.txt_NumTeam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NumTeam_KeyDown);
            this.txt_NumTeam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumTeam_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm thách đấu";
            // 
            // txt_ChallengeScore
            // 
            this.txt_ChallengeScore.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChallengeScore.Location = new System.Drawing.Point(198, 83);
            this.txt_ChallengeScore.Name = "txt_ChallengeScore";
            this.txt_ChallengeScore.Size = new System.Drawing.Size(67, 23);
            this.txt_ChallengeScore.TabIndex = 3;
            this.txt_ChallengeScore.Text = "20";
            this.txt_ChallengeScore.TextChanged += new System.EventHandler(this.txt_ChallengeScore_TextChanged);
            this.txt_ChallengeScore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ChallengeScore_KeyDown);
            this.txt_ChallengeScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ChallengeScore_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đội";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_ChallengeScore);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_NumTeam);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 196);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết lập quyền thách đấu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian";
            // 
            // txt_TimeForSupport
            // 
            this.txt_TimeForSupport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeForSupport.Location = new System.Drawing.Point(94, 36);
            this.txt_TimeForSupport.Name = "txt_TimeForSupport";
            this.txt_TimeForSupport.Size = new System.Drawing.Size(67, 23);
            this.txt_TimeForSupport.TabIndex = 1;
            this.txt_TimeForSupport.Text = "60";
            this.txt_TimeForSupport.TextChanged += new System.EventHandler(this.txt_TimeForSupport_TextChanged);
            this.txt_TimeForSupport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TimeForSupport_KeyDown);
            this.txt_TimeForSupport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TimeForSupport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giây";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TimeForSupport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thiết lập quyền yêu cầu trợ giúp";
            // 
            // Competition_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Competition_Setting";
            this.Size = new System.Drawing.Size(710, 480);
            this.Load += new System.EventHandler(this.Competition_Setting_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_NumTeam;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_ChallengeScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_TimeForSupport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}
