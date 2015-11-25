namespace CapDemo.GUI.User_Controls
{
    partial class ImportQuestionToQuestionStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportQuestionToQuestionStore));
            this.cmb_Catalogue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.rad_Move = new System.Windows.Forms.RadioButton();
            this.rad_Copy = new System.Windows.Forms.RadioButton();
            this.dgv_Question = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chk_CheckAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Catalogue
            // 
            this.cmb_Catalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Catalogue.FormattingEnabled = true;
            this.cmb_Catalogue.Location = new System.Drawing.Point(112, 3);
            this.cmb_Catalogue.Name = "cmb_Catalogue";
            this.cmb_Catalogue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Catalogue.Size = new System.Drawing.Size(333, 28);
            this.cmb_Catalogue.TabIndex = 9;
            this.cmb_Catalogue.SelectedIndexChanged += new System.EventHandler(this.cmb_Catalogue_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn chủ đề";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            this.imageList1.Images.SetKeyName(1, "save-512.png");
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Save.ImageIndex = 1;
            this.btn_Save.ImageList = this.imageList1;
            this.btn_Save.Location = new System.Drawing.Point(519, 423);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 40);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.imageList1;
            this.btn_Cancel.Location = new System.Drawing.Point(634, 423);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 40);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // rad_Move
            // 
            this.rad_Move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rad_Move.AutoSize = true;
            this.rad_Move.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Move.ForeColor = System.Drawing.Color.White;
            this.rad_Move.Location = new System.Drawing.Point(637, 353);
            this.rad_Move.Name = "rad_Move";
            this.rad_Move.Size = new System.Drawing.Size(97, 23);
            this.rad_Move.TabIndex = 12;
            this.rad_Move.TabStop = true;
            this.rad_Move.Text = "Di chuyển";
            this.rad_Move.UseVisualStyleBackColor = true;
            // 
            // rad_Copy
            // 
            this.rad_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rad_Copy.AutoSize = true;
            this.rad_Copy.Checked = true;
            this.rad_Copy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Copy.ForeColor = System.Drawing.Color.White;
            this.rad_Copy.Location = new System.Drawing.Point(540, 353);
            this.rad_Copy.Name = "rad_Copy";
            this.rad_Copy.Size = new System.Drawing.Size(91, 23);
            this.rad_Copy.TabIndex = 11;
            this.rad_Copy.TabStop = true;
            this.rad_Copy.Text = "Sao chép";
            this.rad_Copy.UseVisualStyleBackColor = true;
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
            this.dgv_Question.Location = new System.Drawing.Point(12, 40);
            this.dgv_Question.Name = "dgv_Question";
            this.dgv_Question.RowHeadersVisible = false;
            this.dgv_Question.Size = new System.Drawing.Size(722, 307);
            this.dgv_Question.TabIndex = 10;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // chk_CheckAll
            // 
            this.chk_CheckAll.AutoSize = true;
            this.chk_CheckAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_CheckAll.ForeColor = System.Drawing.Color.White;
            this.chk_CheckAll.Location = new System.Drawing.Point(642, 14);
            this.chk_CheckAll.Name = "chk_CheckAll";
            this.chk_CheckAll.Size = new System.Drawing.Size(92, 20);
            this.chk_CheckAll.TabIndex = 15;
            this.chk_CheckAll.Text = "Chọn tất cả";
            this.chk_CheckAll.UseVisualStyleBackColor = true;
            this.chk_CheckAll.CheckedChanged += new System.EventHandler(this.chk_CheckAll_CheckedChanged);
            // 
            // ImportQuestionToQuestionStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_CheckAll);
            this.Controls.Add(this.cmb_Catalogue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.rad_Move);
            this.Controls.Add(this.rad_Copy);
            this.Controls.Add(this.dgv_Question);
            this.Name = "ImportQuestionToQuestionStore";
            this.Size = new System.Drawing.Size(749, 479);
            this.Load += new System.EventHandler(this.ImportQuestionToQuestionStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton rad_Move;
        private System.Windows.Forms.RadioButton rad_Copy;
        private System.Windows.Forms.DataGridView dgv_Question;
        public System.Windows.Forms.ComboBox cmb_Catalogue;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox chk_CheckAll;
    }
}
