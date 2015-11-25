namespace CapDemo.GUI.User_Controls
{
    partial class Team_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Team_Setting));
            this.flp_Team = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_AddPhase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_Team
            // 
            this.flp_Team.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Team.AutoScroll = true;
            this.flp_Team.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Team.Location = new System.Drawing.Point(21, 61);
            this.flp_Team.Name = "flp_Team";
            this.flp_Team.Size = new System.Drawing.Size(707, 401);
            this.flp_Team.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            // 
            // btn_AddPhase
            // 
            this.btn_AddPhase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_AddPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPhase.ForeColor = System.Drawing.Color.Navy;
            this.btn_AddPhase.ImageIndex = 0;
            this.btn_AddPhase.ImageList = this.imageList1;
            this.btn_AddPhase.Location = new System.Drawing.Point(21, 19);
            this.btn_AddPhase.Name = "btn_AddPhase";
            this.btn_AddPhase.Size = new System.Drawing.Size(200, 35);
            this.btn_AddPhase.TabIndex = 2;
            this.btn_AddPhase.Text = "+ Thêm đội thi";
            this.btn_AddPhase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddPhase.UseVisualStyleBackColor = false;
            this.btn_AddPhase.Click += new System.EventHandler(this.btn_AddPhase_Click);
            // 
            // Team_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_Team);
            this.Controls.Add(this.btn_AddPhase);
            this.Name = "Team_Setting";
            this.Size = new System.Drawing.Size(748, 480);
            this.Load += new System.EventHandler(this.Team_Setting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Team;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_AddPhase;
    }
}
