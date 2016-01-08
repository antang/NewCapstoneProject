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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.pb_TeamShirt = new System.Windows.Forms.PictureBox();
            this.lbl_Position = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(137, 20);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(264, 32);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score
            // 
            this.lbl_Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Score.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.White;
            this.lbl_Score.Location = new System.Drawing.Point(134, 55);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(267, 52);
            this.lbl_Score.TabIndex = 4;
            this.lbl_Score.Text = "100";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_TeamShirt
            // 
            this.pb_TeamShirt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_TeamShirt.BackColor = System.Drawing.Color.White;
            this.pb_TeamShirt.BackgroundImage = global::CapDemo.Properties.Resources.ao;
            this.pb_TeamShirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_TeamShirt.Location = new System.Drawing.Point(404, 19);
            this.pb_TeamShirt.Name = "pb_TeamShirt";
            this.pb_TeamShirt.Size = new System.Drawing.Size(80, 90);
            this.pb_TeamShirt.TabIndex = 0;
            this.pb_TeamShirt.TabStop = false;
            this.pb_TeamShirt.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Position
            // 
            this.lbl_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.ForeColor = System.Drawing.Color.White;
            this.lbl_Position.Location = new System.Drawing.Point(42, 19);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(52, 87);
            this.lbl_Position.TabIndex = 5;
            this.lbl_Position.Text = "4";
            this.lbl_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Position.Visible = false;
            // 
            // TeamEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::CapDemo.Properties.Resources.First;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_Position);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pb_TeamShirt);
            this.DoubleBuffered = true;
            this.Name = "TeamEndGame";
            this.Size = new System.Drawing.Size(532, 127);
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_TeamShirt;
        public System.Windows.Forms.Label lbl_Name;
        public System.Windows.Forms.Label lbl_Score;
        public System.Windows.Forms.Label lbl_Position;

    }
}
