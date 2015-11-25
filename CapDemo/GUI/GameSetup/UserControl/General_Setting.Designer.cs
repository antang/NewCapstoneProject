namespace CapDemo.GUI.User_Controls
{
    partial class General_Setting
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
            this.chk_Question = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimeShowQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_Answer = new System.Windows.Forms.CheckBox();
            this.grb_Question = new System.Windows.Forms.GroupBox();
            this.txt_CompetitionName = new System.Windows.Forms.TextBox();
            this.txt_TimeShowAnswe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NumStepFail = new System.Windows.Forms.TextBox();
            this.txt_NumStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Bonus = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grb_Answer = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_RoundName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ContestName = new System.Windows.Forms.TextBox();
            this.grb_Question.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grb_Answer.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Question
            // 
            this.chk_Question.AutoSize = true;
            this.chk_Question.BackColor = System.Drawing.Color.Transparent;
            this.chk_Question.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Question.ForeColor = System.Drawing.Color.White;
            this.chk_Question.Location = new System.Drawing.Point(377, 189);
            this.chk_Question.Name = "chk_Question";
            this.chk_Question.Size = new System.Drawing.Size(271, 23);
            this.chk_Question.TabIndex = 16;
            this.chk_Question.Text = "Thiết lập thời gian hiển thị câu hỏi";
            this.chk_Question.UseVisualStyleBackColor = false;
            this.chk_Question.CheckedChanged += new System.EventHandler(this.chk_Question_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên cuộc thi";
            // 
            // txt_TimeShowQuestion
            // 
            this.txt_TimeShowQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeShowQuestion.Location = new System.Drawing.Point(216, 16);
            this.txt_TimeShowQuestion.Multiline = true;
            this.txt_TimeShowQuestion.Name = "txt_TimeShowQuestion";
            this.txt_TimeShowQuestion.Size = new System.Drawing.Size(60, 30);
            this.txt_TimeShowQuestion.TabIndex = 5;
            this.txt_TimeShowQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TimeShowQuestion_KeyDown);
            this.txt_TimeShowQuestion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TimeShowQuestion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thời gian hiển thị câu hỏi";
            // 
            // chk_Answer
            // 
            this.chk_Answer.AutoSize = true;
            this.chk_Answer.BackColor = System.Drawing.Color.Transparent;
            this.chk_Answer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Answer.ForeColor = System.Drawing.Color.White;
            this.chk_Answer.Location = new System.Drawing.Point(377, 60);
            this.chk_Answer.Name = "chk_Answer";
            this.chk_Answer.Size = new System.Drawing.Size(351, 23);
            this.chk_Answer.TabIndex = 18;
            this.chk_Answer.Text = "Thiết lập thời gian hiển thị câu trả lời tự động\r\n";
            this.chk_Answer.UseVisualStyleBackColor = false;
            this.chk_Answer.CheckedChanged += new System.EventHandler(this.chk_Answer_CheckedChanged);
            // 
            // grb_Question
            // 
            this.grb_Question.Controls.Add(this.txt_TimeShowQuestion);
            this.grb_Question.Controls.Add(this.label2);
            this.grb_Question.Enabled = false;
            this.grb_Question.Location = new System.Drawing.Point(377, 211);
            this.grb_Question.Name = "grb_Question";
            this.grb_Question.Size = new System.Drawing.Size(302, 57);
            this.grb_Question.TabIndex = 17;
            this.grb_Question.TabStop = false;
            // 
            // txt_CompetitionName
            // 
            this.txt_CompetitionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompetitionName.Location = new System.Drawing.Point(28, 53);
            this.txt_CompetitionName.Multiline = true;
            this.txt_CompetitionName.Name = "txt_CompetitionName";
            this.txt_CompetitionName.Size = new System.Drawing.Size(276, 30);
            this.txt_CompetitionName.TabIndex = 15;
            // 
            // txt_TimeShowAnswe
            // 
            this.txt_TimeShowAnswe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeShowAnswe.Location = new System.Drawing.Point(216, 15);
            this.txt_TimeShowAnswe.Multiline = true;
            this.txt_TimeShowAnswe.Name = "txt_TimeShowAnswe";
            this.txt_TimeShowAnswe.Size = new System.Drawing.Size(60, 30);
            this.txt_TimeShowAnswe.TabIndex = 5;
            this.txt_TimeShowAnswe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TimeShowAnswe_KeyDown);
            this.txt_TimeShowAnswe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TimeShowAnswe_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm thưởng cho đội về đích đầu tiên\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian hiển thị câu trả lời\r\n";
            // 
            // txt_NumStepFail
            // 
            this.txt_NumStepFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumStepFail.Location = new System.Drawing.Point(462, 94);
            this.txt_NumStepFail.Multiline = true;
            this.txt_NumStepFail.Name = "txt_NumStepFail";
            this.txt_NumStepFail.Size = new System.Drawing.Size(60, 30);
            this.txt_NumStepFail.TabIndex = 9;
            this.txt_NumStepFail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NumStepFail_KeyDown);
            this.txt_NumStepFail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumStepFail_KeyPress);
            // 
            // txt_NumStep
            // 
            this.txt_NumStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumStep.Location = new System.Drawing.Point(462, 56);
            this.txt_NumStep.Multiline = true;
            this.txt_NumStep.Name = "txt_NumStep";
            this.txt_NumStep.Size = new System.Drawing.Size(60, 30);
            this.txt_NumStep.TabIndex = 9;
            this.txt_NumStep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NumStep_KeyDown);
            this.txt_NumStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumStep_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng câu trả lời sai tại mỗi giai đoạn để dừng cuộc thi";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng câu đúng đề bước qua giai đoạn tiếp theo\r\n\r\n\r\n";
            // 
            // txt_Bonus
            // 
            this.txt_Bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bonus.Location = new System.Drawing.Point(462, 19);
            this.txt_Bonus.Multiline = true;
            this.txt_Bonus.Name = "txt_Bonus";
            this.txt_Bonus.Size = new System.Drawing.Size(60, 30);
            this.txt_Bonus.TabIndex = 7;
            this.txt_Bonus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Bonus_KeyDown);
            this.txt_Bonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Bonus_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_NumStepFail);
            this.groupBox3.Controls.Add(this.txt_NumStep);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_Bonus);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(18, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 140);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thiết đặt các thông số cuộc thi";
            // 
            // grb_Answer
            // 
            this.grb_Answer.Controls.Add(this.txt_TimeShowAnswe);
            this.grb_Answer.Controls.Add(this.label3);
            this.grb_Answer.Enabled = false;
            this.grb_Answer.Location = new System.Drawing.Point(377, 80);
            this.grb_Answer.Name = "grb_Answer";
            this.grb_Answer.Size = new System.Drawing.Size(302, 57);
            this.grb_Answer.TabIndex = 19;
            this.grb_Answer.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tên vòng thi";
            // 
            // txt_RoundName
            // 
            this.txt_RoundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RoundName.Location = new System.Drawing.Point(28, 154);
            this.txt_RoundName.Multiline = true;
            this.txt_RoundName.Name = "txt_RoundName";
            this.txt_RoundName.Size = new System.Drawing.Size(276, 30);
            this.txt_RoundName.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tên phần thi";
            // 
            // txt_ContestName
            // 
            this.txt_ContestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContestName.Location = new System.Drawing.Point(28, 240);
            this.txt_ContestName.Multiline = true;
            this.txt_ContestName.Name = "txt_ContestName";
            this.txt_ContestName.Size = new System.Drawing.Size(276, 30);
            this.txt_ContestName.TabIndex = 24;
            // 
            // General_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ContestName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_RoundName);
            this.Controls.Add(this.chk_Question);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_Answer);
            this.Controls.Add(this.grb_Question);
            this.Controls.Add(this.txt_CompetitionName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grb_Answer);
            this.Name = "General_Setting";
            this.Size = new System.Drawing.Size(748, 480);
            this.grb_Question.ResumeLayout(false);
            this.grb_Question.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grb_Answer.ResumeLayout(false);
            this.grb_Answer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grb_Question;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grb_Answer;
        public System.Windows.Forms.CheckBox chk_Question;
        public System.Windows.Forms.TextBox txt_TimeShowQuestion;
        public System.Windows.Forms.CheckBox chk_Answer;
        public System.Windows.Forms.TextBox txt_CompetitionName;
        public System.Windows.Forms.TextBox txt_TimeShowAnswe;
        public System.Windows.Forms.TextBox txt_NumStepFail;
        public System.Windows.Forms.TextBox txt_NumStep;
        public System.Windows.Forms.TextBox txt_Bonus;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_RoundName;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_ContestName;
    }
}
