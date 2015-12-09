namespace CapDemo
{
    partial class QuestionSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionSetting));
            this.dgv_Question = new System.Windows.Forms.DataGridView();
            this.lb_Phase = new System.Windows.Forms.ListBox();
            this.btn_ImportQuestion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_DeleteQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question)).BeginInit();
            this.SuspendLayout();
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
            this.dgv_Question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Question.Location = new System.Drawing.Point(162, 51);
            this.dgv_Question.Name = "dgv_Question";
            this.dgv_Question.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Question.Size = new System.Drawing.Size(583, 426);
            this.dgv_Question.TabIndex = 0;
            // 
            // lb_Phase
            // 
            this.lb_Phase.BackColor = System.Drawing.Color.SteelBlue;
            this.lb_Phase.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phase.ForeColor = System.Drawing.Color.White;
            this.lb_Phase.FormattingEnabled = true;
            this.lb_Phase.ItemHeight = 16;
            this.lb_Phase.Location = new System.Drawing.Point(3, 51);
            this.lb_Phase.Name = "lb_Phase";
            this.lb_Phase.Size = new System.Drawing.Size(159, 84);
            this.lb_Phase.TabIndex = 1;
            this.lb_Phase.SelectedIndexChanged += new System.EventHandler(this.lb_Phase_SelectedIndexChanged);
            // 
            // btn_ImportQuestion
            // 
            this.btn_ImportQuestion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ImportQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImportQuestion.ImageKey = "import.png";
            this.btn_ImportQuestion.ImageList = this.imageList1;
            this.btn_ImportQuestion.Location = new System.Drawing.Point(162, 10);
            this.btn_ImportQuestion.Name = "btn_ImportQuestion";
            this.btn_ImportQuestion.Size = new System.Drawing.Size(134, 35);
            this.btn_ImportQuestion.TabIndex = 2;
            this.btn_ImportQuestion.Text = "Nhập câu hỏi";
            this.btn_ImportQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ImportQuestion.UseVisualStyleBackColor = true;
            this.btn_ImportQuestion.Click += new System.EventHandler(this.btn_ImportQuestion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Lui.png");
            this.imageList1.Images.SetKeyName(1, "Tiep.png");
            this.imageList1.Images.SetKeyName(2, "save-512.png");
            this.imageList1.Images.SetKeyName(3, "ok.png");
            this.imageList1.Images.SetKeyName(4, "import.png");
            this.imageList1.Images.SetKeyName(5, "Cut.ico");
            // 
            // btn_DeleteQuestion
            // 
            this.btn_DeleteQuestion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DeleteQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteQuestion.ImageKey = "Cut.ico";
            this.btn_DeleteQuestion.ImageList = this.imageList1;
            this.btn_DeleteQuestion.Location = new System.Drawing.Point(319, 10);
            this.btn_DeleteQuestion.Name = "btn_DeleteQuestion";
            this.btn_DeleteQuestion.Size = new System.Drawing.Size(134, 35);
            this.btn_DeleteQuestion.TabIndex = 3;
            this.btn_DeleteQuestion.Text = "Xóa Câu hỏi";
            this.btn_DeleteQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteQuestion.UseVisualStyleBackColor = true;
            this.btn_DeleteQuestion.Click += new System.EventHandler(this.btn_DeleteQuestion_Click);
            // 
            // QuestionSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btn_DeleteQuestion);
            this.Controls.Add(this.btn_ImportQuestion);
            this.Controls.Add(this.lb_Phase);
            this.Controls.Add(this.dgv_Question);
            this.Name = "QuestionSetting";
            this.Size = new System.Drawing.Size(748, 480);
            this.Load += new System.EventHandler(this.QuestionSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Question;
        private System.Windows.Forms.ListBox lb_Phase;
        private System.Windows.Forms.Button btn_ImportQuestion;
        private System.Windows.Forms.Button btn_DeleteQuestion;
        private System.Windows.Forms.ImageList imageList1;
    }
}
