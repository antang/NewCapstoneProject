namespace CapDemo
{
    partial class shortanswer
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
            this.txt_ShortAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_ShortAnswer
            // 
            this.txt_ShortAnswer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShortAnswer.Location = new System.Drawing.Point(0, 0);
            this.txt_ShortAnswer.Name = "txt_ShortAnswer";
            this.txt_ShortAnswer.Size = new System.Drawing.Size(180, 31);
            this.txt_ShortAnswer.TabIndex = 0;
            // 
            // shortanswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_ShortAnswer);
            this.Name = "shortanswer";
            this.Size = new System.Drawing.Size(190, 30);
            this.Load += new System.EventHandler(this.shortanswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_ShortAnswer;
    }
}
