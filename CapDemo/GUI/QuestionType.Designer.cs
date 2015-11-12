namespace CapDemo.GUI
{
    partial class QuestionType
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
            this.flp_ContentQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.rad_ShortAnswer = new System.Windows.Forms.RadioButton();
            this.rad_OneChoice = new System.Windows.Forms.RadioButton();
            this.rad_MultipleChoice = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_ContentQuestion
            // 
            this.flp_ContentQuestion.AutoScroll = true;
            this.flp_ContentQuestion.Location = new System.Drawing.Point(11, 66);
            this.flp_ContentQuestion.Name = "flp_ContentQuestion";
            this.flp_ContentQuestion.Size = new System.Drawing.Size(624, 358);
            this.flp_ContentQuestion.TabIndex = 6;
            // 
            // rad_ShortAnswer
            // 
            this.rad_ShortAnswer.AutoSize = true;
            this.rad_ShortAnswer.Location = new System.Drawing.Point(381, 19);
            this.rad_ShortAnswer.Name = "rad_ShortAnswer";
            this.rad_ShortAnswer.Size = new System.Drawing.Size(82, 17);
            this.rad_ShortAnswer.TabIndex = 2;
            this.rad_ShortAnswer.TabStop = true;
            this.rad_ShortAnswer.Text = "Điền khuyết";
            this.rad_ShortAnswer.UseVisualStyleBackColor = true;
            // 
            // rad_OneChoice
            // 
            this.rad_OneChoice.AutoSize = true;
            this.rad_OneChoice.Location = new System.Drawing.Point(10, 19);
            this.rad_OneChoice.Name = "rad_OneChoice";
            this.rad_OneChoice.Size = new System.Drawing.Size(90, 17);
            this.rad_OneChoice.TabIndex = 0;
            this.rad_OneChoice.TabStop = true;
            this.rad_OneChoice.Text = "Tùy chọn một";
            this.rad_OneChoice.UseVisualStyleBackColor = true;
            this.rad_OneChoice.CheckedChanged += new System.EventHandler(this.rad_OneChoice_CheckedChanged);
            // 
            // rad_MultipleChoice
            // 
            this.rad_MultipleChoice.AutoSize = true;
            this.rad_MultipleChoice.Location = new System.Drawing.Point(186, 19);
            this.rad_MultipleChoice.Name = "rad_MultipleChoice";
            this.rad_MultipleChoice.Size = new System.Drawing.Size(99, 17);
            this.rad_MultipleChoice.TabIndex = 1;
            this.rad_MultipleChoice.TabStop = true;
            this.rad_MultipleChoice.Text = "Tùy chọn nhiều";
            this.rad_MultipleChoice.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_ShortAnswer);
            this.groupBox1.Controls.Add(this.rad_OneChoice);
            this.groupBox1.Controls.Add(this.rad_MultipleChoice);
            this.groupBox1.Location = new System.Drawing.Point(24, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // QuestionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_ContentQuestion);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuestionType";
            this.Size = new System.Drawing.Size(638, 433);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_ContentQuestion;
        private System.Windows.Forms.RadioButton rad_ShortAnswer;
        private System.Windows.Forms.RadioButton rad_OneChoice;
        private System.Windows.Forms.RadioButton rad_MultipleChoice;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
