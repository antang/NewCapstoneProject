namespace CapDemo.GUI.User_Controls
{
    partial class View_Answer_ShortAnswer
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
            this.txt_Answercontent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Answercontent
            // 
            this.txt_Answercontent.Location = new System.Drawing.Point(14, 3);
            this.txt_Answercontent.Multiline = true;
            this.txt_Answercontent.Name = "txt_Answercontent";
            this.txt_Answercontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Answercontent.Size = new System.Drawing.Size(309, 50);
            this.txt_Answercontent.TabIndex = 18;
            // 
            // View_Answer_ShortAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Answercontent);
            this.Name = "View_Answer_ShortAnswer";
            this.Size = new System.Drawing.Size(338, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_Answercontent;
    }
}
