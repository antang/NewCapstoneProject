namespace CapDemo.GUI
{
    partial class CopyQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Catalogue = new System.Windows.Forms.ComboBox();
            this.btn_SaveCopy = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_CancelCopy = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn chủ đề sao chép đến";
            // 
            // cmb_Catalogue
            // 
            this.cmb_Catalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Catalogue.FormattingEnabled = true;
            this.cmb_Catalogue.Location = new System.Drawing.Point(17, 36);
            this.cmb_Catalogue.Name = "cmb_Catalogue";
            this.cmb_Catalogue.Size = new System.Drawing.Size(328, 28);
            this.cmb_Catalogue.TabIndex = 1;
            // 
            // btn_SaveCopy
            // 
            this.btn_SaveCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SaveCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_SaveCopy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveCopy.ImageIndex = 1;
            this.btn_SaveCopy.ImageList = this.imageList1;
            this.btn_SaveCopy.Location = new System.Drawing.Point(150, 89);
            this.btn_SaveCopy.Name = "btn_SaveCopy";
            this.btn_SaveCopy.Size = new System.Drawing.Size(90, 40);
            this.btn_SaveCopy.TabIndex = 40;
            this.btn_SaveCopy.Text = "Lưu";
            this.btn_SaveCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveCopy.UseVisualStyleBackColor = false;
            this.btn_SaveCopy.Click += new System.EventHandler(this.btn_SaveCopy_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            this.imageList1.Images.SetKeyName(1, "save-512.png");
            // 
            // btn_CancelCopy
            // 
            this.btn_CancelCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_CancelCopy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelCopy.ImageIndex = 0;
            this.btn_CancelCopy.ImageList = this.imageList1;
            this.btn_CancelCopy.Location = new System.Drawing.Point(255, 89);
            this.btn_CancelCopy.Name = "btn_CancelCopy";
            this.btn_CancelCopy.Size = new System.Drawing.Size(90, 40);
            this.btn_CancelCopy.TabIndex = 39;
            this.btn_CancelCopy.Text = "Hủy";
            this.btn_CancelCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelCopy.UseVisualStyleBackColor = false;
            this.btn_CancelCopy.Click += new System.EventHandler(this.btn_CancelCopy_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // CopyQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapDemo.Properties.Resources.KhungPanner4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 141);
            this.Controls.Add(this.btn_SaveCopy);
            this.Controls.Add(this.btn_CancelCopy);
            this.Controls.Add(this.cmb_Catalogue);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyQuestion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao chép câu hỏi";
            this.Load += new System.EventHandler(this.CopyQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Catalogue;
        private System.Windows.Forms.Button btn_SaveCopy;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_CancelCopy;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}