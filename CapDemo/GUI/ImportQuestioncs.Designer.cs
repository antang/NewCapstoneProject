namespace CapDemo.GUI
{
    partial class ImportQuestioncs
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
            this.flp_ImportQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_ImportFile = new System.Windows.Forms.RadioButton();
            this.lbl_Download = new System.Windows.Forms.Label();
            this.rad_ImportBank = new System.Windows.Forms.RadioButton();
            this.lbl_Title_Download = new System.Windows.Forms.Label();
            this.rad_NewQuestion = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_ImportQuestion
            // 
            this.flp_ImportQuestion.Location = new System.Drawing.Point(37, 118);
            this.flp_ImportQuestion.Name = "flp_ImportQuestion";
            this.flp_ImportQuestion.Size = new System.Drawing.Size(598, 455);
            this.flp_ImportQuestion.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_ImportFile);
            this.groupBox1.Controls.Add(this.lbl_Download);
            this.groupBox1.Controls.Add(this.rad_ImportBank);
            this.groupBox1.Controls.Add(this.lbl_Title_Download);
            this.groupBox1.Controls.Add(this.rad_NewQuestion);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rad_ImportFile
            // 
            this.rad_ImportFile.AutoSize = true;
            this.rad_ImportFile.Location = new System.Drawing.Point(15, 19);
            this.rad_ImportFile.Name = "rad_ImportFile";
            this.rad_ImportFile.Size = new System.Drawing.Size(133, 17);
            this.rad_ImportFile.TabIndex = 0;
            this.rad_ImportFile.TabStop = true;
            this.rad_ImportFile.Text = "Nhập câu hỏi từ tập tin";
            this.rad_ImportFile.UseVisualStyleBackColor = true;
            // 
            // lbl_Download
            // 
            this.lbl_Download.AutoSize = true;
            this.lbl_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Download.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Download.Location = new System.Drawing.Point(391, 36);
            this.lbl_Download.Name = "lbl_Download";
            this.lbl_Download.Size = new System.Drawing.Size(96, 13);
            this.lbl_Download.TabIndex = 4;
            this.lbl_Download.Text = "Mẫu câu hỏi.xls";
            // 
            // rad_ImportBank
            // 
            this.rad_ImportBank.AutoSize = true;
            this.rad_ImportBank.Location = new System.Drawing.Point(15, 42);
            this.rad_ImportBank.Name = "rad_ImportBank";
            this.rad_ImportBank.Size = new System.Drawing.Size(193, 17);
            this.rad_ImportBank.TabIndex = 1;
            this.rad_ImportBank.TabStop = true;
            this.rad_ImportBank.Text = "Nhập câu hỏi từ ngân hàng câu hỏi";
            this.rad_ImportBank.UseVisualStyleBackColor = true;
            // 
            // lbl_Title_Download
            // 
            this.lbl_Title_Download.AutoSize = true;
            this.lbl_Title_Download.Location = new System.Drawing.Point(387, 16);
            this.lbl_Title_Download.Name = "lbl_Title_Download";
            this.lbl_Title_Download.Size = new System.Drawing.Size(83, 13);
            this.lbl_Title_Download.TabIndex = 3;
            this.lbl_Title_Download.Text = "Tải mẫu tại đây:";
            // 
            // rad_NewQuestion
            // 
            this.rad_NewQuestion.AutoSize = true;
            this.rad_NewQuestion.Location = new System.Drawing.Point(15, 65);
            this.rad_NewQuestion.Name = "rad_NewQuestion";
            this.rad_NewQuestion.Size = new System.Drawing.Size(101, 17);
            this.rad_NewQuestion.TabIndex = 2;
            this.rad_NewQuestion.TabStop = true;
            this.rad_NewQuestion.Text = "Tạo câu hỏi mới";
            this.rad_NewQuestion.UseVisualStyleBackColor = true;
            this.rad_NewQuestion.CheckedChanged += new System.EventHandler(this.rad_NewQuestion_CheckedChanged);
            // 
            // ImportQuestioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 575);
            this.Controls.Add(this.flp_ImportQuestion);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImportQuestioncs";
            this.Text = "ImportQuestioncs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_ImportQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_ImportFile;
        private System.Windows.Forms.Label lbl_Download;
        private System.Windows.Forms.RadioButton rad_ImportBank;
        private System.Windows.Forms.Label lbl_Title_Download;
        private System.Windows.Forms.RadioButton rad_NewQuestion;
    }
}