namespace CapDemo
{
    partial class PlayerAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerAnswer));
            this.lbl_IDPlayer = new System.Windows.Forms.Label();
            this.lbl_Check = new System.Windows.Forms.Label();
            this.lbl_TeamName = new System.Windows.Forms.Label();
            this.lbl_TeamAnswer = new System.Windows.Forms.Label();
            this.pb_Result = new System.Windows.Forms.PictureBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_TeamAnswer1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IDPlayer
            // 
            this.lbl_IDPlayer.AutoSize = true;
            this.lbl_IDPlayer.Location = new System.Drawing.Point(-29, 8);
            this.lbl_IDPlayer.Name = "lbl_IDPlayer";
            this.lbl_IDPlayer.Size = new System.Drawing.Size(0, 13);
            this.lbl_IDPlayer.TabIndex = 2;
            this.lbl_IDPlayer.Visible = false;
            // 
            // lbl_Check
            // 
            this.lbl_Check.AutoSize = true;
            this.lbl_Check.Location = new System.Drawing.Point(-23, 8);
            this.lbl_Check.Name = "lbl_Check";
            this.lbl_Check.Size = new System.Drawing.Size(0, 13);
            this.lbl_Check.TabIndex = 3;
            this.lbl_Check.Visible = false;
            // 
            // lbl_TeamName
            // 
            this.lbl_TeamName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeamName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TeamName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamName.ForeColor = System.Drawing.Color.White;
            this.lbl_TeamName.Location = new System.Drawing.Point(62, 12);
            this.lbl_TeamName.Name = "lbl_TeamName";
            this.lbl_TeamName.Size = new System.Drawing.Size(179, 37);
            this.lbl_TeamName.TabIndex = 5;
            this.lbl_TeamName.Text = "abc";
            this.lbl_TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TeamAnswer
            // 
            this.lbl_TeamAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeamAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TeamAnswer.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamAnswer.ForeColor = System.Drawing.Color.White;
            this.lbl_TeamAnswer.Location = new System.Drawing.Point(65, 49);
            this.lbl_TeamAnswer.Name = "lbl_TeamAnswer";
            this.lbl_TeamAnswer.Size = new System.Drawing.Size(183, 45);
            this.lbl_TeamAnswer.TabIndex = 1;
            this.lbl_TeamAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Result
            // 
            this.pb_Result.BackColor = System.Drawing.Color.Maroon;
            this.pb_Result.Location = new System.Drawing.Point(7, 11);
            this.pb_Result.Name = "pb_Result";
            this.pb_Result.Size = new System.Drawing.Size(54, 38);
            this.pb_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Result.TabIndex = 4;
            this.pb_Result.TabStop = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.White;
            this.lbl_Score.Location = new System.Drawing.Point(1, 50);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(67, 44);
            this.lbl_Score.TabIndex = 6;
            this.lbl_Score.Text = "+100";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Score.Visible = false;
            // 
            // lbl_TeamAnswer1
            // 
            this.lbl_TeamAnswer1.AutoSize = true;
            this.lbl_TeamAnswer1.Location = new System.Drawing.Point(65, 57);
            this.lbl_TeamAnswer1.Name = "lbl_TeamAnswer1";
            this.lbl_TeamAnswer1.Size = new System.Drawing.Size(0, 13);
            this.lbl_TeamAnswer1.TabIndex = 7;
            this.lbl_TeamAnswer1.Visible = false;
            // 
            // PlayerAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_TeamAnswer1);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_TeamName);
            this.Controls.Add(this.pb_Result);
            this.Controls.Add(this.lbl_Check);
            this.Controls.Add(this.lbl_IDPlayer);
            this.Controls.Add(this.lbl_TeamAnswer);
            this.DoubleBuffered = true;
            this.Name = "PlayerAnswer";
            this.Size = new System.Drawing.Size(251, 105);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_TeamAnswer;
        public System.Windows.Forms.Label lbl_IDPlayer;
        public System.Windows.Forms.Label lbl_Check;
        public System.Windows.Forms.Label lbl_TeamName;
        public System.Windows.Forms.PictureBox pb_Result;
        public System.Windows.Forms.Label lbl_Score;
        public System.Windows.Forms.Label lbl_TeamAnswer1;

    }
}
