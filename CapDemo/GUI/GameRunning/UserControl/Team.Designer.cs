namespace CapDemo
{
    partial class Team
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
            this.lbl_TeamName = new System.Windows.Forms.Label();
            this.lbl_TeamScore = new System.Windows.Forms.Label();
            this.lbl_CurrentPhase = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tháchĐấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.câuHỏiQuảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ShowMenu = new System.Windows.Forms.Label();
            this.lbl_TeamID = new System.Windows.Forms.Label();
            this.lbl_Sequence = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TeamName
            // 
            this.lbl_TeamName.AutoSize = true;
            this.lbl_TeamName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamName.Location = new System.Drawing.Point(2, 27);
            this.lbl_TeamName.Name = "lbl_TeamName";
            this.lbl_TeamName.Size = new System.Drawing.Size(40, 13);
            this.lbl_TeamName.TabIndex = 0;
            this.lbl_TeamName.Text = "Name";
            // 
            // lbl_TeamScore
            // 
            this.lbl_TeamScore.AutoSize = true;
            this.lbl_TeamScore.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamScore.Location = new System.Drawing.Point(2, 49);
            this.lbl_TeamScore.Name = "lbl_TeamScore";
            this.lbl_TeamScore.Size = new System.Drawing.Size(40, 13);
            this.lbl_TeamScore.TabIndex = 1;
            this.lbl_TeamScore.Text = "Score";
            // 
            // lbl_CurrentPhase
            // 
            this.lbl_CurrentPhase.AutoSize = true;
            this.lbl_CurrentPhase.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPhase.Location = new System.Drawing.Point(2, 75);
            this.lbl_CurrentPhase.Name = "lbl_CurrentPhase";
            this.lbl_CurrentPhase.Size = new System.Drawing.Size(41, 13);
            this.lbl_CurrentPhase.TabIndex = 2;
            this.lbl_CurrentPhase.Text = "Phase";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tháchĐấuToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.câuHỏiQuảnLýToolStripMenuItem});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 70);
            // 
            // tháchĐấuToolStripMenuItem
            // 
            this.tháchĐấuToolStripMenuItem.CheckOnClick = true;
            this.tháchĐấuToolStripMenuItem.Name = "tháchĐấuToolStripMenuItem";
            this.tháchĐấuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tháchĐấuToolStripMenuItem.Text = "Thách Đấu";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.CheckOnClick = true;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // câuHỏiQuảnLýToolStripMenuItem
            // 
            this.câuHỏiQuảnLýToolStripMenuItem.CheckOnClick = true;
            this.câuHỏiQuảnLýToolStripMenuItem.Name = "câuHỏiQuảnLýToolStripMenuItem";
            this.câuHỏiQuảnLýToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.câuHỏiQuảnLýToolStripMenuItem.Text = "Câu hỏi Quản lý";
            // 
            // lbl_ShowMenu
            // 
            this.lbl_ShowMenu.AutoSize = true;
            this.lbl_ShowMenu.Location = new System.Drawing.Point(6, 134);
            this.lbl_ShowMenu.Name = "lbl_ShowMenu";
            this.lbl_ShowMenu.Size = new System.Drawing.Size(41, 13);
            this.lbl_ShowMenu.TabIndex = 6;
            this.lbl_ShowMenu.Text = "label2";
            this.lbl_ShowMenu.Click += new System.EventHandler(this.lbl_ShowMenu_Click);
            // 
            // lbl_TeamID
            // 
            this.lbl_TeamID.AutoSize = true;
            this.lbl_TeamID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamID.Location = new System.Drawing.Point(213, 0);
            this.lbl_TeamID.Name = "lbl_TeamID";
            this.lbl_TeamID.Size = new System.Drawing.Size(17, 13);
            this.lbl_TeamID.TabIndex = 7;
            this.lbl_TeamID.Text = "id";
            this.lbl_TeamID.Visible = false;
            // 
            // lbl_Sequence
            // 
            this.lbl_Sequence.AutoSize = true;
            this.lbl_Sequence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sequence.Location = new System.Drawing.Point(208, 134);
            this.lbl_Sequence.Name = "lbl_Sequence";
            this.lbl_Sequence.Size = new System.Drawing.Size(22, 13);
            this.lbl_Sequence.TabIndex = 8;
            this.lbl_Sequence.Text = "Se";
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.lbl_Sequence);
            this.Controls.Add(this.lbl_TeamID);
            this.Controls.Add(this.lbl_ShowMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_CurrentPhase);
            this.Controls.Add(this.lbl_TeamScore);
            this.Controls.Add(this.lbl_TeamName);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Team";
            this.Size = new System.Drawing.Size(233, 150);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tháchĐấuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem câuHỏiQuảnLýToolStripMenuItem;
        public System.Windows.Forms.Label lbl_TeamName;
        public System.Windows.Forms.Label lbl_TeamScore;
        public System.Windows.Forms.Label lbl_CurrentPhase;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lbl_ShowMenu;
        public System.Windows.Forms.Label lbl_TeamID;
        public System.Windows.Forms.Label lbl_Sequence;

    }
}
