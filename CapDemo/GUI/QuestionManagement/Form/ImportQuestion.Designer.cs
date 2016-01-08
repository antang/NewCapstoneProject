namespace CapDemo.GUI
{
    partial class ImportQuestion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportQuestion));
            this.cmb_Catalogue = new System.Windows.Forms.ComboBox();
            this.lbl_Catalogue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_CheckAll = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DownloadFile = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Question = new System.Windows.Forms.DataGridView();
            this.Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_SaveImport = new System.Windows.Forms.Button();
            this.btn_ExitImport = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Catalogue
            // 
            this.cmb_Catalogue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Catalogue.FormattingEnabled = true;
            this.cmb_Catalogue.Location = new System.Drawing.Point(89, 13);
            this.cmb_Catalogue.Name = "cmb_Catalogue";
            this.cmb_Catalogue.Size = new System.Drawing.Size(358, 24);
            this.cmb_Catalogue.TabIndex = 23;
            // 
            // lbl_Catalogue
            // 
            this.lbl_Catalogue.AutoSize = true;
            this.lbl_Catalogue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Catalogue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Catalogue.Location = new System.Drawing.Point(24, 21);
            this.lbl_Catalogue.Name = "lbl_Catalogue";
            this.lbl_Catalogue.Size = new System.Drawing.Size(63, 16);
            this.lbl_Catalogue.TabIndex = 22;
            this.lbl_Catalogue.Text = "Chủ đề:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên File";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chk_CheckAll);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dgv_Question);
            this.groupBox2.Controls.Add(this.btn_LoadFile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_FilePath);
            this.groupBox2.Location = new System.Drawing.Point(4, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 475);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // chk_CheckAll
            // 
            this.chk_CheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_CheckAll.AutoSize = true;
            this.chk_CheckAll.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_CheckAll.ForeColor = System.Drawing.Color.White;
            this.chk_CheckAll.Location = new System.Drawing.Point(660, 97);
            this.chk_CheckAll.Name = "chk_CheckAll";
            this.chk_CheckAll.Size = new System.Drawing.Size(97, 17);
            this.chk_CheckAll.TabIndex = 5;
            this.chk_CheckAll.Text = "Chọn tất cả";
            this.chk_CheckAll.UseVisualStyleBackColor = true;
            this.chk_CheckAll.CheckedChanged += new System.EventHandler(this.chk_CheckAll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_DownloadFile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(568, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 58);
            this.panel1.TabIndex = 3;
            // 
            // btn_DownloadFile
            // 
            this.btn_DownloadFile.BackColor = System.Drawing.Color.White;
            this.btn_DownloadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DownloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DownloadFile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DownloadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DownloadFile.ImageIndex = 2;
            this.btn_DownloadFile.ImageList = this.imageList1;
            this.btn_DownloadFile.Location = new System.Drawing.Point(60, 19);
            this.btn_DownloadFile.Name = "btn_DownloadFile";
            this.btn_DownloadFile.Size = new System.Drawing.Size(90, 30);
            this.btn_DownloadFile.TabIndex = 34;
            this.btn_DownloadFile.Text = "Tải Về";
            this.btn_DownloadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DownloadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DownloadFile.UseVisualStyleBackColor = false;
            this.btn_DownloadFile.Click += new System.EventHandler(this.btn_DownloadFile_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "import.png");
            this.imageList1.Images.SetKeyName(1, "save-512.png");
            this.imageList1.Images.SetKeyName(2, "Down.png");
            this.imageList1.Images.SetKeyName(3, "Cancel.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tải file mẫu  tại đây\r\n";
            // 
            // dgv_Question
            // 
            this.dgv_Question.AllowUserToAddRows = false;
            this.dgv_Question.AllowUserToDeleteRows = false;
            this.dgv_Question.AllowUserToResizeColumns = false;
            this.dgv_Question.AllowUserToResizeRows = false;
            this.dgv_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Question.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Question.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Question.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequence,
            this.QuestionTitle,
            this.QuestionName,
            this.QuestionType,
            this.Check});
            this.dgv_Question.Location = new System.Drawing.Point(15, 125);
            this.dgv_Question.Name = "dgv_Question";
            this.dgv_Question.RowHeadersVisible = false;
            this.dgv_Question.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Question.Size = new System.Drawing.Size(742, 315);
            this.dgv_Question.TabIndex = 4;
            // 
            // Sequence
            // 
            this.Sequence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sequence.DataPropertyName = "Sequence";
            this.Sequence.HeaderText = "STT";
            this.Sequence.Name = "Sequence";
            this.Sequence.ReadOnly = true;
            this.Sequence.Width = 53;
            // 
            // QuestionTitle
            // 
            this.QuestionTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QuestionTitle.HeaderText = "Tên câu Hỏi";
            this.QuestionTitle.Name = "QuestionTitle";
            this.QuestionTitle.ReadOnly = true;
            this.QuestionTitle.Width = 91;
            // 
            // QuestionName
            // 
            this.QuestionName.HeaderText = "Nội dung";
            this.QuestionName.Name = "QuestionName";
            this.QuestionName.ReadOnly = true;
            // 
            // QuestionType
            // 
            this.QuestionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QuestionType.HeaderText = "Loại Cậu Hỏi";
            this.QuestionType.Name = "QuestionType";
            this.QuestionType.ReadOnly = true;
            this.QuestionType.Width = 93;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Check.HeaderText = "Chọn";
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.Width = 38;
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.BackColor = System.Drawing.Color.White;
            this.btn_LoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadFile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_LoadFile.ImageIndex = 0;
            this.btn_LoadFile.ImageList = this.imageList1;
            this.btn_LoadFile.Location = new System.Drawing.Point(449, 82);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(110, 29);
            this.btn_LoadFile.TabIndex = 3;
            this.btn_LoadFile.Text = "Chọn File";
            this.btn_LoadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LoadFile.UseVisualStyleBackColor = false;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilePath.Location = new System.Drawing.Point(85, 88);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.ReadOnly = true;
            this.txt_FilePath.Size = new System.Drawing.Size(358, 23);
            this.txt_FilePath.TabIndex = 0;
            // 
            // btn_SaveImport
            // 
            this.btn_SaveImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveImport.BackColor = System.Drawing.Color.White;
            this.btn_SaveImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveImport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveImport.ImageIndex = 1;
            this.btn_SaveImport.ImageList = this.imageList1;
            this.btn_SaveImport.Location = new System.Drawing.Point(546, 559);
            this.btn_SaveImport.Name = "btn_SaveImport";
            this.btn_SaveImport.Size = new System.Drawing.Size(99, 30);
            this.btn_SaveImport.TabIndex = 40;
            this.btn_SaveImport.Text = "Lưu";
            this.btn_SaveImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveImport.UseVisualStyleBackColor = false;
            this.btn_SaveImport.Click += new System.EventHandler(this.btn_SaveImport_Click);
            // 
            // btn_ExitImport
            // 
            this.btn_ExitImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExitImport.BackColor = System.Drawing.Color.White;
            this.btn_ExitImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExitImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExitImport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ExitImport.ImageIndex = 3;
            this.btn_ExitImport.ImageList = this.imageList1;
            this.btn_ExitImport.Location = new System.Drawing.Point(662, 559);
            this.btn_ExitImport.Name = "btn_ExitImport";
            this.btn_ExitImport.Size = new System.Drawing.Size(99, 30);
            this.btn_ExitImport.TabIndex = 39;
            this.btn_ExitImport.Text = "Hủy";
            this.btn_ExitImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExitImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ExitImport.UseVisualStyleBackColor = false;
            this.btn_ExitImport.Click += new System.EventHandler(this.btn_ExitImport_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ImportQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_SaveImport);
            this.Controls.Add(this.btn_ExitImport);
            this.Controls.Add(this.cmb_Catalogue);
            this.Controls.Add(this.lbl_Catalogue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportQuestion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập câu hỏi";
            this.Load += new System.EventHandler(this.ImportQuestion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Catalogue;
        private System.Windows.Forms.Label lbl_Catalogue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DownloadFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Question;
        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_SaveImport;
        private System.Windows.Forms.Button btn_ExitImport;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox chk_CheckAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
    }
}