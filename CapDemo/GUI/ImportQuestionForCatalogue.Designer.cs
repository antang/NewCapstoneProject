namespace CapDemo.GUI
{
    partial class ImportQuestionForCatalogue
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Catalogue = new System.Windows.Forms.Label();
            this.txt_Catalogue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnl_ImportQuestion = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_ImportCreateNew = new System.Windows.Forms.RadioButton();
            this.rdb_ImportToFile = new System.Windows.Forms.RadioButton();
            this.rdb_ImportToCatalogue = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Catalogue
            // 
            this.lbl_Catalogue.AutoSize = true;
            this.lbl_Catalogue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Catalogue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Catalogue.Location = new System.Drawing.Point(12, 19);
            this.lbl_Catalogue.Name = "lbl_Catalogue";
            this.lbl_Catalogue.Size = new System.Drawing.Size(65, 19);
            this.lbl_Catalogue.TabIndex = 20;
            this.lbl_Catalogue.Text = "Chủ đề:";
            // 
            // txt_Catalogue
            // 
            this.txt_Catalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Catalogue.Location = new System.Drawing.Point(96, 12);
            this.txt_Catalogue.Name = "txt_Catalogue";
            this.txt_Catalogue.ReadOnly = true;
            this.txt_Catalogue.Size = new System.Drawing.Size(357, 26);
            this.txt_Catalogue.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pnl_ImportQuestion);
            this.groupBox2.Location = new System.Drawing.Point(16, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 548);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // pnl_ImportQuestion
            // 
            this.pnl_ImportQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ImportQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_ImportQuestion.Location = new System.Drawing.Point(7, 13);
            this.pnl_ImportQuestion.Name = "pnl_ImportQuestion";
            this.pnl_ImportQuestion.Size = new System.Drawing.Size(793, 529);
            this.pnl_ImportQuestion.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdb_ImportCreateNew);
            this.groupBox1.Controls.Add(this.rdb_ImportToFile);
            this.groupBox1.Controls.Add(this.rdb_ImportToCatalogue);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 52);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn cách Import câu hỏi";
            // 
            // rdb_ImportCreateNew
            // 
            this.rdb_ImportCreateNew.AutoSize = true;
            this.rdb_ImportCreateNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_ImportCreateNew.Location = new System.Drawing.Point(658, 20);
            this.rdb_ImportCreateNew.Name = "rdb_ImportCreateNew";
            this.rdb_ImportCreateNew.Size = new System.Drawing.Size(118, 20);
            this.rdb_ImportCreateNew.TabIndex = 2;
            this.rdb_ImportCreateNew.Text = "Tạo cẩu hỏi mới";
            this.rdb_ImportCreateNew.UseVisualStyleBackColor = true;
            this.rdb_ImportCreateNew.CheckedChanged += new System.EventHandler(this.rdb_ImportCreateNew_CheckedChanged);
            // 
            // rdb_ImportToFile
            // 
            this.rdb_ImportToFile.AutoSize = true;
            this.rdb_ImportToFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_ImportToFile.Location = new System.Drawing.Point(352, 20);
            this.rdb_ImportToFile.Name = "rdb_ImportToFile";
            this.rdb_ImportToFile.Size = new System.Drawing.Size(149, 20);
            this.rdb_ImportToFile.TabIndex = 1;
            this.rdb_ImportToFile.Text = "Import câu hỏi từ File";
            this.rdb_ImportToFile.UseVisualStyleBackColor = true;
            this.rdb_ImportToFile.CheckedChanged += new System.EventHandler(this.rdb_ImportToFile_CheckedChanged);
            // 
            // rdb_ImportToCatalogue
            // 
            this.rdb_ImportToCatalogue.AutoSize = true;
            this.rdb_ImportToCatalogue.Checked = true;
            this.rdb_ImportToCatalogue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_ImportToCatalogue.Location = new System.Drawing.Point(18, 20);
            this.rdb_ImportToCatalogue.Name = "rdb_ImportToCatalogue";
            this.rdb_ImportToCatalogue.Size = new System.Drawing.Size(225, 20);
            this.rdb_ImportToCatalogue.TabIndex = 0;
            this.rdb_ImportToCatalogue.TabStop = true;
            this.rdb_ImportToCatalogue.Text = "Nhập câu hỏi từ ngân hàng câu hỏi";
            this.rdb_ImportToCatalogue.UseVisualStyleBackColor = true;
            this.rdb_ImportToCatalogue.CheckedChanged += new System.EventHandler(this.rdb_ImportToCatalogue_CheckedChanged);
            // 
            // ImportQuestionForCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(834, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Catalogue);
            this.Controls.Add(this.lbl_Catalogue);
            this.Name = "ImportQuestionForCatalogue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập câu hỏi cho chủ đề";
            this.Load += new System.EventHandler(this.ImportQuestionForCatalogue_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Catalogue;
        private System.Windows.Forms.TextBox txt_Catalogue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnl_ImportQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_ImportCreateNew;
        private System.Windows.Forms.RadioButton rdb_ImportToFile;
        private System.Windows.Forms.RadioButton rdb_ImportToCatalogue;
    }
}