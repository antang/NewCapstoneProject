﻿namespace CapDemo
{
    partial class ShowAnswer
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
            this.rtxt_Answer = new System.Windows.Forms.RichTextBox();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.lbl_Correct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxt_Answer
            // 
            this.rtxt_Answer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_Answer.Location = new System.Drawing.Point(50, 6);
            this.rtxt_Answer.Name = "rtxt_Answer";
            this.rtxt_Answer.Size = new System.Drawing.Size(403, 45);
            this.rtxt_Answer.TabIndex = 3;
            this.rtxt_Answer.Text = "";
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.Location = new System.Drawing.Point(3, 6);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(41, 13);
            this.lbl_Answer.TabIndex = 2;
            this.lbl_Answer.Text = "label1";
            // 
            // lbl_Correct
            // 
            this.lbl_Correct.AutoSize = true;
            this.lbl_Correct.Location = new System.Drawing.Point(6, 40);
            this.lbl_Correct.Name = "lbl_Correct";
            this.lbl_Correct.Size = new System.Drawing.Size(35, 13);
            this.lbl_Correct.TabIndex = 4;
            this.lbl_Correct.Text = "label1";
            this.lbl_Correct.Visible = false;
            // 
            // ShowAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Correct);
            this.Controls.Add(this.rtxt_Answer);
            this.Controls.Add(this.lbl_Answer);
            this.Name = "ShowAnswer";
            this.Size = new System.Drawing.Size(456, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtxt_Answer;
        public System.Windows.Forms.Label lbl_Answer;
        public System.Windows.Forms.Label lbl_Correct;
    }
}
