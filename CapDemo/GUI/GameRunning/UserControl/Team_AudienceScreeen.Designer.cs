﻿namespace CapDemo
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
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_ChallengeChoice = new System.Windows.Forms.Button();
            this.btn_SupportChoice = new System.Windows.Forms.Button();
            this.pb_Heart3 = new System.Windows.Forms.PictureBox();
            this.pb_Heart2 = new System.Windows.Forms.PictureBox();
            this.pb_Heart1 = new System.Windows.Forms.PictureBox();
            this.pb_TeamShirt = new System.Windows.Forms.PictureBox();
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
            this.lbl_TeamName.Location = new System.Drawing.Point(126, 7);
            this.lbl_TeamName.Name = "lbl_TeamName";
            this.lbl_TeamName.Size = new System.Drawing.Size(168, 37);
            this.lbl_TeamName.TabIndex = 3;
            this.lbl_TeamName.Text = "Name";
            this.lbl_TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TeamScore
            // 
            this.lbl_TeamScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TeamScore.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamScore.Location = new System.Drawing.Point(4, 46);
            this.lbl_TeamScore.Name = "lbl_TeamScore";
            this.lbl_TeamScore.Size = new System.Drawing.Size(122, 67);
            this.lbl_TeamScore.TabIndex = 4;
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
            this.flp_Heart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Heart.Controls.Add(this.pb_Heart3);
            this.flp_Heart.Controls.Add(this.pb_Heart2);
            this.flp_Heart.Controls.Add(this.pb_Heart1);
            this.flp_Heart.Location = new System.Drawing.Point(126, 114);
            this.flp_Heart.Name = "flp_Heart";
            this.flp_Heart.Size = new System.Drawing.Size(167, 52);
            this.flp_Heart.TabIndex = 8;
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Stop.Location = new System.Drawing.Point(3, 113);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(123, 53);
            this.btn_Stop.TabIndex = 11;
            this.btn_Stop.UseVisualStyleBackColor = false;
            // 
            // btn_ChallengeChoice
            // 
            this.btn_ChallengeChoice.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_ChallengeChoice.BackgroundImage = global::CapDemo.Properties.Resources.Shields_0;
            this.btn_ChallengeChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChallengeChoice.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_ChallengeChoice.Location = new System.Drawing.Point(210, 44);
            this.btn_ChallengeChoice.Name = "btn_ChallengeChoice";
            this.btn_ChallengeChoice.Size = new System.Drawing.Size(84, 71);
            this.btn_ChallengeChoice.TabIndex = 10;
            this.btn_ChallengeChoice.UseVisualStyleBackColor = false;
            // 
            // btn_SupportChoice
            // 
            this.btn_SupportChoice.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_SupportChoice.BackgroundImage = global::CapDemo.Properties.Resources.Support;
            this.btn_SupportChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SupportChoice.ForeColor = System.Drawing.Color.Black;
            this.btn_SupportChoice.Location = new System.Drawing.Point(126, 44);
            this.btn_SupportChoice.Name = "btn_SupportChoice";
            this.btn_SupportChoice.Size = new System.Drawing.Size(86, 71);
            this.btn_SupportChoice.TabIndex = 9;
            this.btn_SupportChoice.UseVisualStyleBackColor = false;
            // 
            // pb_Heart3
            // 
            this.pb_Heart3.BackgroundImage = global::CapDemo.Properties.Resources.trai_tim_dung;
            this.pb_Heart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Heart3.Location = new System.Drawing.Point(122, 8);
            this.pb_Heart3.Name = "pb_Heart3";
            this.pb_Heart3.Size = new System.Drawing.Size(30, 31);
            this.pb_Heart3.TabIndex = 5;
            this.pb_Heart3.TabStop = false;
            // 
            // pb_Heart2
            // 
            this.pb_Heart2.BackgroundImage = global::CapDemo.Properties.Resources.trai_tim_dung;
            this.pb_Heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Heart2.Location = new System.Drawing.Point(70, 8);
            this.pb_Heart2.Name = "pb_Heart2";
            this.pb_Heart2.Size = new System.Drawing.Size(30, 31);
            this.pb_Heart2.TabIndex = 4;
            this.pb_Heart2.TabStop = false;
            // 
            // pb_Heart1
            // 
            this.pb_Heart1.BackgroundImage = global::CapDemo.Properties.Resources.trai_tim_dung;
            this.pb_Heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Heart1.Location = new System.Drawing.Point(18, 8);
            this.pb_Heart1.Name = "pb_Heart1";
            this.pb_Heart1.Size = new System.Drawing.Size(30, 31);
            this.pb_Heart1.TabIndex = 3;
            this.pb_Heart1.TabStop = false;
            // 
            // pb_TeamShirt
            // 
            this.pb_TeamShirt.BackColor = System.Drawing.Color.White;
            this.pb_TeamShirt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_TeamShirt.Location = new System.Drawing.Point(4, 7);
            this.pb_TeamShirt.Name = "pb_TeamShirt";
            this.pb_TeamShirt.Size = new System.Drawing.Size(122, 37);
            this.pb_TeamShirt.TabIndex = 0;
            this.pb_TeamShirt.TabStop = false;
            // 
            // Team_AudienceScreeen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_ChallengeChoice);
            this.Controls.Add(this.btn_SupportChoice);
            this.Controls.Add(this.flp_Heart);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_TeamScore);
            this.Controls.Add(this.lbl_TeamName);
            this.Controls.Add(this.pb_TeamShirt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Team_AudienceScreeen";
            this.Size = new System.Drawing.Size(300, 170);
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
        private System.Windows.Forms.Panel flp_Heart;
        public System.Windows.Forms.Button btn_SupportChoice;
        public System.Windows.Forms.Button btn_ChallengeChoice;
        public System.Windows.Forms.Button btn_Stop;

    }
}
