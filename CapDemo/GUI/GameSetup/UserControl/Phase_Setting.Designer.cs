namespace CapDemo.GUI.User_Controls
{
    partial class Phase_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phase_Setting));
            this.btn_AddPhase = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flp_Phase = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_AddPhase
            // 
            this.btn_AddPhase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_AddPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPhase.ForeColor = System.Drawing.Color.Navy;
            this.btn_AddPhase.ImageIndex = 0;
            this.btn_AddPhase.ImageList = this.imageList1;
            this.btn_AddPhase.Location = new System.Drawing.Point(20, 18);
            this.btn_AddPhase.Name = "btn_AddPhase";
            this.btn_AddPhase.Size = new System.Drawing.Size(200, 35);
            this.btn_AddPhase.TabIndex = 0;
            this.btn_AddPhase.Text = "+ Thêm giai đoạn";
            this.btn_AddPhase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddPhase.UseVisualStyleBackColor = false;
            this.btn_AddPhase.Click += new System.EventHandler(this.btn_AddPhase_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            // 
            // flp_Phase
            // 
            this.flp_Phase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Phase.AutoScroll = true;
            this.flp_Phase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Phase.Location = new System.Drawing.Point(20, 60);
            this.flp_Phase.Name = "flp_Phase";
            this.flp_Phase.Size = new System.Drawing.Size(707, 401);
            this.flp_Phase.TabIndex = 1;
            // 
            // Phase_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_Phase);
            this.Controls.Add(this.btn_AddPhase);
            this.Name = "Phase_Setting";
            this.Size = new System.Drawing.Size(748, 480);
            this.Load += new System.EventHandler(this.Phase_Setting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.FlowLayoutPanel flp_Phase;
        public System.Windows.Forms.Button btn_AddPhase;
    }
}
