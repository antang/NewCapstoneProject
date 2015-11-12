namespace CapDemo.GUI.User_Controls
{
    partial class DataManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataManagement));
            this.tbc_DataManagement = new System.Windows.Forms.TabControl();
            this.tbp_CatalogueManagement = new System.Windows.Forms.TabPage();
            this.btn_SearchCatalogue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ViewQuestion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_ImportQuestion = new System.Windows.Forms.Button();
            this.btn_EditCatalogue = new System.Windows.Forms.Button();
            this.btn_DeleteCatalogue = new System.Windows.Forms.Button();
            this.txt_SearchCatalogue = new System.Windows.Forms.TextBox();
            this.dgv_Catalogue = new System.Windows.Forms.DataGridView();
            this.lbl_CreateCatalogue = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbp_QuestionManagement = new System.Windows.Forms.TabPage();
            this.lbl_ImportQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SearchQuestion = new System.Windows.Forms.Button();
            this.txt_SearchQuestion = new System.Windows.Forms.TextBox();
            this.dgv_Question = new System.Windows.Forms.DataGridView();
            this.lbl_CreateQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_FunctionQuestion = new System.Windows.Forms.GroupBox();
            this.btn_CopyQuestion = new System.Windows.Forms.Button();
            this.btn_MoveQuestion = new System.Windows.Forms.Button();
            this.btn_EditQuestion = new System.Windows.Forms.Button();
            this.btn_DeleteQuestion = new System.Windows.Forms.Button();
            this.tbc_DataManagement.SuspendLayout();
            this.tbp_CatalogueManagement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Catalogue)).BeginInit();
            this.tbp_QuestionManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question)).BeginInit();
            this.grb_FunctionQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_DataManagement
            // 
            this.tbc_DataManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_DataManagement.Controls.Add(this.tbp_CatalogueManagement);
            this.tbc_DataManagement.Controls.Add(this.tbp_QuestionManagement);
            this.tbc_DataManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_DataManagement.Location = new System.Drawing.Point(0, 0);
            this.tbc_DataManagement.Name = "tbc_DataManagement";
            this.tbc_DataManagement.SelectedIndex = 0;
            this.tbc_DataManagement.Size = new System.Drawing.Size(719, 584);
            this.tbc_DataManagement.TabIndex = 0;
            // 
            // tbp_CatalogueManagement
            // 
            this.tbp_CatalogueManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbp_CatalogueManagement.Controls.Add(this.btn_SearchCatalogue);
            this.tbp_CatalogueManagement.Controls.Add(this.groupBox1);
            this.tbp_CatalogueManagement.Controls.Add(this.txt_SearchCatalogue);
            this.tbp_CatalogueManagement.Controls.Add(this.dgv_Catalogue);
            this.tbp_CatalogueManagement.Controls.Add(this.lbl_CreateCatalogue);
            this.tbp_CatalogueManagement.Controls.Add(this.lbl1);
            this.tbp_CatalogueManagement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp_CatalogueManagement.Location = new System.Drawing.Point(4, 29);
            this.tbp_CatalogueManagement.Name = "tbp_CatalogueManagement";
            this.tbp_CatalogueManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_CatalogueManagement.Size = new System.Drawing.Size(711, 551);
            this.tbp_CatalogueManagement.TabIndex = 0;
            this.tbp_CatalogueManagement.Text = "Quản lý chủ đề";
            // 
            // btn_SearchCatalogue
            // 
            this.btn_SearchCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchCatalogue.BackgroundImage = global::CapDemo.Properties.Resources.search2;
            this.btn_SearchCatalogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SearchCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchCatalogue.ImageIndex = 3;
            this.btn_SearchCatalogue.Location = new System.Drawing.Point(395, 74);
            this.btn_SearchCatalogue.Name = "btn_SearchCatalogue";
            this.btn_SearchCatalogue.Size = new System.Drawing.Size(35, 30);
            this.btn_SearchCatalogue.TabIndex = 14;
            this.btn_SearchCatalogue.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_ViewQuestion);
            this.groupBox1.Controls.Add(this.btn_ImportQuestion);
            this.groupBox1.Controls.Add(this.btn_EditCatalogue);
            this.groupBox1.Controls.Add(this.btn_DeleteCatalogue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(63, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 88);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng cho chủ đề";
            // 
            // btn_ViewQuestion
            // 
            this.btn_ViewQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ViewQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ViewQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ViewQuestion.ImageIndex = 2;
            this.btn_ViewQuestion.ImageList = this.imageList1;
            this.btn_ViewQuestion.Location = new System.Drawing.Point(6, 26);
            this.btn_ViewQuestion.Name = "btn_ViewQuestion";
            this.btn_ViewQuestion.Size = new System.Drawing.Size(144, 47);
            this.btn_ViewQuestion.TabIndex = 35;
            this.btn_ViewQuestion.Text = "Xem Câu Hỏi";
            this.btn_ViewQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ViewQuestion.UseVisualStyleBackColor = false;
            this.btn_ViewQuestion.Click += new System.EventHandler(this.btn_ViewQuestion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            this.imageList1.Images.SetKeyName(1, "red-edit-icon-glossy-md.png");
            this.imageList1.Images.SetKeyName(2, "review.png");
            this.imageList1.Images.SetKeyName(3, "copy.png");
            this.imageList1.Images.SetKeyName(4, "move.png");
            // 
            // btn_ImportQuestion
            // 
            this.btn_ImportQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ImportQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ImportQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ImportQuestion.ImageIndex = 4;
            this.btn_ImportQuestion.ImageList = this.imageList1;
            this.btn_ImportQuestion.Location = new System.Drawing.Point(156, 26);
            this.btn_ImportQuestion.Name = "btn_ImportQuestion";
            this.btn_ImportQuestion.Size = new System.Drawing.Size(146, 47);
            this.btn_ImportQuestion.TabIndex = 34;
            this.btn_ImportQuestion.Text = "Nhập Câu Hỏi";
            this.btn_ImportQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ImportQuestion.UseVisualStyleBackColor = false;
            this.btn_ImportQuestion.Click += new System.EventHandler(this.btn_ImportQuestion_Click);
            // 
            // btn_EditCatalogue
            // 
            this.btn_EditCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EditCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_EditCatalogue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCatalogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_EditCatalogue.ImageIndex = 1;
            this.btn_EditCatalogue.ImageList = this.imageList1;
            this.btn_EditCatalogue.Location = new System.Drawing.Point(308, 26);
            this.btn_EditCatalogue.Name = "btn_EditCatalogue";
            this.btn_EditCatalogue.Size = new System.Drawing.Size(127, 47);
            this.btn_EditCatalogue.TabIndex = 33;
            this.btn_EditCatalogue.Text = "Chỉnh Sữa";
            this.btn_EditCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditCatalogue.UseVisualStyleBackColor = false;
            this.btn_EditCatalogue.Click += new System.EventHandler(this.btn_EditCatalogue_Click);
            // 
            // btn_DeleteCatalogue
            // 
            this.btn_DeleteCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeleteCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_DeleteCatalogue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteCatalogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DeleteCatalogue.ImageIndex = 0;
            this.btn_DeleteCatalogue.ImageList = this.imageList1;
            this.btn_DeleteCatalogue.Location = new System.Drawing.Point(441, 26);
            this.btn_DeleteCatalogue.Name = "btn_DeleteCatalogue";
            this.btn_DeleteCatalogue.Size = new System.Drawing.Size(127, 47);
            this.btn_DeleteCatalogue.TabIndex = 32;
            this.btn_DeleteCatalogue.Text = "Xóa";
            this.btn_DeleteCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeleteCatalogue.UseVisualStyleBackColor = false;
            this.btn_DeleteCatalogue.Click += new System.EventHandler(this.btn_DeleteCatalogue_Click);
            // 
            // txt_SearchCatalogue
            // 
            this.txt_SearchCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchCatalogue.Location = new System.Drawing.Point(436, 75);
            this.txt_SearchCatalogue.Name = "txt_SearchCatalogue";
            this.txt_SearchCatalogue.Size = new System.Drawing.Size(217, 27);
            this.txt_SearchCatalogue.TabIndex = 12;
            // 
            // dgv_Catalogue
            // 
            this.dgv_Catalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Catalogue.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Catalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Catalogue.Location = new System.Drawing.Point(63, 138);
            this.dgv_Catalogue.Name = "dgv_Catalogue";
            this.dgv_Catalogue.Size = new System.Drawing.Size(590, 284);
            this.dgv_Catalogue.TabIndex = 11;
            // 
            // lbl_CreateCatalogue
            // 
            this.lbl_CreateCatalogue.AutoSize = true;
            this.lbl_CreateCatalogue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CreateCatalogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CreateCatalogue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateCatalogue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_CreateCatalogue.Location = new System.Drawing.Point(59, 111);
            this.lbl_CreateCatalogue.Name = "lbl_CreateCatalogue";
            this.lbl_CreateCatalogue.Size = new System.Drawing.Size(161, 23);
            this.lbl_CreateCatalogue.TabIndex = 10;
            this.lbl_CreateCatalogue.Text = "+ Tạo chủ để mới";
            this.lbl_CreateCatalogue.Click += new System.EventHandler(this.lbl_CreateCatalogue_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(57, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(251, 33);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Danh sách chủ đề";
            // 
            // tbp_QuestionManagement
            // 
            this.tbp_QuestionManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbp_QuestionManagement.Controls.Add(this.lbl_ImportQuestion);
            this.tbp_QuestionManagement.Controls.Add(this.label3);
            this.tbp_QuestionManagement.Controls.Add(this.btn_SearchQuestion);
            this.tbp_QuestionManagement.Controls.Add(this.txt_SearchQuestion);
            this.tbp_QuestionManagement.Controls.Add(this.dgv_Question);
            this.tbp_QuestionManagement.Controls.Add(this.lbl_CreateQuestion);
            this.tbp_QuestionManagement.Controls.Add(this.label2);
            this.tbp_QuestionManagement.Controls.Add(this.grb_FunctionQuestion);
            this.tbp_QuestionManagement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp_QuestionManagement.Location = new System.Drawing.Point(4, 29);
            this.tbp_QuestionManagement.Name = "tbp_QuestionManagement";
            this.tbp_QuestionManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_QuestionManagement.Size = new System.Drawing.Size(711, 551);
            this.tbp_QuestionManagement.TabIndex = 1;
            this.tbp_QuestionManagement.Text = "Quản lý câu hỏi";
            // 
            // lbl_ImportQuestion
            // 
            this.lbl_ImportQuestion.AutoSize = true;
            this.lbl_ImportQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ImportQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ImportQuestion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImportQuestion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_ImportQuestion.Location = new System.Drawing.Point(215, 111);
            this.lbl_ImportQuestion.Name = "lbl_ImportQuestion";
            this.lbl_ImportQuestion.Size = new System.Drawing.Size(122, 23);
            this.lbl_ImportQuestion.TabIndex = 22;
            this.lbl_ImportQuestion.Text = "Nhập câu hỏi";
            this.lbl_ImportQuestion.Click += new System.EventHandler(this.lbl_ImportQuestion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(184, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "hoặc";
            // 
            // btn_SearchQuestion
            // 
            this.btn_SearchQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchQuestion.BackgroundImage = global::CapDemo.Properties.Resources.search2;
            this.btn_SearchQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SearchQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchQuestion.ImageIndex = 3;
            this.btn_SearchQuestion.Location = new System.Drawing.Point(395, 74);
            this.btn_SearchQuestion.Name = "btn_SearchQuestion";
            this.btn_SearchQuestion.Size = new System.Drawing.Size(35, 30);
            this.btn_SearchQuestion.TabIndex = 20;
            this.btn_SearchQuestion.UseVisualStyleBackColor = true;
            // 
            // txt_SearchQuestion
            // 
            this.txt_SearchQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchQuestion.Location = new System.Drawing.Point(436, 75);
            this.txt_SearchQuestion.Name = "txt_SearchQuestion";
            this.txt_SearchQuestion.Size = new System.Drawing.Size(217, 27);
            this.txt_SearchQuestion.TabIndex = 18;
            // 
            // dgv_Question
            // 
            this.dgv_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Question.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Question.Location = new System.Drawing.Point(63, 138);
            this.dgv_Question.Name = "dgv_Question";
            this.dgv_Question.Size = new System.Drawing.Size(590, 284);
            this.dgv_Question.TabIndex = 17;
            // 
            // lbl_CreateQuestion
            // 
            this.lbl_CreateQuestion.AutoSize = true;
            this.lbl_CreateQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CreateQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CreateQuestion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateQuestion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_CreateQuestion.Location = new System.Drawing.Point(59, 111);
            this.lbl_CreateQuestion.Name = "lbl_CreateQuestion";
            this.lbl_CreateQuestion.Size = new System.Drawing.Size(128, 23);
            this.lbl_CreateQuestion.TabIndex = 16;
            this.lbl_CreateQuestion.Text = "+ Tạo câu hỏi";
            this.lbl_CreateQuestion.Click += new System.EventHandler(this.lbl_CreateQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Danh sách chủ đề";
            // 
            // grb_FunctionQuestion
            // 
            this.grb_FunctionQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_FunctionQuestion.Controls.Add(this.btn_CopyQuestion);
            this.grb_FunctionQuestion.Controls.Add(this.btn_MoveQuestion);
            this.grb_FunctionQuestion.Controls.Add(this.btn_EditQuestion);
            this.grb_FunctionQuestion.Controls.Add(this.btn_DeleteQuestion);
            this.grb_FunctionQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_FunctionQuestion.ForeColor = System.Drawing.Color.White;
            this.grb_FunctionQuestion.Location = new System.Drawing.Point(63, 431);
            this.grb_FunctionQuestion.Name = "grb_FunctionQuestion";
            this.grb_FunctionQuestion.Size = new System.Drawing.Size(590, 88);
            this.grb_FunctionQuestion.TabIndex = 19;
            this.grb_FunctionQuestion.TabStop = false;
            this.grb_FunctionQuestion.Text = "Chọn chức năng cho chủ đề";
            // 
            // btn_CopyQuestion
            // 
            this.btn_CopyQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CopyQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_CopyQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CopyQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CopyQuestion.ImageIndex = 3;
            this.btn_CopyQuestion.ImageList = this.imageList1;
            this.btn_CopyQuestion.Location = new System.Drawing.Point(6, 26);
            this.btn_CopyQuestion.Name = "btn_CopyQuestion";
            this.btn_CopyQuestion.Size = new System.Drawing.Size(144, 47);
            this.btn_CopyQuestion.TabIndex = 35;
            this.btn_CopyQuestion.Text = "Sao chép câu hỏi";
            this.btn_CopyQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CopyQuestion.UseVisualStyleBackColor = false;
            this.btn_CopyQuestion.Click += new System.EventHandler(this.btn_CopyQuestion_Click);
            // 
            // btn_MoveQuestion
            // 
            this.btn_MoveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_MoveQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_MoveQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MoveQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_MoveQuestion.ImageIndex = 4;
            this.btn_MoveQuestion.ImageList = this.imageList1;
            this.btn_MoveQuestion.Location = new System.Drawing.Point(156, 26);
            this.btn_MoveQuestion.Name = "btn_MoveQuestion";
            this.btn_MoveQuestion.Size = new System.Drawing.Size(146, 47);
            this.btn_MoveQuestion.TabIndex = 34;
            this.btn_MoveQuestion.Text = "Di chuyển câu hỏi";
            this.btn_MoveQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MoveQuestion.UseVisualStyleBackColor = false;
            this.btn_MoveQuestion.Click += new System.EventHandler(this.btn_MoveQuestion_Click);
            // 
            // btn_EditQuestion
            // 
            this.btn_EditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EditQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_EditQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_EditQuestion.ImageIndex = 1;
            this.btn_EditQuestion.ImageList = this.imageList1;
            this.btn_EditQuestion.Location = new System.Drawing.Point(308, 26);
            this.btn_EditQuestion.Name = "btn_EditQuestion";
            this.btn_EditQuestion.Size = new System.Drawing.Size(127, 47);
            this.btn_EditQuestion.TabIndex = 33;
            this.btn_EditQuestion.Text = "Chỉnh Sữa";
            this.btn_EditQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditQuestion.UseVisualStyleBackColor = false;
            this.btn_EditQuestion.Click += new System.EventHandler(this.btn_EditQuestion_Click);
            // 
            // btn_DeleteQuestion
            // 
            this.btn_DeleteQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_DeleteQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DeleteQuestion.ImageIndex = 0;
            this.btn_DeleteQuestion.ImageList = this.imageList1;
            this.btn_DeleteQuestion.Location = new System.Drawing.Point(441, 26);
            this.btn_DeleteQuestion.Name = "btn_DeleteQuestion";
            this.btn_DeleteQuestion.Size = new System.Drawing.Size(127, 47);
            this.btn_DeleteQuestion.TabIndex = 32;
            this.btn_DeleteQuestion.Text = "Xóa";
            this.btn_DeleteQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeleteQuestion.UseVisualStyleBackColor = false;
            // 
            // DataManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbc_DataManagement);
            this.Name = "DataManagement";
            this.Size = new System.Drawing.Size(719, 584);
            this.Load += new System.EventHandler(this.DataManagement_Load);
            this.tbc_DataManagement.ResumeLayout(false);
            this.tbp_CatalogueManagement.ResumeLayout(false);
            this.tbp_CatalogueManagement.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Catalogue)).EndInit();
            this.tbp_QuestionManagement.ResumeLayout(false);
            this.tbp_QuestionManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Question)).EndInit();
            this.grb_FunctionQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_DataManagement;
        private System.Windows.Forms.TabPage tbp_CatalogueManagement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ViewQuestion;
        private System.Windows.Forms.Button btn_ImportQuestion;
        private System.Windows.Forms.Button btn_EditCatalogue;
        private System.Windows.Forms.Button btn_DeleteCatalogue;
        private System.Windows.Forms.TextBox txt_SearchCatalogue;
        private System.Windows.Forms.DataGridView dgv_Catalogue;
        private System.Windows.Forms.Label lbl_CreateCatalogue;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TabPage tbp_QuestionManagement;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_SearchCatalogue;
        private System.Windows.Forms.Label lbl_ImportQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SearchQuestion;
        private System.Windows.Forms.TextBox txt_SearchQuestion;
        private System.Windows.Forms.DataGridView dgv_Question;
        private System.Windows.Forms.Label lbl_CreateQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grb_FunctionQuestion;
        private System.Windows.Forms.Button btn_CopyQuestion;
        private System.Windows.Forms.Button btn_MoveQuestion;
        private System.Windows.Forms.Button btn_EditQuestion;
        private System.Windows.Forms.Button btn_DeleteQuestion;
    }
}
