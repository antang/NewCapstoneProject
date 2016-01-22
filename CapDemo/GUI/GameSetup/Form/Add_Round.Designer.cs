namespace CapDemo
{
    partial class Add_Round
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Round));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_NameRound = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn_SaveRound = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-512.png");
            this.imageList1.Images.SetKeyName(1, "Cancel.png");
            // 
            // txt_NameRound
            // 
            this.txt_NameRound.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameRound.Location = new System.Drawing.Point(28, 95);
            this.txt_NameRound.Name = "txt_NameRound";
            this.txt_NameRound.Size = new System.Drawing.Size(326, 23);
            this.txt_NameRound.TabIndex = 41;
            this.txt_NameRound.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NameRound_KeyDown);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(17, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(212, 25);
            this.lbl1.TabIndex = 39;
            this.lbl1.Text = "Tạo Vòng Thi Mới";
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
            this.lbl2.Location = new System.Drawing.Point(23, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(97, 16);
            this.lbl2.TabIndex = 40;
            this.lbl2.Text = "Tên vòng thi";
            // 
            // btn_SaveRound
            // 
            this.btn_SaveRound.BackColor = System.Drawing.Color.White;
            this.btn_SaveRound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveRound.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveRound.ImageIndex = 0;
            this.btn_SaveRound.ImageList = this.imageList1;
            this.btn_SaveRound.Location = new System.Drawing.Point(168, 133);
            this.btn_SaveRound.Name = "btn_SaveRound";
            this.btn_SaveRound.Size = new System.Drawing.Size(90, 30);
            this.btn_SaveRound.TabIndex = 43;
            this.btn_SaveRound.Text = "Lưu";
            this.btn_SaveRound.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveRound.UseVisualStyleBackColor = false;
            this.btn_SaveRound.Click += new System.EventHandler(this.btn_SaveRound_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cancel.ImageIndex = 1;
            this.btn_Cancel.ImageList = this.imageList1;
            this.btn_Cancel.Location = new System.Drawing.Point(264, 133);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 30);
            this.btn_Cancel.TabIndex = 42;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Add_Round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(371, 176);
            this.Controls.Add(this.btn_SaveRound);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_NameRound);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Round";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Vòng Thi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveRound;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_NameRound;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbl2;
    }
}