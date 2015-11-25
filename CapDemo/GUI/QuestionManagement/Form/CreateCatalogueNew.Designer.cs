namespace CapDemo.GUI
{
    partial class CreateCatalogueNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCatalogueNew));
            this.btn_SaveCatalogue = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_CancelCatalogue = new System.Windows.Forms.Button();
            this.txt_NameCatalogue = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SaveCatalogue
            // 
            this.btn_SaveCatalogue.BackColor = System.Drawing.Color.White;
            this.btn_SaveCatalogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveCatalogue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveCatalogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveCatalogue.ImageIndex = 0;
            this.btn_SaveCatalogue.ImageList = this.imageList1;
            this.btn_SaveCatalogue.Location = new System.Drawing.Point(164, 134);
            this.btn_SaveCatalogue.Name = "btn_SaveCatalogue";
            this.btn_SaveCatalogue.Size = new System.Drawing.Size(90, 30);
            this.btn_SaveCatalogue.TabIndex = 38;
            this.btn_SaveCatalogue.Text = "Lưu";
            this.btn_SaveCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveCatalogue.UseVisualStyleBackColor = false;
            this.btn_SaveCatalogue.Click += new System.EventHandler(this.btn_SaveCatalogue_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-512.png");
            this.imageList1.Images.SetKeyName(1, "Cancel.png");
            // 
            // btn_CancelCatalogue
            // 
            this.btn_CancelCatalogue.BackColor = System.Drawing.Color.White;
            this.btn_CancelCatalogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelCatalogue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelCatalogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelCatalogue.ImageIndex = 1;
            this.btn_CancelCatalogue.ImageList = this.imageList1;
            this.btn_CancelCatalogue.Location = new System.Drawing.Point(260, 134);
            this.btn_CancelCatalogue.Name = "btn_CancelCatalogue";
            this.btn_CancelCatalogue.Size = new System.Drawing.Size(90, 30);
            this.btn_CancelCatalogue.TabIndex = 37;
            this.btn_CancelCatalogue.Text = "Hủy";
            this.btn_CancelCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelCatalogue.UseVisualStyleBackColor = false;
            this.btn_CancelCatalogue.Click += new System.EventHandler(this.btn_CancelCatalogue_Click);
            // 
            // txt_NameCatalogue
            // 
            this.txt_NameCatalogue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameCatalogue.Location = new System.Drawing.Point(24, 96);
            this.txt_NameCatalogue.Name = "txt_NameCatalogue";
            this.txt_NameCatalogue.Size = new System.Drawing.Size(326, 23);
            this.txt_NameCatalogue.TabIndex = 36;
            this.txt_NameCatalogue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NameCatalogue_KeyDown);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(13, 14);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(192, 25);
            this.lbl1.TabIndex = 34;
            this.lbl1.Text = "Tạo Chủ Đề Mới";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(19, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(86, 16);
            this.lbl2.TabIndex = 35;
            this.lbl2.Text = "Tên chủ đề";
            // 
            // CreateCatalogueNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 176);
            this.Controls.Add(this.btn_SaveCatalogue);
            this.Controls.Add(this.btn_CancelCatalogue);
            this.Controls.Add(this.txt_NameCatalogue);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCatalogueNew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo mới chủ đề";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveCatalogue;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_CancelCatalogue;
        private System.Windows.Forms.TextBox txt_NameCatalogue;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbl2;
    }
}