﻿namespace CapDemo.GUI
{
    partial class DeleteCatalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCatalogue));
            this.btn_Ok = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rad_DelCatQuest = new System.Windows.Forms.RadioButton();
            this.rad_DelCat = new System.Windows.Forms.RadioButton();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.White;
            this.btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Ok.ImageIndex = 1;
            this.btn_Ok.ImageList = this.imageList1;
            this.btn_Ok.Location = new System.Drawing.Point(146, 119);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(99, 30);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "Đồng ý";
            this.btn_Ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            this.imageList1.Images.SetKeyName(1, "ok.png");
            // 
            // rad_DelCatQuest
            // 
            this.rad_DelCatQuest.AutoSize = true;
            this.rad_DelCatQuest.BackColor = System.Drawing.Color.Transparent;
            this.rad_DelCatQuest.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_DelCatQuest.ForeColor = System.Drawing.Color.White;
            this.rad_DelCatQuest.Location = new System.Drawing.Point(19, 53);
            this.rad_DelCatQuest.Name = "rad_DelCatQuest";
            this.rad_DelCatQuest.Size = new System.Drawing.Size(331, 20);
            this.rad_DelCatQuest.TabIndex = 5;
            this.rad_DelCatQuest.Text = "Xóa chủ đề và những câu hỏi thuộc chủ đề";
            this.rad_DelCatQuest.UseVisualStyleBackColor = false;
            // 
            // rad_DelCat
            // 
            this.rad_DelCat.AutoSize = true;
            this.rad_DelCat.BackColor = System.Drawing.Color.Transparent;
            this.rad_DelCat.Checked = true;
            this.rad_DelCat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_DelCat.ForeColor = System.Drawing.Color.White;
            this.rad_DelCat.Location = new System.Drawing.Point(19, 27);
            this.rad_DelCat.Name = "rad_DelCat";
            this.rad_DelCat.Size = new System.Drawing.Size(106, 20);
            this.rad_DelCat.TabIndex = 4;
            this.rad_DelCat.TabStop = true;
            this.rad_DelCat.Text = "Xóa chủ đề";
            this.rad_DelCat.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.imageList1;
            this.btn_Cancel.Location = new System.Drawing.Point(251, 119);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(99, 30);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // DeleteCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 161);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.rad_DelCatQuest);
            this.Controls.Add(this.rad_DelCat);
            this.Controls.Add(this.btn_Cancel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteCatalogue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa chủ đề";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RadioButton rad_DelCatQuest;
        private System.Windows.Forms.RadioButton rad_DelCat;
        private System.Windows.Forms.Button btn_Cancel;
    }
}