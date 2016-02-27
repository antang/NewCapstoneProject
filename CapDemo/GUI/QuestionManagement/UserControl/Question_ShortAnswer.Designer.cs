namespace CapDemo.GUI.User_Controls
{
    partial class Question_ShortAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question_ShortAnswer));
            this.btn_SaveAndCreateNewQuestion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NameQuestion = new System.Windows.Forms.TextBox();
            this.txt_AnswerContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.txt_ContentQuestion = new System.Windows.Forms.TextBox();
            this.btn_CancelQuestion = new System.Windows.Forms.Button();
            this.btn_SaveQuestion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TimeAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ScoreTru = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ScoreCong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SaveAndCreateNewQuestion
            // 
            this.btn_SaveAndCreateNewQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveAndCreateNewQuestion.BackColor = System.Drawing.Color.White;
            this.btn_SaveAndCreateNewQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveAndCreateNewQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveAndCreateNewQuestion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveAndCreateNewQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveAndCreateNewQuestion.ImageIndex = 1;
            this.btn_SaveAndCreateNewQuestion.ImageList = this.imageList1;
            this.btn_SaveAndCreateNewQuestion.Location = new System.Drawing.Point(363, 409);
            this.btn_SaveAndCreateNewQuestion.Name = "btn_SaveAndCreateNewQuestion";
            this.btn_SaveAndCreateNewQuestion.Size = new System.Drawing.Size(182, 40);
            this.btn_SaveAndCreateNewQuestion.TabIndex = 41;
            this.btn_SaveAndCreateNewQuestion.Text = "Lưu và Tạo mới";
            this.btn_SaveAndCreateNewQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveAndCreateNewQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveAndCreateNewQuestion.UseVisualStyleBackColor = false;
            this.btn_SaveAndCreateNewQuestion.Click += new System.EventHandler(this.btn_SaveAndCreateNewQuestion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            this.imageList1.Images.SetKeyName(1, "save and create.png");
            this.imageList1.Images.SetKeyName(2, "save-512.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_NameQuestion);
            this.groupBox1.Controls.Add(this.txt_AnswerContent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Question);
            this.groupBox1.Controls.Add(this.txt_ContentQuestion);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(14, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 262);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung câu hỏi - dạng câu hỏi tự luận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên câu hỏi";
            // 
            // txt_NameQuestion
            // 
            this.txt_NameQuestion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameQuestion.Location = new System.Drawing.Point(10, 52);
            this.txt_NameQuestion.Name = "txt_NameQuestion";
            this.txt_NameQuestion.Size = new System.Drawing.Size(273, 23);
            this.txt_NameQuestion.TabIndex = 29;
            // 
            // txt_AnswerContent
            // 
            this.txt_AnswerContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_AnswerContent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AnswerContent.Location = new System.Drawing.Point(412, 52);
            this.txt_AnswerContent.Multiline = true;
            this.txt_AnswerContent.Name = "txt_AnswerContent";
            this.txt_AnswerContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_AnswerContent.Size = new System.Drawing.Size(308, 197);
            this.txt_AnswerContent.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Đáp án";
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(6, 84);
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
            this.txt_ContentQuestion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContentQuestion.Location = new System.Drawing.Point(6, 106);
            this.txt_ContentQuestion.Multiline = true;
            this.txt_ContentQuestion.Name = "txt_ContentQuestion";
            this.txt_ContentQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ContentQuestion.Size = new System.Drawing.Size(398, 143);
            this.txt_ContentQuestion.TabIndex = 19;
            // 
            // btn_CancelQuestion
            // 
            this.btn_CancelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelQuestion.BackColor = System.Drawing.Color.White;
            this.btn_CancelQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelQuestion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelQuestion.ImageIndex = 0;
            this.btn_CancelQuestion.ImageList = this.imageList1;
            this.btn_CancelQuestion.Location = new System.Drawing.Point(647, 409);
            this.btn_CancelQuestion.Name = "btn_CancelQuestion";
            this.btn_CancelQuestion.Size = new System.Drawing.Size(90, 40);
            this.btn_CancelQuestion.TabIndex = 39;
            this.btn_CancelQuestion.Text = "Hủy";
            this.btn_CancelQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelQuestion.UseVisualStyleBackColor = false;
            this.btn_CancelQuestion.Click += new System.EventHandler(this.btn_CancelQuestion_Click);
            // 
            // btn_SaveQuestion
            // 
            this.btn_SaveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveQuestion.BackColor = System.Drawing.Color.White;
            this.btn_SaveQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveQuestion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveQuestion.ImageIndex = 2;
            this.btn_SaveQuestion.ImageList = this.imageList1;
            this.btn_SaveQuestion.Location = new System.Drawing.Point(551, 409);
            this.btn_SaveQuestion.Name = "btn_SaveQuestion";
            this.btn_SaveQuestion.Size = new System.Drawing.Size(90, 40);
            this.btn_SaveQuestion.TabIndex = 38;
            this.btn_SaveQuestion.Text = "Lưu";
            this.btn_SaveQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveQuestion.UseVisualStyleBackColor = false;
            this.btn_SaveQuestion.Click += new System.EventHandler(this.btn_SaveQuestion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_Date);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(14, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 79);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết đặt câu hỏi";
            // 
            // txt_Date
            // 
            this.txt_Date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.Location = new System.Drawing.Point(102, 30);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.Size = new System.Drawing.Size(100, 23);
            this.txt_Date.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(10, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ngày tạo";
            // 
            // txt_TimeAnswer
            // 
            this.txt_TimeAnswer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeAnswer.Location = new System.Drawing.Point(426, 354);
            this.txt_TimeAnswer.Name = "txt_TimeAnswer";
            this.txt_TimeAnswer.ReadOnly = true;
            this.txt_TimeAnswer.Size = new System.Drawing.Size(100, 23);
            this.txt_TimeAnswer.TabIndex = 21;
            this.txt_TimeAnswer.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(331, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Điểm +";
            this.label5.Visible = false;
            // 
            // txt_ScoreTru
            // 
            this.txt_ScoreTru.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ScoreTru.Location = new System.Drawing.Point(426, 318);
            this.txt_ScoreTru.Name = "txt_ScoreTru";
            this.txt_ScoreTru.ReadOnly = true;
            this.txt_ScoreTru.Size = new System.Drawing.Size(100, 23);
            this.txt_ScoreTru.TabIndex = 20;
            this.txt_ScoreTru.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(331, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Điểm -";
            this.label6.Visible = false;
            // 
            // txt_ScoreCong
            // 
            this.txt_ScoreCong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ScoreCong.Location = new System.Drawing.Point(426, 283);
            this.txt_ScoreCong.Name = "txt_ScoreCong";
            this.txt_ScoreCong.ReadOnly = true;
            this.txt_ScoreCong.Size = new System.Drawing.Size(100, 23);
            this.txt_ScoreCong.TabIndex = 19;
            this.txt_ScoreCong.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(331, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Thời gian";
            this.label7.Visible = false;
            // 
            // Question_ShortAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btn_SaveAndCreateNewQuestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_TimeAnswer);
            this.Controls.Add(this.btn_CancelQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_SaveQuestion);
            this.Controls.Add(this.txt_ScoreTru);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ScoreCong);
            this.Controls.Add(this.label7);
            this.Name = "Question_ShortAnswer";
            this.Size = new System.Drawing.Size(755, 465);
            this.Load += new System.EventHandler(this.Question_ShortAnswer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveAndCreateNewQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.TextBox txt_ContentQuestion;
        private System.Windows.Forms.Button btn_CancelQuestion;
        private System.Windows.Forms.Button btn_SaveQuestion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TimeAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ScoreTru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ScoreCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_AnswerContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NameQuestion;
    }
}
