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
            this.lbl_NamePhase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_NamePhase
            // 
            this.lbl_NamePhase.AutoSize = true;
            this.lbl_NamePhase.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NamePhase.Location = new System.Drawing.Point(3, 9);
            this.lbl_NamePhase.Name = "lbl_NamePhase";
            this.lbl_NamePhase.Size = new System.Drawing.Size(58, 18);
            this.lbl_NamePhase.TabIndex = 0;
            this.lbl_NamePhase.Text = "label1";
            // 
            // Phase_Lane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.lbl_NamePhase);
            this.Name = "Phase_Lane";
            this.Size = new System.Drawing.Size(98, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_NamePhase;

    }
}
