﻿namespace CapDemo.GUI.User_Controls
{
    partial class Question_MultiSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question_MultiSelect));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addAnswer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Question = new System.Windows.Forms.Label();
            this.txt_ContentQuestion = new System.Windows.Forms.TextBox();
            this.flp_addAnswer = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TimeAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ScoreTru = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ScoreCong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_SaveAndCreateNewQuestion = new System.Windows.Forms.Button();
            this.btn_CancelQuestion = new System.Windows.Forms.Button();
            this.btn_SaveQuestion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_addAnswer);
            this.groupBox1.Controls.Add(this.lbl_Question);
            this.groupBox1.Controls.Add(this.txt_ContentQuestion);
            this.groupBox1.Controls.Add(this.flp_addAnswer);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(14, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 262);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung câu hỏi - dạng tùy chọn nhiều";
            // 
            // btn_addAnswer
            // 
            this.btn_addAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_addAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addAnswer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_addAnswer.ImageIndex = 1;
            this.btn_addAnswer.ImageList = this.imageList1;
            this.btn_addAnswer.Location = new System.Drawing.Point(319, 19);
            this.btn_addAnswer.Name = "btn_addAnswer";
            this.btn_addAnswer.Size = new System.Drawing.Size(141, 35);
            this.btn_addAnswer.TabIndex = 22;
            this.btn_addAnswer.Text = "Thêm đáp án";
            this.btn_addAnswer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addAnswer.UseVisualStyleBackColor = false;
            this.btn_addAnswer.Click += new System.EventHandler(this.btn_addAnswer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            this.imageList1.Images.SetKeyName(1, "create.png");
            this.imageList1.Images.SetKeyName(2, "save and create.png");
            this.imageList1.Images.SetKeyName(3, "save-512.png");
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(6, 30);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(130, 19);
            this.lbl_Question.TabIndex = 21;
            this.lbl_Question.Text = "Nội dung câu hỏi";
            // 
            // txt_ContentQuestion
            // 
            this.txt_ContentQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ContentQuestion.Location = new System.Drawing.Point(6, 60);
            this.txt_ContentQuestion.Multiline = true;
            this.txt_ContentQuestion.Name = "txt_ContentQuestion";
            this.txt_ContentQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ContentQuestion.Size = new System.Drawing.Size(308, 189);
            this.txt_ContentQuestion.TabIndex = 19;
            // 
            // flp_addAnswer
            // 
            this.flp_addAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_addAnswer.AutoScroll = true;
            this.flp_addAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_addAnswer.Location = new System.Drawing.Point(319, 60);
            this.flp_addAnswer.Name = "flp_addAnswer";
            this.flp_addAnswer.Size = new System.Drawing.Size(400, 189);
            this.flp_addAnswer.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_TimeAnswer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_ScoreTru);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_ScoreCong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(14, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 104);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết đặt câu hỏi";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(424, 58);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(332, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ngày tạo";
            // 
            // txt_TimeAnswer
            // 
            this.txt_TimeAnswer.Location = new System.Drawing.Point(424, 29);
            this.txt_TimeAnswer.Name = "txt_TimeAnswer";
            this.txt_TimeAnswer.Size = new System.Drawing.Size(100, 20);
            this.txt_TimeAnswer.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Điểm +";
            // 
            // txt_ScoreTru
            // 
            this.txt_ScoreTru.Location = new System.Drawing.Point(112, 62);
            this.txt_ScoreTru.Name = "txt_ScoreTru";
            this.txt_ScoreTru.Size = new System.Drawing.Size(100, 20);
            this.txt_ScoreTru.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(17, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Điểm -";
            // 
            // txt_ScoreCong
            // 
            this.txt_ScoreCong.Location = new System.Drawing.Point(112, 27);
            this.txt_ScoreCong.Name = "txt_ScoreCong";
            this.txt_ScoreCong.Size = new System.Drawing.Size(100, 20);
            this.txt_ScoreCong.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(329, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Thời gian";
            // 
            // btn_SaveAndCreateNewQuestion
            // 
            this.btn_SaveAndCreateNewQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveAndCreateNewQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_SaveAndCreateNewQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveAndCreateNewQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveAndCreateNewQuestion.ImageIndex = 2;
            this.btn_SaveAndCreateNewQuestion.ImageList = this.imageList1;
            this.btn_SaveAndCreateNewQuestion.Location = new System.Drawing.Point(374, 409);
            this.btn_SaveAndCreateNewQuestion.Name = "btn_SaveAndCreateNewQuestion";
            this.btn_SaveAndCreateNewQuestion.Size = new System.Drawing.Size(171, 40);
            this.btn_SaveAndCreateNewQuestion.TabIndex = 36;
            this.btn_SaveAndCreateNewQuestion.Text = "Lưu và Tạo mới";
            this.btn_SaveAndCreateNewQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveAndCreateNewQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveAndCreateNewQuestion.UseVisualStyleBackColor = false;
            // 
            // btn_CancelQuestion
            // 
            this.btn_CancelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_CancelQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelQuestion.ImageIndex = 0;
            this.btn_CancelQuestion.ImageList = this.imageList1;
            this.btn_CancelQuestion.Location = new System.Drawing.Point(647, 409);
            this.btn_CancelQuestion.Name = "btn_CancelQuestion";
            this.btn_CancelQuestion.Size = new System.Drawing.Size(90, 40);
            this.btn_CancelQuestion.TabIndex = 34;
            this.btn_CancelQuestion.Text = "Hủy";
            this.btn_CancelQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelQuestion.UseVisualStyleBackColor = false;
            // 
            // btn_SaveQuestion
            // 
            this.btn_SaveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_SaveQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveQuestion.ImageIndex = 3;
            this.btn_SaveQuestion.ImageList = this.imageList1;
            this.btn_SaveQuestion.Location = new System.Drawing.Point(551, 409);
            this.btn_SaveQuestion.Name = "btn_SaveQuestion";
            this.btn_SaveQuestion.Size = new System.Drawing.Size(90, 40);
            this.btn_SaveQuestion.TabIndex = 33;
            this.btn_SaveQuestion.Text = "Lưu";
            this.btn_SaveQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveQuestion.UseVisualStyleBackColor = false;
            // 
            // Question_MultiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btn_SaveAndCreateNewQuestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_CancelQuestion);
            this.Controls.Add(this.btn_SaveQuestion);
            this.Controls.Add(this.groupBox2);
            this.Name = "Question_MultiSelect";
            this.Size = new System.Drawing.Size(755, 465);
            this.Load += new System.EventHandler(this.Question_MultiSelect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveAndCreateNewQuestion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btn_addAnswer;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.TextBox txt_ContentQuestion;
        private System.Windows.Forms.FlowLayoutPanel flp_addAnswer;
        private System.Windows.Forms.Button btn_CancelQuestion;
        private System.Windows.Forms.Button btn_SaveQuestion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TimeAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ScoreTru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ScoreCong;
        private System.Windows.Forms.Label label7;
    }
}
