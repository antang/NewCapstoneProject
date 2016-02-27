namespace CapDemo
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
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.lbl_Correct = new System.Windows.Forms.Label();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.lbl_labelAnswer = new System.Windows.Forms.Label();
            this.rtxt_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.Location = new System.Drawing.Point(21, 93);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(0, 13);
            this.lbl_Answer.TabIndex = 2;
            this.lbl_Answer.Visible = false;
            // 
            // lbl_Correct
            // 
            this.lbl_Correct.AutoSize = true;
            this.lbl_Correct.Location = new System.Drawing.Point(41, 96);
            this.lbl_Correct.Name = "lbl_Correct";
            this.lbl_Correct.Size = new System.Drawing.Size(0, 13);
            this.lbl_Correct.TabIndex = 4;
            this.lbl_Correct.Visible = false;
            // 
            // rdb1
            // 
            this.rdb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdb1.AutoSize = true;
            this.rdb1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb1.Location = new System.Drawing.Point(2, 92);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(14, 13);
            this.rdb1.TabIndex = 5;
            this.rdb1.TabStop = true;
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.Visible = false;
            // 
            // chk1
            // 
            this.chk1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chk1.AutoSize = true;
            this.chk1.BackColor = System.Drawing.Color.White;
            this.chk1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1.Location = new System.Drawing.Point(1, 98);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(15, 14);
            this.chk1.TabIndex = 6;
            this.chk1.UseVisualStyleBackColor = false;
            this.chk1.Visible = false;
            // 
            // lbl_labelAnswer
            // 
            this.lbl_labelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_labelAnswer.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_labelAnswer.ForeColor = System.Drawing.Color.White;
            this.lbl_labelAnswer.Location = new System.Drawing.Point(0, 0);
            this.lbl_labelAnswer.Name = "lbl_labelAnswer";
            this.lbl_labelAnswer.Size = new System.Drawing.Size(49, 44);
            this.lbl_labelAnswer.TabIndex = 7;
            this.lbl_labelAnswer.Text = "A:";
            // 
            // rtxt_Answer
            // 
            this.rtxt_Answer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxt_Answer.BackColor = System.Drawing.Color.Transparent;
            this.rtxt_Answer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_Answer.ForeColor = System.Drawing.Color.White;
            this.rtxt_Answer.Location = new System.Drawing.Point(84, 9);
            this.rtxt_Answer.Name = "rtxt_Answer";
            this.rtxt_Answer.Size = new System.Drawing.Size(340, 96);
            this.rtxt_Answer.TabIndex = 8;
            this.rtxt_Answer.Text = "abc\r\nabc\r\nabc\r\nabc\r\nabc\r\nabc\r\nabc\r\nabc";
            this.rtxt_Answer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::CapDemo.Properties.Resources.Answer_M;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.rtxt_Answer);
            this.Controls.Add(this.lbl_labelAnswer);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.lbl_Correct);
            this.Controls.Add(this.lbl_Answer);
            this.DoubleBuffered = true;
            this.Name = "ShowAnswer";
            this.Size = new System.Drawing.Size(474, 117);
            this.Load += new System.EventHandler(this.ShowAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Answer;
        public System.Windows.Forms.Label lbl_Correct;
        public System.Windows.Forms.RadioButton rdb1;
        public System.Windows.Forms.CheckBox chk1;
        public System.Windows.Forms.Label lbl_labelAnswer;
        public System.Windows.Forms.Label rtxt_Answer;
    }
}
