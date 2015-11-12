namespace CapDemo.GUI
{
    partial class CreateQuestionNew
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
            this.cbb_Catalogue = new System.Windows.Forms.ComboBox();
            this.lbl_Catalogue = new System.Windows.Forms.Label();
            this.pnl_ImportQuestion = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbb_Catalogue
            // 
            this.cbb_Catalogue.FormattingEnabled = true;
            this.cbb_Catalogue.Location = new System.Drawing.Point(100, 12);
            this.cbb_Catalogue.Name = "cbb_Catalogue";
            this.cbb_Catalogue.Size = new System.Drawing.Size(347, 21);
            this.cbb_Catalogue.TabIndex = 20;
            // 
            // lbl_Catalogue
            // 
            this.lbl_Catalogue.AutoSize = true;
            this.lbl_Catalogue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Catalogue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Catalogue.Location = new System.Drawing.Point(15, 14);
            this.lbl_Catalogue.Name = "lbl_Catalogue";
            this.lbl_Catalogue.Size = new System.Drawing.Size(65, 19);
            this.lbl_Catalogue.TabIndex = 19;
            this.lbl_Catalogue.Text = "Chủ đề:";
            // 
            // pnl_ImportQuestion
            // 
            this.pnl_ImportQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ImportQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_ImportQuestion.Location = new System.Drawing.Point(1, 44);
            this.pnl_ImportQuestion.Name = "pnl_ImportQuestion";
            this.pnl_ImportQuestion.Size = new System.Drawing.Size(832, 567);
            this.pnl_ImportQuestion.TabIndex = 21;
            // 
            // CreateQuestionNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.pnl_ImportQuestion);
            this.Controls.Add(this.cbb_Catalogue);
            this.Controls.Add(this.lbl_Catalogue);
            this.Name = "CreateQuestionNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo câu hỏi mới";
            this.Load += new System.EventHandler(this.CreateQuestionNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_Catalogue;
        private System.Windows.Forms.Label lbl_Catalogue;
        private System.Windows.Forms.Panel pnl_ImportQuestion;
    }
}