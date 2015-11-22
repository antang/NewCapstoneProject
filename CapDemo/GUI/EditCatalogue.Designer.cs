namespace CapDemo.GUI
{
    partial class EditCatalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCatalogue));
            this.btn_SaveEditCatalogue = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_CancelEditCatalogue = new System.Windows.Forms.Button();
            this.txt_NameCatalogue = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btn_SaveEditCatalogue
            // 
            this.btn_SaveEditCatalogue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SaveEditCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_SaveEditCatalogue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveEditCatalogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveEditCatalogue.ImageIndex = 0;
            this.btn_SaveEditCatalogue.ImageList = this.imageList1;
            this.btn_SaveEditCatalogue.Location = new System.Drawing.Point(171, 161);
            this.btn_SaveEditCatalogue.Name = "btn_SaveEditCatalogue";
            this.btn_SaveEditCatalogue.Size = new System.Drawing.Size(90, 40);
            this.btn_SaveEditCatalogue.TabIndex = 44;
            this.btn_SaveEditCatalogue.Text = "Lưu";
            this.btn_SaveEditCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveEditCatalogue.UseVisualStyleBackColor = false;
            this.btn_SaveEditCatalogue.Click += new System.EventHandler(this.btn_SaveEditCatalogue_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-512.png");
            this.imageList1.Images.SetKeyName(1, "Cancel.png");
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(16, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(219, 33);
            this.lbl1.TabIndex = 40;
            this.lbl1.Text = "Chỉnh sửa chủ đề";
            // 
            // btn_CancelEditCatalogue
            // 
            this.btn_CancelEditCatalogue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelEditCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_CancelEditCatalogue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelEditCatalogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelEditCatalogue.ImageIndex = 1;
            this.btn_CancelEditCatalogue.ImageList = this.imageList1;
            this.btn_CancelEditCatalogue.Location = new System.Drawing.Point(267, 161);
            this.btn_CancelEditCatalogue.Name = "btn_CancelEditCatalogue";
            this.btn_CancelEditCatalogue.Size = new System.Drawing.Size(90, 40);
            this.btn_CancelEditCatalogue.TabIndex = 43;
            this.btn_CancelEditCatalogue.Text = "Hủy";
            this.btn_CancelEditCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelEditCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelEditCatalogue.UseVisualStyleBackColor = false;
            this.btn_CancelEditCatalogue.Click += new System.EventHandler(this.btn_CancelEditCatalogue_Click);
            // 
            // txt_NameCatalogue
            // 
            this.txt_NameCatalogue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NameCatalogue.Location = new System.Drawing.Point(31, 105);
            this.txt_NameCatalogue.Name = "txt_NameCatalogue";
            this.txt_NameCatalogue.Size = new System.Drawing.Size(326, 20);
            this.txt_NameCatalogue.TabIndex = 42;
            this.txt_NameCatalogue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NameCatalogue_KeyDown);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(22, 73);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(88, 19);
            this.lbl2.TabIndex = 41;
            this.lbl2.Text = "Tên chủ đề";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // EditCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapDemo.Properties.Resources.KhungPanner4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 210);
            this.Controls.Add(this.btn_SaveEditCatalogue);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_CancelEditCatalogue);
            this.Controls.Add(this.txt_NameCatalogue);
            this.Controls.Add(this.lbl2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCatalogue";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa chủ đề";
            this.Load += new System.EventHandler(this.EditCatalogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveEditCatalogue;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_CancelEditCatalogue;
        private System.Windows.Forms.TextBox txt_NameCatalogue;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}