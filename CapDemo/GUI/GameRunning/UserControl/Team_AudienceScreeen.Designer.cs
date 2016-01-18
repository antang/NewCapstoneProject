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
            this.lbl_TeamName = new System.Windows.Forms.Label();
            this.lbl_TeamScore = new System.Windows.Forms.Label();
            this.timerHighLight = new System.Windows.Forms.Timer(this.components);
            this.lbl_ID = new System.Windows.Forms.Label();
            this.flp_Heart = new System.Windows.Forms.Panel();
            this.pb_Heart3 = new System.Windows.Forms.PictureBox();
            this.pb_Heart2 = new System.Windows.Forms.PictureBox();
            this.pb_Heart1 = new System.Windows.Forms.PictureBox();
            this.timeUpdateScore = new System.Windows.Forms.Timer(this.components);
            this.timerChallenge = new System.Windows.Forms.Timer(this.components);
            this.btn_ChallengeChoice = new System.Windows.Forms.Button();
            this.btn_SupportChoice = new System.Windows.Forms.Button();
            this.pb_TeamShirt = new System.Windows.Forms.PictureBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.flp_Heart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TeamName
            // 
            this.lbl_TeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TeamName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamName.ForeColor = System.Drawing.Color.Black;
            this.lbl_TeamName.Location = new System.Drawing.Point(21, 6);
            this.lbl_TeamName.Name = "lbl_TeamName";
            this.lbl_TeamName.Size = new System.Drawing.Size(222, 27);
            this.lbl_TeamName.TabIndex = 3;
            this.lbl_TeamName.Text = "a";
            this.lbl_TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TeamScore
            // 
            this.lbl_TeamScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TeamScore.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamScore.ForeColor = System.Drawing.Color.Black;
            this.lbl_TeamScore.Location = new System.Drawing.Point(21, 35);
            this.lbl_TeamScore.Name = "lbl_TeamScore";
            this.lbl_TeamScore.Size = new System.Drawing.Size(111, 42);
            this.lbl_TeamScore.TabIndex = 4;
            this.lbl_TeamScore.Text = "-100";
            this.lbl_TeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // flp_Heart
            // 
            this.flp_Heart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Heart.Controls.Add(this.pb_Heart3);
            this.flp_Heart.Controls.Add(this.pb_Heart2);
            this.flp_Heart.Controls.Add(this.pb_Heart1);
            this.flp_Heart.Location = new System.Drawing.Point(135, 78);
            this.flp_Heart.Name = "flp_Heart";
            this.flp_Heart.Size = new System.Drawing.Size(107, 28);
            this.flp_Heart.TabIndex = 8;
            // 
            // pb_Heart3
            // 
            this.pb_Heart3.BackgroundImage = global::CapDemo.Properties.Resources.trai_tim_dung;
            this.pb_Heart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Heart3.Location = new System.Drawing.Point(77, 3);
            this.pb_Heart3.Name = "pb_Heart3";
            this.pb_Heart3.Size = new System.Drawing.Size(25, 20);
            this.pb_Heart3.TabIndex = 5;
            this.pb_Heart3.TabStop = false;
            // 
            // pb_Heart2
            // 
            this.pb_Heart2.BackgroundImage = global::CapDemo.Properties.Resources.trai_tim_dung;
            this.pb_Heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Heart2.Location = new System.Drawing.Point(40, 2);
            this.pb_Heart2.Name = "pb_Heart2";
            this.pb_Heart2.Size = new System.Drawing.Size(25, 20);
            this.pb_Heart2.TabIndex = 4;
            this.pb_Heart2.TabStop = false;
            // 
            // pb_Heart1
            // 
            this.pb_Heart1.BackgroundImage = global::CapDemo.Properties.Resources.trai_tim_dung;
            this.pb_Heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Heart1.Location = new System.Drawing.Point(4, 2);
            this.pb_Heart1.Name = "pb_Heart1";
            this.pb_Heart1.Size = new System.Drawing.Size(25, 20);
            this.pb_Heart1.TabIndex = 3;
            this.pb_Heart1.TabStop = false;
            // 
            // timeUpdateScore
            // 
            this.timeUpdateScore.Interval = 400;
            // 
            // timerChallenge
            // 
            this.timerChallenge.Interval = 350;
            this.timerChallenge.Tick += new System.EventHandler(this.timerChallenge_Tick);
            // 
            // btn_ChallengeChoice
            // 
            this.btn_ChallengeChoice.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_ChallengeChoice.BackgroundImage = global::CapDemo.Properties.Resources.Shields_0;
            this.btn_ChallengeChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChallengeChoice.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_ChallengeChoice.Location = new System.Drawing.Point(188, 34);
            this.btn_ChallengeChoice.Name = "btn_ChallengeChoice";
            this.btn_ChallengeChoice.Size = new System.Drawing.Size(54, 43);
            this.btn_ChallengeChoice.TabIndex = 10;
            this.btn_ChallengeChoice.TabStop = false;
            this.btn_ChallengeChoice.UseVisualStyleBackColor = false;
            // 
            // btn_SupportChoice
            // 
            this.btn_SupportChoice.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_SupportChoice.BackgroundImage = global::CapDemo.Properties.Resources.Support;
            this.btn_SupportChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SupportChoice.ForeColor = System.Drawing.Color.Black;
            this.btn_SupportChoice.Location = new System.Drawing.Point(132, 34);
            this.btn_SupportChoice.Name = "btn_SupportChoice";
            this.btn_SupportChoice.Size = new System.Drawing.Size(54, 43);
            this.btn_SupportChoice.TabIndex = 9;
            this.btn_SupportChoice.TabStop = false;
            this.btn_SupportChoice.UseVisualStyleBackColor = false;
            // 
            // pb_TeamShirt
            // 
            this.pb_TeamShirt.BackColor = System.Drawing.Color.White;
            this.pb_TeamShirt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_TeamShirt.Location = new System.Drawing.Point(7, 6);
            this.pb_TeamShirt.Name = "pb_TeamShirt";
            this.pb_TeamShirt.Size = new System.Drawing.Size(13, 101);
            this.pb_TeamShirt.TabIndex = 0;
            this.pb_TeamShirt.TabStop = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.BackColor = System.Drawing.Color.Red;
            this.lbl_Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Score.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.White;
            this.lbl_Score.Location = new System.Drawing.Point(21, 78);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(111, 29);
            this.lbl_Score.TabIndex = 11;
            this.lbl_Score.Text = "-100";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Score.Visible = false;
            // 
            // Team_AudienceScreeen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::CapDemo.Properties.Resources.team_into;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.btn_ChallengeChoice);
            this.Controls.Add(this.btn_SupportChoice);
            this.Controls.Add(this.flp_Heart);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_TeamScore);
            this.Controls.Add(this.lbl_TeamName);
            this.Controls.Add(this.pb_TeamShirt);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Team_AudienceScreeen";
            this.Size = new System.Drawing.Size(254, 112);
            this.flp_Heart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_TeamShirt;
        public System.Windows.Forms.PictureBox pb_Heart1;
        public System.Windows.Forms.PictureBox pb_Heart2;
        public System.Windows.Forms.PictureBox pb_Heart3;
        public System.Windows.Forms.Label lbl_TeamName;
        public System.Windows.Forms.Label lbl_TeamScore;
        public System.Windows.Forms.Timer timerHighLight;
        public System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.Button btn_SupportChoice;
        public System.Windows.Forms.Button btn_ChallengeChoice;
        public System.Windows.Forms.Timer timeUpdateScore;
        public System.Windows.Forms.Timer timerChallenge;
        public System.Windows.Forms.Panel flp_Heart;
        public System.Windows.Forms.Label lbl_Score;

    }
}
