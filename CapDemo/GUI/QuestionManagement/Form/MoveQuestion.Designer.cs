﻿namespace CapDemo.GUI.User_Controls
{
    partial class MoveQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveQuestion));
            this.btn_SaveMove = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmb_Catalogue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CancelMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SaveMove
            // 
            this.btn_SaveMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SaveMove.BackColor = System.Drawing.Color.White;
            this.btn_SaveMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveMove.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveMove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveMove.ImageIndex = 1;
            this.btn_SaveMove.ImageList = this.imageList1;
            this.btn_SaveMove.Location = new System.Drawing.Point(143, 96);
            this.btn_SaveMove.Name = "btn_SaveMove";
            this.btn_SaveMove.Size = new System.Drawing.Size(90, 30);
            this.btn_SaveMove.TabIndex = 44;
            this.btn_SaveMove.Text = "Lưu";
            this.btn_SaveMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveMove.UseVisualStyleBackColor = false;
            this.btn_SaveMove.Click += new System.EventHandler(this.btn_SaveMove_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            this.imageList1.Images.SetKeyName(1, "save-512.png");
            // 
            // cmb_Catalogue
            // 
            this.cmb_Catalogue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Catalogue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Catalogue.FormattingEnabled = true;
            this.cmb_Catalogue.Location = new System.Drawing.Point(12, 35);
            this.cmb_Catalogue.Name = "cmb_Catalogue";
            this.cmb_Catalogue.Size = new System.Drawing.Size(328, 24);
            this.cmb_Catalogue.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Chọn chủ đề di chuyển đến";
            // 
            // btn_CancelMove
            // 
            this.btn_CancelMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelMove.BackColor = System.Drawing.Color.White;
            this.btn_CancelMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelMove.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelMove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelMove.ImageIndex = 0;
            this.btn_CancelMove.ImageList = this.imageList1;
            this.btn_CancelMove.Location = new System.Drawing.Point(250, 96);
            this.btn_CancelMove.Name = "btn_CancelMove";
            this.btn_CancelMove.Size = new System.Drawing.Size(90, 30);
            this.btn_CancelMove.TabIndex = 43;
            this.btn_CancelMove.Text = "Hủy";
            this.btn_CancelMove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelMove.UseVisualStyleBackColor = false;
            this.btn_CancelMove.Click += new System.EventHandler(this.btn_CancelMove_Click);
            // 
            // MoveQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 138);
            this.Controls.Add(this.btn_SaveMove);
            this.Controls.Add(this.cmb_Catalogue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CancelMove);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveQuestion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Di chuyển câu hỏi";
            this.Load += new System.EventHandler(this.MoveQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveMove;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmb_Catalogue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CancelMove;
    }
}