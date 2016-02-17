namespace CapDemo.GUI
{
    partial class EditQuestion_ShortAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuestion_ShortAnswer));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TimeAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ScoreTru = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ScoreCong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.txt_ContentQuestion = new System.Windows.Forms.TextBox();
            this.btn_SaveEditQuestion = new System.Windows.Forms.Button();
            this.btn_CancelEditQuestion = new System.Windows.Forms.Button();
            this.txt_ContentAnswer = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "Cancel.png");
            this.imageList1.Images.SetKeyName(2, "save-512.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Chỉnh sửa câu hỏi";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(414, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Đáp án";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(423, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Ngày tạo";
            // 
            // txt_TimeAnswer
            // 
            this.txt_TimeAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimeAnswer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeAnswer.Location = new System.Drawing.Point(98, 480);
            this.txt_TimeAnswer.Name = "txt_TimeAnswer";
            this.txt_TimeAnswer.Size = new System.Drawing.Size(100, 23);
            this.txt_TimeAnswer.TabIndex = 48;
            this.txt_TimeAnswer.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Điểm +";
            this.label5.Visible = false;
            // 
            // txt_ScoreTru
            // 
            this.txt_ScoreTru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ScoreTru.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ScoreTru.Location = new System.Drawing.Point(80, 451);
            this.txt_ScoreTru.Name = "txt_ScoreTru";
            this.txt_ScoreTru.Size = new System.Drawing.Size(100, 23);
            this.txt_ScoreTru.TabIndex = 47;
            this.txt_ScoreTru.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Điểm -";
            this.label6.Visible = false;
            // 
            // txt_ScoreCong
            // 
            this.txt_ScoreCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ScoreCong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ScoreCong.Location = new System.Drawing.Point(80, 417);
            this.txt_ScoreCong.Name = "txt_ScoreCong";
            this.txt_ScoreCong.Size = new System.Drawing.Size(100, 23);
            this.txt_ScoreCong.TabIndex = 46;
            this.txt_ScoreCong.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Thời gian";
            this.label7.Visible = false;
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.ForeColor = System.Drawing.Color.White;
            this.lbl_Question.Location = new System.Drawing.Point(11, 121);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(132, 16);
            this.lbl_Question.TabIndex = 41;
            this.lbl_Question.Text = "Nội dung câu hỏi:";
            // 
            // txt_ContentQuestion
            // 
            this.txt_ContentQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ContentQuestion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContentQuestion.Location = new System.Drawing.Point(15, 143);
            this.txt_ContentQuestion.Multiline = true;
            this.txt_ContentQuestion.Name = "txt_ContentQuestion";
            this.txt_ContentQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ContentQuestion.Size = new System.Drawing.Size(397, 189);
            this.txt_ContentQuestion.TabIndex = 39;
            // 
            // btn_SaveEditQuestion
            // 
            this.btn_SaveEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveEditQuestion.BackColor = System.Drawing.Color.White;
            this.btn_SaveEditQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveEditQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveEditQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveEditQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveEditQuestion.ImageIndex = 2;
            this.btn_SaveEditQuestion.ImageList = this.imageList1;
            this.btn_SaveEditQuestion.Location = new System.Drawing.Point(560, 464);
            this.btn_SaveEditQuestion.Name = "btn_SaveEditQuestion";
            this.btn_SaveEditQuestion.Size = new System.Drawing.Size(90, 30);
            this.btn_SaveEditQuestion.TabIndex = 53;
            this.btn_SaveEditQuestion.Text = "Lưu";
            this.btn_SaveEditQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveEditQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveEditQuestion.UseVisualStyleBackColor = false;
            this.btn_SaveEditQuestion.Click += new System.EventHandler(this.btn_SaveEditQuestion_Click);
            // 
            // btn_CancelEditQuestion
            // 
            this.btn_CancelEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelEditQuestion.BackColor = System.Drawing.Color.White;
            this.btn_CancelEditQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelEditQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelEditQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelEditQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelEditQuestion.ImageIndex = 1;
            this.btn_CancelEditQuestion.ImageList = this.imageList1;
            this.btn_CancelEditQuestion.Location = new System.Drawing.Point(666, 464);
            this.btn_CancelEditQuestion.Name = "btn_CancelEditQuestion";
            this.btn_CancelEditQuestion.Size = new System.Drawing.Size(90, 30);
            this.btn_CancelEditQuestion.TabIndex = 54;
            this.btn_CancelEditQuestion.Text = "Hủy";
            this.btn_CancelEditQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelEditQuestion.UseVisualStyleBackColor = false;
            this.btn_CancelEditQuestion.Click += new System.EventHandler(this.btn_CancelEditQuestion_Click);
            // 
            // txt_ContentAnswer
            // 
            this.txt_ContentAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ContentAnswer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContentAnswer.Location = new System.Drawing.Point(418, 143);
            this.txt_ContentAnswer.Multiline = true;
            this.txt_ContentAnswer.Name = "txt_ContentAnswer";
            this.txt_ContentAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ContentAnswer.Size = new System.Drawing.Size(338, 189);
            this.txt_ContentAnswer.TabIndex = 55;
            // 
            // txt_Date
            // 
            this.txt_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.Location = new System.Drawing.Point(505, 362);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(100, 23);
            this.txt_Date.TabIndex = 56;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // EditQuestion_ShortAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(768, 515);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_ContentAnswer);
            this.Controls.Add(this.btn_SaveEditQuestion);
            this.Controls.Add(this.btn_CancelEditQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_TimeAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ScoreTru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ScoreCong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.txt_ContentQuestion);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditQuestion_ShortAnswer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa câu hỏi Short-Answer";
            this.Load += new System.EventHandler(this.EditQuestion_ShortAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveEditQuestion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_CancelEditQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TimeAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ScoreTru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ScoreCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.TextBox txt_ContentQuestion;
        private System.Windows.Forms.TextBox txt_ContentAnswer;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}