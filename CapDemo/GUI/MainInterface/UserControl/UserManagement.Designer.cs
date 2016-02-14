namespace CapDemo.GUI.User_Controls
{
    partial class UserManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgv_UserManagement = new System.Windows.Forms.DataGridView();
            this.lbl_Create = new System.Windows.Forms.Label();
            this.btn_SearchCatalogue = new System.Windows.Forms.Button();
            this.txt_SearchCatalogue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(27, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(450, 33);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Danh sách tài khoản người dùng";
            // 
            // dgv_UserManagement
            // 
            this.dgv_UserManagement.AllowUserToAddRows = false;
            this.dgv_UserManagement.AllowUserToDeleteRows = false;
            this.dgv_UserManagement.AllowUserToResizeColumns = false;
            this.dgv_UserManagement.AllowUserToResizeRows = false;
            this.dgv_UserManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_UserManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UserManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgv_UserManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UserManagement.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UserManagement.Location = new System.Drawing.Point(33, 126);
            this.dgv_UserManagement.Name = "dgv_UserManagement";
            this.dgv_UserManagement.ReadOnly = true;
            this.dgv_UserManagement.RowHeadersVisible = false;
            this.dgv_UserManagement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_UserManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserManagement.Size = new System.Drawing.Size(632, 414);
            this.dgv_UserManagement.TabIndex = 11;
            // 
            // lbl_Create
            // 
            this.lbl_Create.AutoSize = true;
            this.lbl_Create.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Create.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Create.ForeColor = System.Drawing.Color.White;
            this.lbl_Create.Location = new System.Drawing.Point(29, 100);
            this.lbl_Create.Name = "lbl_Create";
            this.lbl_Create.Size = new System.Drawing.Size(180, 23);
            this.lbl_Create.TabIndex = 12;
            this.lbl_Create.Text = "+ Tạo tài khoản mới";
            this.lbl_Create.Click += new System.EventHandler(this.lbl_Create_Click);
            // 
            // btn_SearchCatalogue
            // 
            this.btn_SearchCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchCatalogue.BackgroundImage = global::CapDemo.Properties.Resources.search2;
            this.btn_SearchCatalogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SearchCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchCatalogue.ImageIndex = 3;
            this.btn_SearchCatalogue.Location = new System.Drawing.Point(352, 95);
            this.btn_SearchCatalogue.Name = "btn_SearchCatalogue";
            this.btn_SearchCatalogue.Size = new System.Drawing.Size(35, 26);
            this.btn_SearchCatalogue.TabIndex = 16;
            this.btn_SearchCatalogue.UseVisualStyleBackColor = true;
            // 
            // txt_SearchCatalogue
            // 
            this.txt_SearchCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchCatalogue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchCatalogue.Location = new System.Drawing.Point(393, 95);
            this.txt_SearchCatalogue.Name = "txt_SearchCatalogue";
            this.txt_SearchCatalogue.Size = new System.Drawing.Size(272, 26);
            this.txt_SearchCatalogue.TabIndex = 15;
            this.txt_SearchCatalogue.TextChanged += new System.EventHandler(this.txt_SearchCatalogue_TextChanged);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btn_SearchCatalogue);
            this.Controls.Add(this.txt_SearchCatalogue);
            this.Controls.Add(this.lbl_Create);
            this.Controls.Add(this.dgv_UserManagement);
            this.Controls.Add(this.lbl1);
            this.Name = "UserManagement";
            this.Size = new System.Drawing.Size(710, 584);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgv_UserManagement;
        public System.Windows.Forms.Label lbl_Create;
        private System.Windows.Forms.Button btn_SearchCatalogue;
        private System.Windows.Forms.TextBox txt_SearchCatalogue;
    }
}
