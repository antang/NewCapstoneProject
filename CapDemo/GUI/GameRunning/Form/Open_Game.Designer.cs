namespace CapDemo
{
    partial class Open_Game
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
            this.components = new System.ComponentModel.Container();
            this.flp_Team = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.pb_Play = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_Team
            // 
            this.flp_Team.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Team.AutoScroll = true;
            this.flp_Team.BackColor = System.Drawing.Color.Transparent;
            this.flp_Team.Location = new System.Drawing.Point(0, 0);
            this.flp_Team.Name = "flp_Team";
            this.flp_Team.Size = new System.Drawing.Size(1024, 350);
            this.flp_Team.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Location = new System.Drawing.Point(189, 435);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(807, 42);
            this.lbl_Time.TabIndex = 12;
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wait time:";
            // 
            // lblHint
            // 
            this.lblHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.SeaShell;
            this.lblHint.Location = new System.Drawing.Point(0, 708);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(984, 16);
            this.lblHint.TabIndex = 13;
            this.lblHint.Text = "Hint";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pb_Play
            // 
            this.pb_Play.BackColor = System.Drawing.Color.Transparent;
            this.pb_Play.BackgroundImage = global::CapDemo.Properties.Resources.PlayGame;
            this.pb_Play.Location = new System.Drawing.Point(880, 577);
            this.pb_Play.Name = "pb_Play";
            this.pb_Play.Size = new System.Drawing.Size(128, 128);
            this.pb_Play.TabIndex = 14;
            this.pb_Play.TabStop = false;
            this.pb_Play.Click += new System.EventHandler(this.pb_Play_Click);
            // 
            // pb_Exit
            // 
            this.pb_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_Exit.BackgroundImage = global::CapDemo.Properties.Resources.Button_Close;
            this.pb_Exit.Location = new System.Drawing.Point(3, 577);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(128, 128);
            this.pb_Exit.TabIndex = 15;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // Open_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::CapDemo.Properties.Resources.Hinh_nen;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pb_Exit);
            this.Controls.Add(this.pb_Play);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flp_Team);
            this.Name = "Open_Game";
            this.Text = "Open_Game";
            this.Load += new System.EventHandler(this.Open_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Team;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.PictureBox pb_Play;
        private System.Windows.Forms.PictureBox pb_Exit;
    }
}