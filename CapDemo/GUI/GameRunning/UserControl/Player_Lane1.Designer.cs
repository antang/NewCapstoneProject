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
            this.timeHightLight = new System.Windows.Forms.Timer(this.components);
            this.lbl_Finish = new System.Windows.Forms.Label();
            this.btn_Team = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_IDPlayer
            // 
            this.lbl_IDPlayer.AutoSize = true;
            this.lbl_IDPlayer.Location = new System.Drawing.Point(9, 4);
            this.lbl_IDPlayer.Name = "lbl_IDPlayer";
            this.lbl_IDPlayer.Size = new System.Drawing.Size(0, 13);
            this.lbl_IDPlayer.TabIndex = 2;
            this.lbl_IDPlayer.Visible = false;
            // 
            // lbl_SequencePlayer
            // 
            this.lbl_SequencePlayer.AutoSize = true;
            this.lbl_SequencePlayer.Location = new System.Drawing.Point(4, 4);
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
            // timeHightLight
            // 
            this.timeHightLight.Tick += new System.EventHandler(this.timeHightLight_Tick);
            // 
            // lbl_Finish
            // 
            this.lbl_Finish.Image = global::CapDemo.Properties.Resources.Screen_pnl_FinishLane;
            this.lbl_Finish.Location = new System.Drawing.Point(0, 50);
            this.lbl_Finish.Name = "lbl_Finish";
            this.lbl_Finish.Size = new System.Drawing.Size(102, 20);
            this.lbl_Finish.TabIndex = 8;
            // 
            // btn_Team
            // 
            this.btn_Team.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Team.BackColor = System.Drawing.Color.Black;
            this.btn_Team.Location = new System.Drawing.Point(31, 607);
            this.btn_Team.Name = "btn_Team";
            this.btn_Team.Size = new System.Drawing.Size(40, 45);
            this.btn_Team.TabIndex = 9;
            this.btn_Team.TabStop = false;
            this.btn_Team.UseVisualStyleBackColor = false;
            // 
            // Player_Lane1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Team);
            this.Controls.Add(this.lbl_Finish);
            this.Controls.Add(this.lbl_SequencePlayer);
            this.Controls.Add(this.lbl_IDPlayer);
            this.Name = "Player_Lane1";
            this.Size = new System.Drawing.Size(102, 652);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_IDPlayer;
        public System.Windows.Forms.Label lbl_SequencePlayer;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Timer timeHightLight;
        public System.Windows.Forms.Label lbl_Finish;
        public System.Windows.Forms.Button btn_Team;
    }
}
