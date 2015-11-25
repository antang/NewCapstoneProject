namespace CapDemo.GUI
{
    partial class ViewQuestionInCatalogue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewQuestionInCatalogue));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NameCatalogue = new System.Windows.Forms.TextBox();
            this.dgv_Question1 = new System.Windows.Forms.DataGridView();
            this.btn_SearchCatalogue = new System.Windows.Forms.Button();
            this.txt_SearchCatalogue = new System.Windows.Forms.TextBox();
            this.btn_CancelViewQuestione = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách câu hỏi trong chủ đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chủ đề";
            // 
            // txt_NameCatalogue
            // 
            this.txt_NameCatalogue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameCatalogue.Location = new System.Drawing.Point(81, 64);
            this.txt_NameCatalogue.Name = "txt_NameCatalogue";
            this.txt_NameCatalogue.ReadOnly = true;
            this.txt_NameCatalogue.Size = new System.Drawing.Size(335, 23);
            this.txt_NameCatalogue.TabIndex = 2;
            this.txt_NameCatalogue.TabStop = false;
            // 
            // dgv_Question1
            // 
            this.dgv_Question1.AllowUserToAddRows = false;
            this.dgv_Question1.AllowUserToDeleteRows = false;
            this.dgv_Question1.AllowUserToResizeColumns = false;
            this.dgv_Question1.AllowUserToResizeRows = false;
            this.dgv_Question1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Question1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Question1.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Question1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Question1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Question1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Question1.Location = new System.Drawing.Point(19, 96);
            this.dgv_Question1.Name = "dgv_Question1";
            this.dgv_Question1.ReadOnly = true;
            this.dgv_Question1.RowHeadersVisible = false;
            this.dgv_Question1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Question1.Size = new System.Drawing.Size(753, 306);
            this.dgv_Question1.TabIndex = 3;
            this.dgv_Question1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Question_CellDoubleClick);
            // 
            // btn_SearchCatalogue
            // 
            this.btn_SearchCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchCatalogue.BackColor = System.Drawing.Color.Navy;
            this.btn_SearchCatalogue.BackgroundImage = global::CapDemo.Properties.Resources.search2;
            this.btn_SearchCatalogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SearchCatalogue.Enabled = false;
            this.btn_SearchCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchCatalogue.ImageIndex = 3;
            this.btn_SearchCatalogue.Location = new System.Drawing.Point(514, 61);
            this.btn_SearchCatalogue.Name = "btn_SearchCatalogue";
            this.btn_SearchCatalogue.Size = new System.Drawing.Size(35, 29);
            this.btn_SearchCatalogue.TabIndex = 16;
            this.btn_SearchCatalogue.UseVisualStyleBackColor = false;
            // 
            // txt_SearchCatalogue
            // 
            this.txt_SearchCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchCatalogue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchCatalogue.Location = new System.Drawing.Point(555, 62);
            this.txt_SearchCatalogue.Name = "txt_SearchCatalogue";
            this.txt_SearchCatalogue.Size = new System.Drawing.Size(217, 23);
            this.txt_SearchCatalogue.TabIndex = 15;
            // 
            // btn_CancelViewQuestione
            // 
            this.btn_CancelViewQuestione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelViewQuestione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_CancelViewQuestione.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelViewQuestione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CancelViewQuestione.ImageIndex = 0;
            this.btn_CancelViewQuestione.ImageList = this.imageList1;
            this.btn_CancelViewQuestione.Location = new System.Drawing.Point(682, 433);
            this.btn_CancelViewQuestione.Name = "btn_CancelViewQuestione";
            this.btn_CancelViewQuestione.Size = new System.Drawing.Size(90, 30);
            this.btn_CancelViewQuestione.TabIndex = 33;
            this.btn_CancelViewQuestione.Text = "Thoát";
            this.btn_CancelViewQuestione.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelViewQuestione.UseVisualStyleBackColor = false;
            this.btn_CancelViewQuestione.Click += new System.EventHandler(this.btn_CancelViewQuestione_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            // 
            // ViewQuestionInCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 487);
            this.Controls.Add(this.btn_CancelViewQuestione);
            this.Controls.Add(this.btn_SearchCatalogue);
            this.Controls.Add(this.txt_SearchCatalogue);
            this.Controls.Add(this.dgv_Question1);
            this.Controls.Add(this.txt_NameCatalogue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ViewQuestionInCatalogue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem câu hỏi có trong chủ đề";
            this.Load += new System.EventHandler(this.ViewQuestionInCatalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NameCatalogue;
        private System.Windows.Forms.DataGridView dgv_Question1;
        private System.Windows.Forms.Button btn_SearchCatalogue;
        private System.Windows.Forms.TextBox txt_SearchCatalogue;
        private System.Windows.Forms.Button btn_CancelViewQuestione;
        private System.Windows.Forms.ImageList imageList1;
    }
}