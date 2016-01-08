namespace CapDemo
{
    partial class Phase_Lane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phase_Lane));
            this.lbl_NamePhase = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lbl_NamePhase
            // 
            this.lbl_NamePhase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NamePhase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NamePhase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NamePhase.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NamePhase.ForeColor = System.Drawing.Color.Black;
            this.lbl_NamePhase.ImageIndex = 0;
            this.lbl_NamePhase.Location = new System.Drawing.Point(0, 0);
            this.lbl_NamePhase.Name = "lbl_NamePhase";
            this.lbl_NamePhase.Size = new System.Drawing.Size(81, 38);
            this.lbl_NamePhase.TabIndex = 0;
            this.lbl_NamePhase.Text = "label1";
            this.lbl_NamePhase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "khung-vong-thi.png");
            // 
            // Phase_Lane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_NamePhase);
            this.Name = "Phase_Lane";
            this.Size = new System.Drawing.Size(96, 38);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_NamePhase;
        private System.Windows.Forms.ImageList imageList1;

    }
}
