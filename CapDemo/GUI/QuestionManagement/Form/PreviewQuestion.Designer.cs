namespace CapDemo
{
    partial class PreviewQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewQuestion));
            this.pnl_QuestionFrame = new System.Windows.Forms.Panel();
            this.lbl_QuestionContent = new System.Windows.Forms.Label();
            this.flp_AnswerQuiz = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_QuestionFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_QuestionFrame
            // 
            this.pnl_QuestionFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_QuestionFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnl_QuestionFrame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_QuestionFrame.BackgroundImage")));
            this.pnl_QuestionFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_QuestionFrame.Controls.Add(this.lbl_QuestionContent);
            this.pnl_QuestionFrame.Location = new System.Drawing.Point(-5, 26);
            this.pnl_QuestionFrame.Name = "pnl_QuestionFrame";
            this.pnl_QuestionFrame.Size = new System.Drawing.Size(1018, 256);
            this.pnl_QuestionFrame.TabIndex = 11;
            // 
            // lbl_QuestionContent
            // 
            this.lbl_QuestionContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_QuestionContent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QuestionContent.Font = new System.Drawing.Font("Verdana", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuestionContent.ForeColor = System.Drawing.Color.White;
            this.lbl_QuestionContent.Location = new System.Drawing.Point(49, 12);
            this.lbl_QuestionContent.Name = "lbl_QuestionContent";
            this.lbl_QuestionContent.Size = new System.Drawing.Size(924, 232);
            this.lbl_QuestionContent.TabIndex = 0;
            this.lbl_QuestionContent.Text = "abc";
            this.lbl_QuestionContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flp_AnswerQuiz
            // 
            this.flp_AnswerQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_AnswerQuiz.BackColor = System.Drawing.Color.Transparent;
            this.flp_AnswerQuiz.Location = new System.Drawing.Point(-5, 401);
            this.flp_AnswerQuiz.Name = "flp_AnswerQuiz";
            this.flp_AnswerQuiz.Size = new System.Drawing.Size(1018, 303);
            this.flp_AnswerQuiz.TabIndex = 10;
            // 
            // PreviewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapDemo.Properties.Resources.BackGround_2;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pnl_QuestionFrame);
            this.Controls.Add(this.flp_AnswerQuiz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem trước câu hỏi";
            this.Load += new System.EventHandler(this.PreviewQuestion_Load);
            this.pnl_QuestionFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_QuestionFrame;
        public System.Windows.Forms.Label lbl_QuestionContent;
        public System.Windows.Forms.FlowLayoutPanel flp_AnswerQuiz;
    }
}