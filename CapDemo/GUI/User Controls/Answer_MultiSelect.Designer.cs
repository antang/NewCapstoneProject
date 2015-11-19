namespace CapDemo.GUI.User_Controls
{
    partial class Answer_MultiSelect
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
            this.btn_DelAnswer = new System.Windows.Forms.Button();
            this.txt_AnswerContent = new System.Windows.Forms.TextBox();
            this.chk_Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_DelAnswer
            // 
            this.btn_DelAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DelAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DelAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelAnswer.ForeColor = System.Drawing.Color.White;
            this.btn_DelAnswer.Location = new System.Drawing.Point(338, 1);
            this.btn_DelAnswer.Name = "btn_DelAnswer";
            this.btn_DelAnswer.Size = new System.Drawing.Size(23, 23);
            this.btn_DelAnswer.TabIndex = 5;
            this.btn_DelAnswer.Text = "X";
            this.btn_DelAnswer.UseVisualStyleBackColor = false;
            this.btn_DelAnswer.Click += new System.EventHandler(this.btn_DelAnswer_Click);
            // 
            // txt_AnswerContent
            // 
            this.txt_AnswerContent.Location = new System.Drawing.Point(40, 3);
            this.txt_AnswerContent.Multiline = true;
            this.txt_AnswerContent.Name = "txt_AnswerContent";
            this.txt_AnswerContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_AnswerContent.Size = new System.Drawing.Size(292, 50);
            this.txt_AnswerContent.TabIndex = 4;
            // 
            // chk_Check
            // 
            this.chk_Check.AutoSize = true;
            this.chk_Check.ForeColor = System.Drawing.Color.Black;
            this.chk_Check.Location = new System.Drawing.Point(3, 5);
            this.chk_Check.Name = "chk_Check";
            this.chk_Check.Size = new System.Drawing.Size(15, 14);
            this.chk_Check.TabIndex = 3;
            this.chk_Check.UseVisualStyleBackColor = true;
            this.chk_Check.CheckedChanged += new System.EventHandler(this.rad_Check_CheckedChanged);
            // 
            // Answer_MultiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_DelAnswer);
            this.Controls.Add(this.txt_AnswerContent);
            this.Controls.Add(this.chk_Check);
            this.Name = "Answer_MultiSelect";
            this.Size = new System.Drawing.Size(364, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chk_Check;
        public System.Windows.Forms.TextBox txt_AnswerContent;
        public System.Windows.Forms.Button btn_DelAnswer;

    }
}
