﻿namespace CapDemo.GUI
{
    partial class EditQuestion_MultiSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuestion_MultiSelect));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.txt_ContentQuestion = new System.Windows.Forms.TextBox();
            this.flp_addAnswer = new System.Windows.Forms.FlowLayoutPanel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TimeAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ScoreTru = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ScoreCong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addAnswer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_CancelEditQuestion = new System.Windows.Forms.Button();
            this.btn_SaveEditQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chủ đề ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(8, 120);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(136, 19);
            this.lbl_Question.TabIndex = 23;
            this.lbl_Question.Text = "Nội dung câu hỏi:";
            // 
            // txt_ContentQuestion
            // 
            this.txt_ContentQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ContentQuestion.Location = new System.Drawing.Point(12, 142);
            this.txt_ContentQuestion.Multiline = true;
            this.txt_ContentQuestion.Name = "txt_ContentQuestion";
            this.txt_ContentQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ContentQuestion.Size = new System.Drawing.Size(338, 189);
            this.txt_ContentQuestion.TabIndex = 22;
            // 
            // flp_addAnswer
            // 
            this.flp_addAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_addAnswer.AutoScroll = true;
            this.flp_addAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_addAnswer.Location = new System.Drawing.Point(356, 142);
            this.flp_addAnswer.Name = "flp_addAnswer";
            this.flp_addAnswer.Size = new System.Drawing.Size(400, 189);
            this.flp_addAnswer.TabIndex = 24;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(434, 379);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 32;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(352, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ngày tạo";
            // 
            // txt_TimeAnswer
            // 
            this.txt_TimeAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimeAnswer.Location = new System.Drawing.Point(434, 350);
            this.txt_TimeAnswer.Name = "txt_TimeAnswer";
            this.txt_TimeAnswer.Size = new System.Drawing.Size(100, 20);
            this.txt_TimeAnswer.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Điểm +";
            // 
            // txt_ScoreTru
            // 
            this.txt_ScoreTru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ScoreTru.Location = new System.Drawing.Point(108, 388);
            this.txt_ScoreTru.Name = "txt_ScoreTru";
            this.txt_ScoreTru.Size = new System.Drawing.Size(100, 20);
            this.txt_ScoreTru.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Điểm -";
            // 
            // txt_ScoreCong
            // 
            this.txt_ScoreCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ScoreCong.Location = new System.Drawing.Point(108, 353);
            this.txt_ScoreCong.Name = "txt_ScoreCong";
            this.txt_ScoreCong.Size = new System.Drawing.Size(100, 20);
            this.txt_ScoreCong.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(352, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Thời gian";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Đáp án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "Chỉnh sửa câu hỏi";
            // 
            // btn_addAnswer
            // 
            this.btn_addAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_addAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addAnswer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_addAnswer.ImageIndex = 0;
            this.btn_addAnswer.ImageList = this.imageList1;
            this.btn_addAnswer.Location = new System.Drawing.Point(615, 101);
            this.btn_addAnswer.Name = "btn_addAnswer";
            this.btn_addAnswer.Size = new System.Drawing.Size(141, 35);
            this.btn_addAnswer.TabIndex = 23;
            this.btn_addAnswer.Text = "Thêm đáp án";
            this.btn_addAnswer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addAnswer.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "Cancel.png");
            this.imageList1.Images.SetKeyName(2, "save-512.png");
            // 
            // btn_CancelEditQuestion
            // 
            this.btn_CancelEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelEditQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_CancelEditQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelEditQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelEditQuestion.ImageIndex = 1;
            this.btn_CancelEditQuestion.ImageList = this.imageList1;
            this.btn_CancelEditQuestion.Location = new System.Drawing.Point(666, 463);
            this.btn_CancelEditQuestion.Name = "btn_CancelEditQuestion";
            this.btn_CancelEditQuestion.Size = new System.Drawing.Size(90, 40);
            this.btn_CancelEditQuestion.TabIndex = 36;
            this.btn_CancelEditQuestion.Text = "Hủy";
            this.btn_CancelEditQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelEditQuestion.UseVisualStyleBackColor = false;
            // 
            // btn_SaveEditQuestion
            // 
            this.btn_SaveEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveEditQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_SaveEditQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveEditQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveEditQuestion.ImageIndex = 2;
            this.btn_SaveEditQuestion.ImageList = this.imageList1;
            this.btn_SaveEditQuestion.Location = new System.Drawing.Point(561, 463);
            this.btn_SaveEditQuestion.Name = "btn_SaveEditQuestion";
            this.btn_SaveEditQuestion.Size = new System.Drawing.Size(90, 40);
            this.btn_SaveEditQuestion.TabIndex = 35;
            this.btn_SaveEditQuestion.Text = "Lưu";
            this.btn_SaveEditQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveEditQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveEditQuestion.UseVisualStyleBackColor = false;
            // 
            // EditQuestion_MultiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 515);
            this.Controls.Add(this.btn_CancelEditQuestion);
            this.Controls.Add(this.btn_addAnswer);
            this.Controls.Add(this.btn_SaveEditQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_TimeAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ScoreTru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ScoreCong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flp_addAnswer);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.txt_ContentQuestion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Name = "EditQuestion_MultiSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa câu hỏi Mul-Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.TextBox txt_ContentQuestion;
        private System.Windows.Forms.FlowLayoutPanel flp_addAnswer;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TimeAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ScoreTru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ScoreCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_addAnswer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_CancelEditQuestion;
        private System.Windows.Forms.Button btn_SaveEditQuestion;
    }
}