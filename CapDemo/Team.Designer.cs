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
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tháchĐấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.câuHỏiQuảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TeamName
            // 
            this.lbl_TeamName.AutoSize = true;
            this.lbl_TeamName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamName.Location = new System.Drawing.Point(3, 13);
            this.lbl_TeamName.Name = "lbl_TeamName";
            this.lbl_TeamName.Size = new System.Drawing.Size(40, 13);
            this.lbl_TeamName.TabIndex = 0;
            this.lbl_TeamName.Text = "Name";
            // 
            // lbl_TeamScore
            // 
            this.lbl_TeamScore.AutoSize = true;
            this.lbl_TeamScore.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamScore.Location = new System.Drawing.Point(3, 35);
            this.lbl_TeamScore.Name = "lbl_TeamScore";
            this.lbl_TeamScore.Size = new System.Drawing.Size(40, 13);
            this.lbl_TeamScore.TabIndex = 1;
            this.lbl_TeamScore.Text = "Score";
            // 
            // lbl_CurrentPhase
            // 
            this.lbl_CurrentPhase.AutoSize = true;
            this.lbl_CurrentPhase.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPhase.Location = new System.Drawing.Point(7, 58);
            this.lbl_CurrentPhase.Name = "lbl_CurrentPhase";
            this.lbl_CurrentPhase.Size = new System.Drawing.Size(41, 13);
            this.lbl_CurrentPhase.TabIndex = 2;
            this.lbl_CurrentPhase.Text = "Phase";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(71, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 21);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(9, 86);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(35, 13);
            this.lbl_Time.TabIndex = 4;
            this.lbl_Time.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tháchĐấuToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.câuHỏiQuảnLýToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 92);
            // 
            // tháchĐấuToolStripMenuItem
            // 
            this.tháchĐấuToolStripMenuItem.Name = "tháchĐấuToolStripMenuItem";
            this.tháchĐấuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tháchĐấuToolStripMenuItem.Text = "Thách Đấu";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // câuHỏiQuảnLýToolStripMenuItem
            // 
            this.câuHỏiQuảnLýToolStripMenuItem.Name = "câuHỏiQuảnLýToolStripMenuItem";
            this.câuHỏiQuảnLýToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.câuHỏiQuảnLýToolStripMenuItem.Text = "Câu hỏi Quản lý";
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Time);
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

        private System.Windows.Forms.Label lbl_TeamName;
        private System.Windows.Forms.Label lbl_TeamScore;
        private System.Windows.Forms.Label lbl_CurrentPhase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tháchĐấuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem câuHỏiQuảnLýToolStripMenuItem;

    }
}
