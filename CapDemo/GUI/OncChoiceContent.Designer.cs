namespace CapDemo.GUI
{
    partial class OncChoiceContent
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
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_Minus = new System.Windows.Forms.TextBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.txt_Bonus = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_AddAnswer = new System.Windows.Forms.Button();
            this.lbl_bonus = new System.Windows.Forms.Label();
            this.lbl_Minus = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flp_Answer = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.txt_QuestionName = new System.Windows.Forms.TextBox();
            this.lbl_QuestionName = new System.Windows.Forms.Label();
            this.lbl_Catalogue = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_date
            // 
            this.txt_date.Enabled = false;
            this.txt_date.Location = new System.Drawing.Point(321, 57);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(120, 20);
            this.txt_date.TabIndex = 17;
            // 
            // txt_Minus
            // 
            this.txt_Minus.Location = new System.Drawing.Point(76, 42);
            this.txt_Minus.Name = "txt_Minus";
            this.txt_Minus.Size = new System.Drawing.Size(100, 20);
            this.txt_Minus.TabIndex = 15;
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(76, 77);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(100, 20);
            this.txt_Time.TabIndex = 16;
            // 
            // txt_Bonus
            // 
            this.txt_Bonus.Location = new System.Drawing.Point(76, 13);
            this.txt_Bonus.Name = "txt_Bonus";
            this.txt_Bonus.Size = new System.Drawing.Size(100, 20);
            this.txt_Bonus.TabIndex = 14;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(390, 337);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 25;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(292, 337);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "Lưu lại";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_AddAnswer
            // 
            this.btn_AddAnswer.Location = new System.Drawing.Point(255, 13);
            this.btn_AddAnswer.Name = "btn_AddAnswer";
            this.btn_AddAnswer.Size = new System.Drawing.Size(83, 23);
            this.btn_AddAnswer.TabIndex = 6;
            this.btn_AddAnswer.Text = "Thêm đáp án";
            this.btn_AddAnswer.UseVisualStyleBackColor = true;
            this.btn_AddAnswer.Click += new System.EventHandler(this.btn_AddAnswer_Click);
            // 
            // lbl_bonus
            // 
            this.lbl_bonus.AutoSize = true;
            this.lbl_bonus.Location = new System.Drawing.Point(24, 21);
            this.lbl_bonus.Name = "lbl_bonus";
            this.lbl_bonus.Size = new System.Drawing.Size(40, 13);
            this.lbl_bonus.TabIndex = 7;
            this.lbl_bonus.Text = "Điểm +";
            // 
            // lbl_Minus
            // 
            this.lbl_Minus.AutoSize = true;
            this.lbl_Minus.Location = new System.Drawing.Point(24, 50);
            this.lbl_Minus.Name = "lbl_Minus";
            this.lbl_Minus.Size = new System.Drawing.Size(37, 13);
            this.lbl_Minus.TabIndex = 8;
            this.lbl_Minus.Text = "Điểm -";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(24, 85);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(51, 13);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "Thời gian";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(252, 60);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(50, 13);
            this.lbl_date.TabIndex = 10;
            this.lbl_date.Text = "Ngày tạo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.txt_Minus);
            this.groupBox1.Controls.Add(this.txt_Time);
            this.groupBox1.Controls.Add(this.btn_AddAnswer);
            this.groupBox1.Controls.Add(this.lbl_bonus);
            this.groupBox1.Controls.Add(this.txt_Bonus);
            this.groupBox1.Controls.Add(this.lbl_Minus);
            this.groupBox1.Controls.Add(this.lbl_time);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Location = new System.Drawing.Point(24, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 106);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // flp_Answer
            // 
            this.flp_Answer.AutoScroll = true;
            this.flp_Answer.Location = new System.Drawing.Point(279, 63);
            this.flp_Answer.Name = "flp_Answer";
            this.flp_Answer.Size = new System.Drawing.Size(276, 142);
            this.flp_Answer.TabIndex = 23;
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Location = new System.Drawing.Point(276, 47);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(42, 13);
            this.lbl_Answer.TabIndex = 22;
            this.lbl_Answer.Text = "Đáp án";
            // 
            // txt_QuestionName
            // 
            this.txt_QuestionName.Location = new System.Drawing.Point(24, 63);
            this.txt_QuestionName.Multiline = true;
            this.txt_QuestionName.Name = "txt_QuestionName";
            this.txt_QuestionName.Size = new System.Drawing.Size(238, 142);
            this.txt_QuestionName.TabIndex = 21;
            // 
            // lbl_QuestionName
            // 
            this.lbl_QuestionName.AutoSize = true;
            this.lbl_QuestionName.Location = new System.Drawing.Point(21, 47);
            this.lbl_QuestionName.Name = "lbl_QuestionName";
            this.lbl_QuestionName.Size = new System.Drawing.Size(43, 13);
            this.lbl_QuestionName.TabIndex = 20;
            this.lbl_QuestionName.Text = "Câu hỏi";
            // 
            // lbl_Catalogue
            // 
            this.lbl_Catalogue.AutoSize = true;
            this.lbl_Catalogue.Location = new System.Drawing.Point(21, 23);
            this.lbl_Catalogue.Name = "lbl_Catalogue";
            this.lbl_Catalogue.Size = new System.Drawing.Size(42, 13);
            this.lbl_Catalogue.TabIndex = 18;
            this.lbl_Catalogue.Text = "Chủ đề";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // OncChoiceContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flp_Answer);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.txt_QuestionName);
            this.Controls.Add(this.lbl_QuestionName);
            this.Controls.Add(this.lbl_Catalogue);
            this.Name = "OncChoiceContent";
            this.Size = new System.Drawing.Size(596, 399);
            this.Load += new System.EventHandler(this.OncChoiceContent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_Minus;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.TextBox txt_Bonus;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_AddAnswer;
        private System.Windows.Forms.Label lbl_bonus;
        private System.Windows.Forms.Label lbl_Minus;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flp_Answer;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.TextBox txt_QuestionName;
        private System.Windows.Forms.Label lbl_QuestionName;
        private System.Windows.Forms.Label lbl_Catalogue;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
