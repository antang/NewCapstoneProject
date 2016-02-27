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
            this.flp_PlayerAnswers = new System.Windows.Forms.Panel();
            this.lbl_TimeShowQuestion = new System.Windows.Forms.Label();
            this.lbl_Point = new System.Windows.Forms.Label();
            this.lbl_Phase = new System.Windows.Forms.Label();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.pnl_QuestionFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_QuestionFrame
            // 
            this.pnl_QuestionFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_QuestionFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnl_QuestionFrame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_QuestionFrame.BackgroundImage")));
            this.pnl_QuestionFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_QuestionFrame.Controls.Add(this.lbl_QuestionContent);
            this.pnl_QuestionFrame.Location = new System.Drawing.Point(0, 61);
            this.pnl_QuestionFrame.Name = "pnl_QuestionFrame";
            this.pnl_QuestionFrame.Size = new System.Drawing.Size(1018, 256);
            this.pnl_QuestionFrame.TabIndex = 11;
            // 
            // lbl_QuestionContent
            // 
            this.lbl_QuestionContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_QuestionContent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QuestionContent.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuestionContent.ForeColor = System.Drawing.Color.White;
            this.lbl_QuestionContent.Location = new System.Drawing.Point(49, 12);
            this.lbl_QuestionContent.Name = "lbl_QuestionContent";
            this.lbl_QuestionContent.Size = new System.Drawing.Size(924, 232);
            this.lbl_QuestionContent.TabIndex = 0;
            this.lbl_QuestionContent.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19";
            this.lbl_QuestionContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flp_AnswerQuiz
            // 
            this.flp_AnswerQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_AnswerQuiz.BackColor = System.Drawing.Color.Transparent;
            this.flp_AnswerQuiz.Location = new System.Drawing.Point(0, 436);
            this.flp_AnswerQuiz.Name = "flp_AnswerQuiz";
            this.flp_AnswerQuiz.Size = new System.Drawing.Size(1026, 303);
            this.flp_AnswerQuiz.TabIndex = 10;
            // 
            // flp_PlayerAnswers
            // 
            this.flp_PlayerAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_PlayerAnswers.BackColor = System.Drawing.Color.Transparent;
            this.flp_PlayerAnswers.Location = new System.Drawing.Point(0, 323);
            this.flp_PlayerAnswers.Name = "flp_PlayerAnswers";
            this.flp_PlayerAnswers.Size = new System.Drawing.Size(1018, 110);
            this.flp_PlayerAnswers.TabIndex = 12;
            // 
            // lbl_TimeShowQuestion
            // 
            this.lbl_TimeShowQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TimeShowQuestion.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeShowQuestion.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_TimeShowQuestion.Location = new System.Drawing.Point(477, 3);
            this.lbl_TimeShowQuestion.Name = "lbl_TimeShowQuestion";
            this.lbl_TimeShowQuestion.Size = new System.Drawing.Size(129, 50);
            this.lbl_TimeShowQuestion.TabIndex = 13;
            this.lbl_TimeShowQuestion.Text = "30";
            this.lbl_TimeShowQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Point
            // 
            this.lbl_Point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Point.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Point.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Point.ForeColor = System.Drawing.Color.White;
            this.lbl_Point.Location = new System.Drawing.Point(671, 3);
            this.lbl_Point.Name = "lbl_Point";
            this.lbl_Point.Size = new System.Drawing.Size(302, 32);
            this.lbl_Point.TabIndex = 15;
            this.lbl_Point.Text = "Point: 20";
            this.lbl_Point.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Phase
            // 
            this.lbl_Phase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phase.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phase.ForeColor = System.Drawing.Color.White;
            this.lbl_Phase.Location = new System.Drawing.Point(0, 0);
            this.lbl_Phase.Name = "lbl_Phase";
            this.lbl_Phase.Size = new System.Drawing.Size(358, 35);
            this.lbl_Phase.TabIndex = 14;
            this.lbl_Phase.Text = "Requirement (25)";
            this.lbl_Phase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_Close
            // 
            this.pb_Close.BackColor = System.Drawing.Color.Transparent;
            this.pb_Close.BackgroundImage = global::CapDemo.Properties.Resources.Button_Close;
            this.pb_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Close.Location = new System.Drawing.Point(994, 0);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(22, 23);
            this.pb_Close.TabIndex = 16;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // PreviewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapDemo.Properties.Resources.BackGround_2;
            this.ClientSize = new System.Drawing.Size(1016, 742);
            this.Controls.Add(this.pb_Close);
            this.Controls.Add(this.lbl_TimeShowQuestion);
            this.Controls.Add(this.lbl_Point);
            this.Controls.Add(this.lbl_Phase);
            this.Controls.Add(this.flp_PlayerAnswers);
            this.Controls.Add(this.pnl_QuestionFrame);
            this.Controls.Add(this.flp_AnswerQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem trước câu hỏi";
            this.Load += new System.EventHandler(this.PreviewQuestion_Load);
            this.pnl_QuestionFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_QuestionFrame;
        public System.Windows.Forms.Label lbl_QuestionContent;
        public System.Windows.Forms.FlowLayoutPanel flp_AnswerQuiz;
        public System.Windows.Forms.Panel flp_PlayerAnswers;
        public System.Windows.Forms.Label lbl_TimeShowQuestion;
        public System.Windows.Forms.Label lbl_Point;
        public System.Windows.Forms.Label lbl_Phase;
        private System.Windows.Forms.PictureBox pb_Close;
    }
}