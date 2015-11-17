namespace CapDemo.GUI.User_Controls
{
    partial class View_Answer_MultiSelect
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
            this.chk_Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_Answercontent
            // 
            this.txt_Answercontent.Location = new System.Drawing.Point(53, 3);
            this.txt_Answercontent.Multiline = true;
            this.txt_Answercontent.Name = "txt_Answercontent";
            this.txt_Answercontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Answercontent.Size = new System.Drawing.Size(270, 50);
            this.txt_Answercontent.TabIndex = 16;
            // 
            // chk_Check
            // 
            this.chk_Check.AutoSize = true;
            this.chk_Check.Location = new System.Drawing.Point(16, 22);
            this.chk_Check.Name = "chk_Check";
            this.chk_Check.Size = new System.Drawing.Size(15, 14);
            this.chk_Check.TabIndex = 17;
            this.chk_Check.UseVisualStyleBackColor = true;
            // 
            // View_Answer_MultiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_Check);
            this.Controls.Add(this.txt_Answercontent);
            this.Name = "View_Answer_MultiSelect";
            this.Size = new System.Drawing.Size(338, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_Answercontent;
        private System.Windows.Forms.CheckBox chk_Check;
    }
}
