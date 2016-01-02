namespace CapDemo
{
    partial class Player_Lane1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_Lane1));
            this.lbl_IDPlayer = new System.Windows.Forms.Label();
            this.lbl_SequencePlayer = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pb_Team = new System.Windows.Forms.PictureBox();
            this.timeHightLight = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Team)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IDPlayer
            // 
            this.lbl_IDPlayer.AutoSize = true;
            this.lbl_IDPlayer.Location = new System.Drawing.Point(105, 9);
            this.lbl_IDPlayer.Name = "lbl_IDPlayer";
            this.lbl_IDPlayer.Size = new System.Drawing.Size(0, 13);
            this.lbl_IDPlayer.TabIndex = 2;
            this.lbl_IDPlayer.Visible = false;
            // 
            // lbl_SequencePlayer
            // 
            this.lbl_SequencePlayer.AutoSize = true;
            this.lbl_SequencePlayer.Location = new System.Drawing.Point(4, 10);
            this.lbl_SequencePlayer.Name = "lbl_SequencePlayer";
            this.lbl_SequencePlayer.Size = new System.Drawing.Size(0, 13);
            this.lbl_SequencePlayer.TabIndex = 3;
            this.lbl_SequencePlayer.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ao-lon.png");
            this.imageList1.Images.SetKeyName(1, "ao-nho.png");
            // 
            // pb_Team
            // 
            this.pb_Team.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pb_Team.BackColor = System.Drawing.Color.Maroon;
            this.pb_Team.BackgroundImage = global::CapDemo.Properties.Resources.ao_nho;
            this.pb_Team.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Team.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Team.Location = new System.Drawing.Point(44, 500);
            this.pb_Team.Name = "pb_Team";
            this.pb_Team.Size = new System.Drawing.Size(39, 45);
            this.pb_Team.TabIndex = 7;
            this.pb_Team.TabStop = false;
            // 
            // timeHightLight
            // 
            this.timeHightLight.Tick += new System.EventHandler(this.timeHightLight_Tick);
            // 
            // Player_Lane1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pb_Team);
            this.Controls.Add(this.lbl_SequencePlayer);
            this.Controls.Add(this.lbl_IDPlayer);
            this.Name = "Player_Lane1";
            this.Size = new System.Drawing.Size(150, 553);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Team)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_IDPlayer;
        public System.Windows.Forms.Label lbl_SequencePlayer;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.PictureBox pb_Team;
        public System.Windows.Forms.Timer timeHightLight;
    }
}
