namespace CapDemo.GUI.User_Controls
{
    partial class View_Answer_OnlyOneSelect
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
            this.rad_check = new System.Windows.Forms.RadioButton();
            this.txt_Answercontent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rad_check
            // 
            this.rad_check.AutoSize = true;
            this.rad_check.Location = new System.Drawing.Point(3, 20);
            this.rad_check.Name = "rad_check";
            this.rad_check.Size = new System.Drawing.Size(14, 13);
            this.rad_check.TabIndex = 15;
            this.rad_check.TabStop = true;
            this.rad_check.UseVisualStyleBackColor = true;
            // 
            // txt_Answercontent
            // 
            this.txt_Answercontent.Location = new System.Drawing.Point(41, 5);
            this.txt_Answercontent.Multiline = true;
            this.txt_Answercontent.Name = "txt_Answercontent";
            this.txt_Answercontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Answercontent.Size = new System.Drawing.Size(270, 50);
            this.txt_Answercontent.TabIndex = 13;
            // 
            // View_Answer_OnlyOneSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rad_check);
            this.Controls.Add(this.txt_Answercontent);
            this.Name = "View_Answer_OnlyOneSelect";
            this.Size = new System.Drawing.Size(338, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rad_check;
        public System.Windows.Forms.TextBox txt_Answercontent;
    }
}
