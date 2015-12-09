namespace CapDemo.GUI.User_Controls
{
    partial class ImportQuestions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportQuestions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DownloadFile = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_CheckAll = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_SaveImport = new System.Windows.Forms.Button();
            this.btn_ExitImport = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_DownloadFile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(577, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 58);
            this.panel1.TabIndex = 3;
            // 
            // btn_DownloadFile
            // 
            this.btn_DownloadFile.BackColor = System.Drawing.Color.White;
            this.btn_DownloadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DownloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DownloadFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DownloadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DownloadFile.ImageIndex = 0;
            this.btn_DownloadFile.ImageList = this.imageList1;
            this.btn_DownloadFile.Location = new System.Drawing.Point(42, 22);
            this.btn_DownloadFile.Name = "btn_DownloadFile";
            this.btn_DownloadFile.Size = new System.Drawing.Size(110, 30);
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
            this.imageList1.Images.SetKeyName(0, "Down.png");
            this.imageList1.Images.SetKeyName(1, "Cancel.png");
            this.imageList1.Images.SetKeyName(2, "save-512.png");
            this.imageList1.Images.SetKeyName(3, "import.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Download mẫu file tại đây\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chk_CheckAll);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btn_LoadFile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_FilePath);
            this.groupBox2.Location = new System.Drawing.Point(3, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 464);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // chk_CheckAll
            // 
            this.chk_CheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_CheckAll.AutoSize = true;
            this.chk_CheckAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_CheckAll.ForeColor = System.Drawing.Color.White;
            this.chk_CheckAll.Location = new System.Drawing.Point(675, 99);
            this.chk_CheckAll.Name = "chk_CheckAll";
            this.chk_CheckAll.Size = new System.Drawing.Size(92, 20);
            this.chk_CheckAll.TabIndex = 5;
            this.chk_CheckAll.Text = "Chọn tất cả";
            this.chk_CheckAll.UseVisualStyleBackColor = true;
            this.chk_CheckAll.CheckedChanged += new System.EventHandler(this.chk_CheckAll_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 333);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.BackColor = System.Drawing.Color.White;
            this.btn_LoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_LoadFile.ImageIndex = 3;
            this.btn_LoadFile.ImageList = this.imageList1;
            this.btn_LoadFile.Location = new System.Drawing.Point(454, 88);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(110, 31);
            this.btn_LoadFile.TabIndex = 3;
            this.btn_LoadFile.Text = "Chọn File";
            this.btn_LoadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LoadFile.UseVisualStyleBackColor = false;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên File";
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilePath.Location = new System.Drawing.Point(90, 95);
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
            this.btn_SaveImport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveImport.ImageIndex = 2;
            this.btn_SaveImport.ImageList = this.imageList1;
            this.btn_SaveImport.Location = new System.Drawing.Point(563, 489);
            this.btn_SaveImport.Name = "btn_SaveImport";
            this.btn_SaveImport.Size = new System.Drawing.Size(102, 40);
            this.btn_SaveImport.TabIndex = 37;
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
            this.btn_ExitImport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ExitImport.ImageIndex = 1;
            this.btn_ExitImport.ImageList = this.imageList1;
            this.btn_ExitImport.Location = new System.Drawing.Point(671, 489);
            this.btn_ExitImport.Name = "btn_ExitImport";
            this.btn_ExitImport.Size = new System.Drawing.Size(99, 40);
            this.btn_ExitImport.TabIndex = 36;
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
            // ImportQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_SaveImport);
            this.Controls.Add(this.btn_ExitImport);
            this.Name = "ImportQuestions";
            this.Size = new System.Drawing.Size(790, 538);
            this.Load += new System.EventHandler(this.ImportQuestions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DownloadFile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_SaveImport;
        private System.Windows.Forms.Button btn_ExitImport;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox chk_CheckAll;
    }
}
