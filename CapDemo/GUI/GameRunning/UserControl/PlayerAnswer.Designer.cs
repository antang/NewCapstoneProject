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
            this.lbl_TeamName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamName.ForeColor = System.Drawing.Color.White;
            this.lbl_TeamName.Location = new System.Drawing.Point(64, 13);
            this.lbl_TeamName.Name = "lbl_TeamName";
            this.lbl_TeamName.Size = new System.Drawing.Size(162, 37);
            this.lbl_TeamName.TabIndex = 5;
            this.lbl_TeamName.Text = "abc";
            this.lbl_TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TeamAnswer
            // 
            this.lbl_TeamAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeamAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TeamAnswer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamAnswer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_TeamAnswer.Location = new System.Drawing.Point(64, 57);
            this.lbl_TeamAnswer.Name = "lbl_TeamAnswer";
            this.lbl_TeamAnswer.Size = new System.Drawing.Size(162, 35);
            this.lbl_TeamAnswer.TabIndex = 1;
            this.lbl_TeamAnswer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pb_Result
            // 
            this.pb_Result.BackColor = System.Drawing.Color.Maroon;
            this.pb_Result.Location = new System.Drawing.Point(7, 13);
            this.pb_Result.Name = "pb_Result";
            this.pb_Result.Size = new System.Drawing.Size(55, 80);
            this.pb_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Result.TabIndex = 4;
            this.pb_Result.TabStop = false;
            // 
            // PlayerAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_TeamName);
            this.Controls.Add(this.pb_Result);
            this.Controls.Add(this.lbl_Check);
            this.Controls.Add(this.lbl_IDPlayer);
            this.Controls.Add(this.lbl_TeamAnswer);
            this.DoubleBuffered = true;
            this.Name = "PlayerAnswer";
            this.Size = new System.Drawing.Size(237, 105);
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

    }
}
