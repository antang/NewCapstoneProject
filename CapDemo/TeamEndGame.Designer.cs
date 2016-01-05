namespace CapDemo
{
    partial class TeamEndGame
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
            this.lbl_Winner = new System.Windows.Forms.Label();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.pb_TeamShirt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Winner
            // 
            this.lbl_Winner.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Winner.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Winner.Location = new System.Drawing.Point(478, 0);
            this.lbl_Winner.Name = "lbl_Winner";
            this.lbl_Winner.Size = new System.Drawing.Size(114, 93);
            this.lbl_Winner.TabIndex = 1;
            this.lbl_Winner.Text = "Winner";
            this.lbl_Winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Winner.Visible = false;
            // 
            // lbl_Position
            // 
            this.lbl_Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Position.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.Location = new System.Drawing.Point(0, 0);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(109, 93);
            this.lbl_Position.TabIndex = 2;
            this.lbl_Position.Text = "1St";
            this.lbl_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(203, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(274, 48);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score
            // 
            this.lbl_Score.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Score.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(203, 48);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(274, 45);
            this.lbl_Score.TabIndex = 4;
            this.lbl_Score.Text = "100";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_TeamShirt
            // 
            this.pb_TeamShirt.BackgroundImage = global::CapDemo.Properties.Resources.ao_lon;
            this.pb_TeamShirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_TeamShirt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_TeamShirt.Location = new System.Drawing.Point(109, 0);
            this.pb_TeamShirt.Name = "pb_TeamShirt";
            this.pb_TeamShirt.Size = new System.Drawing.Size(94, 93);
            this.pb_TeamShirt.TabIndex = 0;
            this.pb_TeamShirt.TabStop = false;
            this.pb_TeamShirt.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TeamEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Position);
            this.Controls.Add(this.lbl_Winner);
            this.Controls.Add(this.pb_TeamShirt);
            this.Name = "TeamEndGame";
            this.Size = new System.Drawing.Size(595, 95);
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_TeamShirt;
        public System.Windows.Forms.Label lbl_Winner;
        public System.Windows.Forms.Label lbl_Position;
        public System.Windows.Forms.Label lbl_Name;
        public System.Windows.Forms.Label lbl_Score;

    }
}
