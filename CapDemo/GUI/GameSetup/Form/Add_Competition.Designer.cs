namespace CapDemo
{
    partial class Add_Competition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Competition));
            this.btn_SaveCompetition = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_NameCompetition = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SaveCompetition
            // 
            this.btn_SaveCompetition.BackColor = System.Drawing.Color.White;
            this.btn_SaveCompetition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveCompetition.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveCompetition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveCompetition.ImageIndex = 0;
            this.btn_SaveCompetition.ImageList = this.imageList1;
            this.btn_SaveCompetition.Location = new System.Drawing.Point(168, 133);
            this.btn_SaveCompetition.Name = "btn_SaveCompetition";
            this.btn_SaveCompetition.Size = new System.Drawing.Size(90, 30);
            this.btn_SaveCompetition.TabIndex = 43;
            this.btn_SaveCompetition.Text = "Lưu";
            this.btn_SaveCompetition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveCompetition.UseVisualStyleBackColor = false;
            this.btn_SaveCompetition.Click += new System.EventHandler(this.btn_SaveCompetition_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-512.png");
            this.imageList1.Images.SetKeyName(1, "Cancel.png");
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
            // txt_NameCompetition
            // 
            this.txt_NameCompetition.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameCompetition.Location = new System.Drawing.Point(28, 95);
            this.txt_NameCompetition.Name = "txt_NameCompetition";
            this.txt_NameCompetition.Size = new System.Drawing.Size(326, 23);
            this.txt_NameCompetition.TabIndex = 41;
            this.txt_NameCompetition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NameCompetition_KeyDown);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(17, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(208, 25);
            this.lbl1.TabIndex = 39;
            this.lbl1.Text = "Tạo Cuộc Thi Mới";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(23, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(95, 16);
            this.lbl2.TabIndex = 40;
            this.lbl2.Text = "Tên cuộc thi";
            // 
            // Add_Competition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(371, 176);
            this.Controls.Add(this.btn_SaveCompetition);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_NameCompetition);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Competition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Cuộc Thi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveCompetition;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_NameCompetition;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}