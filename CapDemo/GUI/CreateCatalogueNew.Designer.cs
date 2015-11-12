﻿namespace CapDemo.GUI
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SaveCatalogue
            // 
            this.btn_SaveCatalogue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SaveCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_SaveCatalogue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveCatalogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveCatalogue.ImageIndex = 0;
            this.btn_SaveCatalogue.ImageList = this.imageList1;
            this.btn_SaveCatalogue.Location = new System.Drawing.Point(164, 159);
            this.btn_SaveCatalogue.Name = "btn_SaveCatalogue";
            this.btn_SaveCatalogue.Size = new System.Drawing.Size(90, 40);
            this.btn_SaveCatalogue.TabIndex = 38;
            this.btn_SaveCatalogue.Text = "Lưu";
            this.btn_SaveCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveCatalogue.UseVisualStyleBackColor = false;
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
            this.btn_CancelCatalogue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_CancelCatalogue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelCatalogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelCatalogue.ImageIndex = 1;
            this.btn_CancelCatalogue.ImageList = this.imageList1;
            this.btn_CancelCatalogue.Location = new System.Drawing.Point(260, 159);
            this.btn_CancelCatalogue.Name = "btn_CancelCatalogue";
            this.btn_CancelCatalogue.Size = new System.Drawing.Size(90, 40);
            this.btn_CancelCatalogue.TabIndex = 37;
            this.btn_CancelCatalogue.Text = "Hủy";
            this.btn_CancelCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelCatalogue.UseVisualStyleBackColor = false;
            // 
            // txt_NameCatalogue
            // 
            this.txt_NameCatalogue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NameCatalogue.Location = new System.Drawing.Point(24, 103);
            this.txt_NameCatalogue.Multiline = true;
            this.txt_NameCatalogue.Name = "txt_NameCatalogue";
            this.txt_NameCatalogue.Size = new System.Drawing.Size(326, 30);
            this.txt_NameCatalogue.TabIndex = 36;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(19, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(88, 19);
            this.lbl2.TabIndex = 35;
            this.lbl2.Text = "Tên chủ đề";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(13, 14);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(205, 33);
            this.lbl1.TabIndex = 34;
            this.lbl1.Text = "Tạo Chủ Đề Mới";
            // 
            // CreateCatalogueNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapDemo.Properties.Resources.KhungPanner4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 213);
            this.Controls.Add(this.btn_SaveCatalogue);
            this.Controls.Add(this.btn_CancelCatalogue);
            this.Controls.Add(this.txt_NameCatalogue);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCatalogueNew";
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
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}