namespace CapDemo.GUI.User_Controls
{
    partial class CreateQuestion
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
            this.gb_CreateQuestion = new System.Windows.Forms.GroupBox();
            this.pnl_LoadQuestion = new System.Windows.Forms.Panel();
            this.gb_QuestionType = new System.Windows.Forms.GroupBox();
            this.rad_ShortAnswer = new System.Windows.Forms.RadioButton();
            this.rad_MultiSelect = new System.Windows.Forms.RadioButton();
            this.rad_OnlyOneAnswer = new System.Windows.Forms.RadioButton();
            this.gb_CreateQuestion.SuspendLayout();
            this.gb_QuestionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_CreateQuestion
            // 
            this.gb_CreateQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_CreateQuestion.Controls.Add(this.pnl_LoadQuestion);
            this.gb_CreateQuestion.ForeColor = System.Drawing.Color.White;
            this.gb_CreateQuestion.Location = new System.Drawing.Point(14, 62);
            this.gb_CreateQuestion.Name = "gb_CreateQuestion";
            this.gb_CreateQuestion.Size = new System.Drawing.Size(801, 491);
            this.gb_CreateQuestion.TabIndex = 3;
            this.gb_CreateQuestion.TabStop = false;
            this.gb_CreateQuestion.Text = "Tạo câu hỏi";
            // 
            // pnl_LoadQuestion
            // 
            this.pnl_LoadQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_LoadQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_LoadQuestion.Location = new System.Drawing.Point(7, 20);
            this.pnl_LoadQuestion.Name = "pnl_LoadQuestion";
            this.pnl_LoadQuestion.Size = new System.Drawing.Size(788, 465);
            this.pnl_LoadQuestion.TabIndex = 0;
            // 
            // gb_QuestionType
            // 
            this.gb_QuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_QuestionType.BackColor = System.Drawing.Color.SteelBlue;
            this.gb_QuestionType.Controls.Add(this.rad_ShortAnswer);
            this.gb_QuestionType.Controls.Add(this.rad_MultiSelect);
            this.gb_QuestionType.Controls.Add(this.rad_OnlyOneAnswer);
            this.gb_QuestionType.ForeColor = System.Drawing.Color.White;
            this.gb_QuestionType.Location = new System.Drawing.Point(14, 3);
            this.gb_QuestionType.Name = "gb_QuestionType";
            this.gb_QuestionType.Size = new System.Drawing.Size(801, 57);
            this.gb_QuestionType.TabIndex = 2;
            this.gb_QuestionType.TabStop = false;
            this.gb_QuestionType.Text = "Chọn dạng câu hỏi";
            // 
            // rad_ShortAnswer
            // 
            this.rad_ShortAnswer.AutoSize = true;
            this.rad_ShortAnswer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ShortAnswer.Location = new System.Drawing.Point(511, 19);
            this.rad_ShortAnswer.Name = "rad_ShortAnswer";
            this.rad_ShortAnswer.Size = new System.Drawing.Size(124, 22);
            this.rad_ShortAnswer.TabIndex = 1;
            this.rad_ShortAnswer.Text = "Trả lời ngắn";
            this.rad_ShortAnswer.UseVisualStyleBackColor = true;
            this.rad_ShortAnswer.CheckedChanged += new System.EventHandler(this.rad_ShortAnswer_CheckedChanged);
            // 
            // rad_MultiSelect
            // 
            this.rad_MultiSelect.AutoSize = true;
            this.rad_MultiSelect.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_MultiSelect.Location = new System.Drawing.Point(342, 19);
            this.rad_MultiSelect.Name = "rad_MultiSelect";
            this.rad_MultiSelect.Size = new System.Drawing.Size(150, 22);
            this.rad_MultiSelect.TabIndex = 1;
            this.rad_MultiSelect.Text = "Tùy chọn nhiều";
            this.rad_MultiSelect.UseVisualStyleBackColor = true;
            this.rad_MultiSelect.CheckedChanged += new System.EventHandler(this.rad_MultiSelect_CheckedChanged);
            // 
            // rad_OnlyOneAnswer
            // 
            this.rad_OnlyOneAnswer.AutoSize = true;
            this.rad_OnlyOneAnswer.Checked = true;
            this.rad_OnlyOneAnswer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_OnlyOneAnswer.Location = new System.Drawing.Point(181, 19);
            this.rad_OnlyOneAnswer.Name = "rad_OnlyOneAnswer";
            this.rad_OnlyOneAnswer.Size = new System.Drawing.Size(137, 22);
            this.rad_OnlyOneAnswer.TabIndex = 0;
            this.rad_OnlyOneAnswer.TabStop = true;
            this.rad_OnlyOneAnswer.Text = "Tùy chọn một";
            this.rad_OnlyOneAnswer.UseVisualStyleBackColor = true;
            this.rad_OnlyOneAnswer.CheckedChanged += new System.EventHandler(this.rad_OnlyOneAnswer_CheckedChanged);
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.gb_CreateQuestion);
            this.Controls.Add(this.gb_QuestionType);
            this.Name = "CreateQuestion";
            this.Size = new System.Drawing.Size(830, 565);
            this.Load += new System.EventHandler(this.CreateQuestion_Load);
            this.gb_CreateQuestion.ResumeLayout(false);
            this.gb_QuestionType.ResumeLayout(false);
            this.gb_QuestionType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CreateQuestion;
        private System.Windows.Forms.Panel pnl_LoadQuestion;
        private System.Windows.Forms.GroupBox gb_QuestionType;
        private System.Windows.Forms.RadioButton rad_ShortAnswer;
        private System.Windows.Forms.RadioButton rad_MultiSelect;
        private System.Windows.Forms.RadioButton rad_OnlyOneAnswer;
    }
}
