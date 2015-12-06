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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General_Setting));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimeQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_Answer = new System.Windows.Forms.CheckBox();
            this.grb_Question = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_TimeAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NumStepFail = new System.Windows.Forms.TextBox();
            this.txt_NumStepPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Bonus = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grb_Answer = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ContestName = new System.Windows.Forms.TextBox();
            this.chk_Question = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_Competition = new System.Windows.Forms.ComboBox();
            this.cmb_Round = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_AddRound = new System.Windows.Forms.Button();
            this.btn_AddCompetition = new System.Windows.Forms.Button();
            this.grb_Question.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grb_Answer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên cuộc thi";
            // 
            // txt_TimeQuestion
            // 
            this.txt_TimeQuestion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeQuestion.Location = new System.Drawing.Point(216, 23);
            this.txt_TimeQuestion.Name = "txt_TimeQuestion";
            this.txt_TimeQuestion.Size = new System.Drawing.Size(60, 23);
            this.txt_TimeQuestion.TabIndex = 5;
            this.txt_TimeQuestion.Text = "30";
            this.txt_TimeQuestion.TextChanged += new System.EventHandler(this.txt_TimeQuestion_TextChanged);
            this.txt_TimeQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TimeQuestion_KeyDown);
            this.txt_TimeQuestion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TimeQuestion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thời gian hiển thị câu hỏi";
            // 
            // chk_Answer
            // 
            this.chk_Answer.AutoSize = true;
            this.chk_Answer.BackColor = System.Drawing.Color.Transparent;
            this.chk_Answer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Answer.ForeColor = System.Drawing.Color.White;
            this.chk_Answer.Location = new System.Drawing.Point(9, 123);
            this.chk_Answer.Name = "chk_Answer";
            this.chk_Answer.Size = new System.Drawing.Size(330, 20);
            this.chk_Answer.TabIndex = 18;
            this.chk_Answer.Text = "Thiết lập thời gian hiển thị câu trả lời tự động\r\n";
            this.chk_Answer.UseVisualStyleBackColor = false;
            this.chk_Answer.CheckedChanged += new System.EventHandler(this.chk_Answer_CheckedChanged);
            // 
            // grb_Question
            // 
            this.grb_Question.Controls.Add(this.label18);
            this.grb_Question.Controls.Add(this.txt_TimeQuestion);
            this.grb_Question.Controls.Add(this.label2);
            this.grb_Question.Enabled = false;
            this.grb_Question.Location = new System.Drawing.Point(9, 44);
            this.grb_Question.Name = "grb_Question";
            this.grb_Question.Size = new System.Drawing.Size(330, 57);
            this.grb_Question.TabIndex = 17;
            this.grb_Question.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(284, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "Giây";
            // 
            // txt_TimeAnswer
            // 
            this.txt_TimeAnswer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeAnswer.Location = new System.Drawing.Point(216, 23);
            this.txt_TimeAnswer.Name = "txt_TimeAnswer";
            this.txt_TimeAnswer.Size = new System.Drawing.Size(60, 23);
            this.txt_TimeAnswer.TabIndex = 5;
            this.txt_TimeAnswer.Text = "5";
            this.txt_TimeAnswer.TextChanged += new System.EventHandler(this.txt_TimeAnswer_TextChanged);
            this.txt_TimeAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TimeAnswer_KeyDown);
            this.txt_TimeAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TimeAnswer_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm thưởng cho đội về đích đầu tiên\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian hiển thị câu trả lời\r\n";
            // 
            // txt_NumStepFail
            // 
            this.txt_NumStepFail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumStepFail.Location = new System.Drawing.Point(392, 100);
            this.txt_NumStepFail.Name = "txt_NumStepFail";
            this.txt_NumStepFail.Size = new System.Drawing.Size(60, 23);
            this.txt_NumStepFail.TabIndex = 9;
            this.txt_NumStepFail.Text = "2";
            this.txt_NumStepFail.TextChanged += new System.EventHandler(this.txt_NumStepFail_TextChanged);
            this.txt_NumStepFail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NumStepFail_KeyDown);
            this.txt_NumStepFail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumStepFail_KeyPress);
            // 
            // txt_NumStepPass
            // 
            this.txt_NumStepPass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumStepPass.Location = new System.Drawing.Point(392, 70);
            this.txt_NumStepPass.Name = "txt_NumStepPass";
            this.txt_NumStepPass.Size = new System.Drawing.Size(60, 23);
            this.txt_NumStepPass.TabIndex = 9;
            this.txt_NumStepPass.Text = "2";
            this.txt_NumStepPass.TextChanged += new System.EventHandler(this.txt_NumStepPass_TextChanged);
            this.txt_NumStepPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NumStepPass_KeyDown);
            this.txt_NumStepPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumStepPass_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng câu sai ở giai đoạn để dừng cuộc thi";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng câu đúng đề bước qua giai đoạn tiếp theo\r\n\r\n\r\n";
            // 
            // txt_Bonus
            // 
            this.txt_Bonus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bonus.Location = new System.Drawing.Point(392, 38);
            this.txt_Bonus.Name = "txt_Bonus";
            this.txt_Bonus.Size = new System.Drawing.Size(60, 23);
            this.txt_Bonus.TabIndex = 7;
            this.txt_Bonus.Text = "20";
            this.txt_Bonus.TextChanged += new System.EventHandler(this.txt_Bonus_TextChanged);
            this.txt_Bonus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Bonus_KeyDown);
            this.txt_Bonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Bonus_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_NumStepFail);
            this.groupBox3.Controls.Add(this.txt_NumStepPass);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_Bonus);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(21, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(710, 153);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thiết đặt các thông số cuộc thi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(458, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "Câu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(458, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "Điểm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(458, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Câu";
            // 
            // grb_Answer
            // 
            this.grb_Answer.Controls.Add(this.label19);
            this.grb_Answer.Controls.Add(this.txt_TimeAnswer);
            this.grb_Answer.Controls.Add(this.label3);
            this.grb_Answer.Enabled = false;
            this.grb_Answer.Location = new System.Drawing.Point(9, 140);
            this.grb_Answer.Name = "grb_Answer";
            this.grb_Answer.Size = new System.Drawing.Size(330, 57);
            this.grb_Answer.TabIndex = 19;
            this.grb_Answer.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(284, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 16);
            this.label19.TabIndex = 36;
            this.label19.Text = "Giây";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tên vòng thi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tên phần thi";
            // 
            // txt_ContestName
            // 
            this.txt_ContestName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContestName.Location = new System.Drawing.Point(5, 158);
            this.txt_ContestName.Name = "txt_ContestName";
            this.txt_ContestName.Size = new System.Drawing.Size(276, 23);
            this.txt_ContestName.TabIndex = 24;
            this.txt_ContestName.TextChanged += new System.EventHandler(this.txt_ContestName_TextChanged);
            // 
            // chk_Question
            // 
            this.chk_Question.AutoSize = true;
            this.chk_Question.BackColor = System.Drawing.Color.Transparent;
            this.chk_Question.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Question.ForeColor = System.Drawing.Color.White;
            this.chk_Question.Location = new System.Drawing.Point(9, 18);
            this.chk_Question.Name = "chk_Question";
            this.chk_Question.Size = new System.Drawing.Size(311, 20);
            this.chk_Question.TabIndex = 25;
            this.chk_Question.Text = "Thiết lập thời gian hiển thị câu hỏi tự động\r\n";
            this.chk_Question.UseVisualStyleBackColor = false;
            this.chk_Question.CheckedChanged += new System.EventHandler(this.chk_Question_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddRound);
            this.groupBox1.Controls.Add(this.btn_AddCompetition);
            this.groupBox1.Controls.Add(this.cmb_Round);
            this.groupBox1.Controls.Add(this.cmb_Competition);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_ContestName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 215);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thiết đặt tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_Question);
            this.groupBox2.Controls.Add(this.grb_Answer);
            this.groupBox2.Controls.Add(this.grb_Question);
            this.groupBox2.Controls.Add(this.chk_Answer);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(368, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 215);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết đặt tự động";
            // 
            // cmb_Competition
            // 
            this.cmb_Competition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Competition.FormattingEnabled = true;
            this.cmb_Competition.Location = new System.Drawing.Point(7, 39);
            this.cmb_Competition.Name = "cmb_Competition";
            this.cmb_Competition.Size = new System.Drawing.Size(192, 21);
            this.cmb_Competition.TabIndex = 25;
            this.cmb_Competition.SelectedIndexChanged += new System.EventHandler(this.cmb_Competition_SelectedIndexChanged);
            // 
            // cmb_Round
            // 
            this.cmb_Round.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Round.FormattingEnabled = true;
            this.cmb_Round.Location = new System.Drawing.Point(7, 99);
            this.cmb_Round.Name = "cmb_Round";
            this.cmb_Round.Size = new System.Drawing.Size(192, 21);
            this.cmb_Round.TabIndex = 26;
            this.cmb_Round.SelectedIndexChanged += new System.EventHandler(this.cmb_Round_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit_add.ico");
            // 
            // btn_AddRound
            // 
            this.btn_AddRound.BackColor = System.Drawing.Color.White;
            this.btn_AddRound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddRound.ForeColor = System.Drawing.Color.White;
            this.btn_AddRound.ImageIndex = 0;
            this.btn_AddRound.ImageList = this.imageList1;
            this.btn_AddRound.Location = new System.Drawing.Point(205, 99);
            this.btn_AddRound.Name = "btn_AddRound";
            this.btn_AddRound.Size = new System.Drawing.Size(27, 23);
            this.btn_AddRound.TabIndex = 28;
            this.btn_AddRound.UseVisualStyleBackColor = false;
            this.btn_AddRound.Click += new System.EventHandler(this.btn_AddRound_Click);
            // 
            // btn_AddCompetition
            // 
            this.btn_AddCompetition.BackColor = System.Drawing.Color.White;
            this.btn_AddCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddCompetition.ForeColor = System.Drawing.Color.White;
            this.btn_AddCompetition.ImageIndex = 0;
            this.btn_AddCompetition.ImageList = this.imageList1;
            this.btn_AddCompetition.Location = new System.Drawing.Point(205, 39);
            this.btn_AddCompetition.Name = "btn_AddCompetition";
            this.btn_AddCompetition.Size = new System.Drawing.Size(27, 23);
            this.btn_AddCompetition.TabIndex = 27;
            this.btn_AddCompetition.UseVisualStyleBackColor = false;
            this.btn_AddCompetition.Click += new System.EventHandler(this.btn_AddCompetition_Click);
            // 
            // General_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "General_Setting";
            this.Size = new System.Drawing.Size(748, 480);
            this.Load += new System.EventHandler(this.General_Setting_Load);
            this.grb_Question.ResumeLayout(false);
            this.grb_Question.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grb_Answer.ResumeLayout(false);
            this.grb_Answer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_TimeQuestion;
        public System.Windows.Forms.CheckBox chk_Answer;
        public System.Windows.Forms.TextBox txt_TimeAnswer;
        public System.Windows.Forms.TextBox txt_NumStepFail;
        public System.Windows.Forms.TextBox txt_NumStepPass;
        public System.Windows.Forms.TextBox txt_Bonus;
        public System.Windows.Forms.TextBox txt_ContestName;
        public System.Windows.Forms.CheckBox chk_Question;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_AddRound;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_AddCompetition;
        public System.Windows.Forms.ComboBox cmb_Round;
        public System.Windows.Forms.ComboBox cmb_Competition;
    }
}
