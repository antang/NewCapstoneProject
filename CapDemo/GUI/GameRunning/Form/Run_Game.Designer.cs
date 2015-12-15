namespace CapDemo
{
    partial class Run_Game
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
            this.pnl_GameMap = new System.Windows.Forms.Panel();
            this.pnl_PhaseLine = new System.Windows.Forms.Panel();
            this.rtxt_QuestionContent = new System.Windows.Forms.RichTextBox();
            this.flp_AnswerContent = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnl_GameMap
            // 
            this.pnl_GameMap.BackColor = System.Drawing.Color.White;
            this.pnl_GameMap.Location = new System.Drawing.Point(90, 0);
            this.pnl_GameMap.Name = "pnl_GameMap";
            this.pnl_GameMap.Size = new System.Drawing.Size(385, 335);
            this.pnl_GameMap.TabIndex = 0;
            // 
            // pnl_PhaseLine
            // 
            this.pnl_PhaseLine.BackColor = System.Drawing.Color.Silver;
            this.pnl_PhaseLine.Location = new System.Drawing.Point(0, 0);
            this.pnl_PhaseLine.Name = "pnl_PhaseLine";
            this.pnl_PhaseLine.Size = new System.Drawing.Size(90, 335);
            this.pnl_PhaseLine.TabIndex = 1;
            // 
            // rtxt_QuestionContent
            // 
            this.rtxt_QuestionContent.Location = new System.Drawing.Point(481, 13);
            this.rtxt_QuestionContent.Name = "rtxt_QuestionContent";
            this.rtxt_QuestionContent.Size = new System.Drawing.Size(515, 322);
            this.rtxt_QuestionContent.TabIndex = 2;
            this.rtxt_QuestionContent.Text = "";
            // 
            // flp_AnswerContent
            // 
            this.flp_AnswerContent.BackColor = System.Drawing.Color.White;
            this.flp_AnswerContent.Location = new System.Drawing.Point(481, 358);
            this.flp_AnswerContent.Name = "flp_AnswerContent";
            this.flp_AnswerContent.Size = new System.Drawing.Size(515, 302);
            this.flp_AnswerContent.TabIndex = 3;
            // 
            // Run_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.flp_AnswerContent);
            this.Controls.Add(this.rtxt_QuestionContent);
            this.Controls.Add(this.pnl_PhaseLine);
            this.Controls.Add(this.pnl_GameMap);
            this.Name = "Run_Game";
            this.Text = "Run_Game";
            this.Load += new System.EventHandler(this.Run_Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_PhaseLine;
        public System.Windows.Forms.Panel pnl_GameMap;
        public System.Windows.Forms.RichTextBox rtxt_QuestionContent;
        public System.Windows.Forms.FlowLayoutPanel flp_AnswerContent;
    }
}