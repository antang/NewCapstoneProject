namespace CapDemo
{
    partial class Team_AudienceScreeen
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
            this.components = new System.ComponentModel.Container();
            this.flp_Heart = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_Heart1 = new System.Windows.Forms.PictureBox();
            this.pb_Heart2 = new System.Windows.Forms.PictureBox();
            this.pb_Heart3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_TeamName = new System.Windows.Forms.Label();
            this.lbl_TeamScore = new System.Windows.Forms.Label();
            this.pb_TeamShirt = new System.Windows.Forms.PictureBox();
            this.timerHighLight = new System.Windows.Forms.Timer(this.components);
            this.lbl_ID = new System.Windows.Forms.Label();
            this.flp_Heart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_Heart
            // 
            this.flp_Heart.Controls.Add(this.pb_Heart1);
            this.flp_Heart.Controls.Add(this.pb_Heart2);
            this.flp_Heart.Controls.Add(this.pb_Heart3);
            this.flp_Heart.Location = new System.Drawing.Point(251, 0);
            this.flp_Heart.Name = "flp_Heart";
            this.flp_Heart.Size = new System.Drawing.Size(112, 36);
            this.flp_Heart.TabIndex = 1;
            // 
            // pb_Heart1
            // 
            this.pb_Heart1.BackgroundImage = global::CapDemo.Properties.Resources.trai_tim_dung;
            this.pb_Heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Heart1.Location = new System.Drawing.Point(3, 3);
            this.pb_Heart1.Name = "pb_Heart1";
            this.pb_Heart1.Size = new System.Drawing.Size(30, 31);
            this.pb_Heart1.TabIndex = 3;
            this.pb_Heart1.TabStop = false;
            // 
            // pb_Heart2
            // 
            this.pb_Heart2.BackgroundImage = global::CapDemo.Properties.Resources.trai_tim_dung;
            this.pb_Heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Heart2.Location = new System.Drawing.Point(39, 3);
            this.pb_Heart2.Name = "pb_Heart2";
            this.pb_Heart2.Size = new System.Drawing.Size(30, 31);
            this.pb_Heart2.TabIndex = 4;
            this.pb_Heart2.TabStop = false;
            // 
            // pb_Heart3
            // 
            this.pb_Heart3.BackgroundImage = global::CapDemo.Properties.Resources.trai_tim_dung;
            this.pb_Heart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Heart3.Location = new System.Drawing.Point(75, 3);
            this.pb_Heart3.Name = "pb_Heart3";
            this.pb_Heart3.Size = new System.Drawing.Size(30, 31);
            this.pb_Heart3.TabIndex = 5;
            this.pb_Heart3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CapDemo.Properties.Resources.thach_dau;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(312, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 44);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::CapDemo.Properties.Resources.y_kien;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(306, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 40);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_TeamName
            // 
            this.lbl_TeamName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamName.Location = new System.Drawing.Point(116, 37);
            this.lbl_TeamName.Name = "lbl_TeamName";
            this.lbl_TeamName.Size = new System.Drawing.Size(128, 23);
            this.lbl_TeamName.TabIndex = 3;
            this.lbl_TeamName.Text = "Name";
            this.lbl_TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TeamScore
            // 
            this.lbl_TeamScore.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamScore.Location = new System.Drawing.Point(116, 71);
            this.lbl_TeamScore.Name = "lbl_TeamScore";
            this.lbl_TeamScore.Size = new System.Drawing.Size(128, 31);
            this.lbl_TeamScore.TabIndex = 4;
            this.lbl_TeamScore.Text = "0";
            this.lbl_TeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_TeamShirt
            // 
            this.pb_TeamShirt.BackgroundImage = global::CapDemo.Properties.Resources.ao_lon;
            this.pb_TeamShirt.Location = new System.Drawing.Point(22, 27);
            this.pb_TeamShirt.Name = "pb_TeamShirt";
            this.pb_TeamShirt.Size = new System.Drawing.Size(78, 92);
            this.pb_TeamShirt.TabIndex = 0;
            this.pb_TeamShirt.TabStop = false;
            // 
            // timerHighLight
            // 
            this.timerHighLight.Tick += new System.EventHandler(this.timerHighLight_Tick);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 13);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Visible = false;
            // 
            // Team_AudienceScreeen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_TeamScore);
            this.Controls.Add(this.lbl_TeamName);
            this.Controls.Add(this.flp_Heart);
            this.Controls.Add(this.pb_TeamShirt);
            this.Name = "Team_AudienceScreeen";
            this.Size = new System.Drawing.Size(364, 132);
            this.flp_Heart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_TeamShirt;
        public System.Windows.Forms.FlowLayoutPanel flp_Heart;
        public System.Windows.Forms.PictureBox pb_Heart1;
        public System.Windows.Forms.PictureBox pb_Heart2;
        public System.Windows.Forms.PictureBox pb_Heart3;
        public System.Windows.Forms.Label lbl_TeamName;
        public System.Windows.Forms.Label lbl_TeamScore;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Timer timerHighLight;
        public System.Windows.Forms.Label lbl_ID;

    }
}
