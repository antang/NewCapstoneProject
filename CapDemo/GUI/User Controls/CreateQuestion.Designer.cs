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
            this.grpTaoCauHoi = new System.Windows.Forms.GroupBox();
            this.pnl_LoadQuestion = new System.Windows.Forms.Panel();
            this.grpChonDangCauHoi = new System.Windows.Forms.GroupBox();
            this.rdo_ShortAnswer = new System.Windows.Forms.RadioButton();
            this.rdo_MultiSelect = new System.Windows.Forms.RadioButton();
            this.rdo_OnlyOneAnswer = new System.Windows.Forms.RadioButton();
            this.grpTaoCauHoi.SuspendLayout();
            this.grpChonDangCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTaoCauHoi
            // 
            this.grpTaoCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTaoCauHoi.Controls.Add(this.pnl_LoadQuestion);
            this.grpTaoCauHoi.ForeColor = System.Drawing.Color.White;
            this.grpTaoCauHoi.Location = new System.Drawing.Point(14, 62);
            this.grpTaoCauHoi.Name = "grpTaoCauHoi";
            this.grpTaoCauHoi.Size = new System.Drawing.Size(801, 491);
            this.grpTaoCauHoi.TabIndex = 3;
            this.grpTaoCauHoi.TabStop = false;
            this.grpTaoCauHoi.Text = "Tạo câu hỏi";
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
            // grpChonDangCauHoi
            // 
            this.grpChonDangCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChonDangCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpChonDangCauHoi.Controls.Add(this.rdo_ShortAnswer);
            this.grpChonDangCauHoi.Controls.Add(this.rdo_MultiSelect);
            this.grpChonDangCauHoi.Controls.Add(this.rdo_OnlyOneAnswer);
            this.grpChonDangCauHoi.ForeColor = System.Drawing.Color.White;
            this.grpChonDangCauHoi.Location = new System.Drawing.Point(14, 3);
            this.grpChonDangCauHoi.Name = "grpChonDangCauHoi";
            this.grpChonDangCauHoi.Size = new System.Drawing.Size(801, 57);
            this.grpChonDangCauHoi.TabIndex = 2;
            this.grpChonDangCauHoi.TabStop = false;
            this.grpChonDangCauHoi.Text = "Chọn dạng câu hỏi";
            // 
            // rdo_ShortAnswer
            // 
            this.rdo_ShortAnswer.AutoSize = true;
            this.rdo_ShortAnswer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_ShortAnswer.Location = new System.Drawing.Point(511, 19);
            this.rdo_ShortAnswer.Name = "rdo_ShortAnswer";
            this.rdo_ShortAnswer.Size = new System.Drawing.Size(113, 23);
            this.rdo_ShortAnswer.TabIndex = 1;
            this.rdo_ShortAnswer.Text = "Trả lời ngắn";
            this.rdo_ShortAnswer.UseVisualStyleBackColor = true;
            this.rdo_ShortAnswer.CheckedChanged += new System.EventHandler(this.rdo_ShortAnswer_CheckedChanged);
            // 
            // rdo_MultiSelect
            // 
            this.rdo_MultiSelect.AutoSize = true;
            this.rdo_MultiSelect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MultiSelect.Location = new System.Drawing.Point(342, 19);
            this.rdo_MultiSelect.Name = "rdo_MultiSelect";
            this.rdo_MultiSelect.Size = new System.Drawing.Size(137, 23);
            this.rdo_MultiSelect.TabIndex = 1;
            this.rdo_MultiSelect.Text = "Tùy chọn nhiều";
            this.rdo_MultiSelect.UseVisualStyleBackColor = true;
            this.rdo_MultiSelect.CheckedChanged += new System.EventHandler(this.rdo_MultiSelect_CheckedChanged);
            // 
            // rdo_OnlyOneAnswer
            // 
            this.rdo_OnlyOneAnswer.AutoSize = true;
            this.rdo_OnlyOneAnswer.Checked = true;
            this.rdo_OnlyOneAnswer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_OnlyOneAnswer.Location = new System.Drawing.Point(181, 19);
            this.rdo_OnlyOneAnswer.Name = "rdo_OnlyOneAnswer";
            this.rdo_OnlyOneAnswer.Size = new System.Drawing.Size(126, 23);
            this.rdo_OnlyOneAnswer.TabIndex = 0;
            this.rdo_OnlyOneAnswer.TabStop = true;
            this.rdo_OnlyOneAnswer.Text = "Tùy chọn một";
            this.rdo_OnlyOneAnswer.UseVisualStyleBackColor = true;
            this.rdo_OnlyOneAnswer.CheckedChanged += new System.EventHandler(this.rdo_OnlyOneAnswer_CheckedChanged);
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.grpTaoCauHoi);
            this.Controls.Add(this.grpChonDangCauHoi);
            this.Name = "CreateQuestion";
            this.Size = new System.Drawing.Size(830, 565);
            this.Load += new System.EventHandler(this.CreateQuestion_Load);
            this.grpTaoCauHoi.ResumeLayout(false);
            this.grpChonDangCauHoi.ResumeLayout(false);
            this.grpChonDangCauHoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTaoCauHoi;
        private System.Windows.Forms.Panel pnl_LoadQuestion;
        private System.Windows.Forms.GroupBox grpChonDangCauHoi;
        private System.Windows.Forms.RadioButton rdo_ShortAnswer;
        private System.Windows.Forms.RadioButton rdo_MultiSelect;
        private System.Windows.Forms.RadioButton rdo_OnlyOneAnswer;
    }
}
