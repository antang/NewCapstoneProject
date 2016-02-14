namespace CapDemo
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.flp_TeamEndGame = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_TeamEndGame
            // 
            this.flp_TeamEndGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flp_TeamEndGame.BackColor = System.Drawing.Color.Transparent;
            this.flp_TeamEndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_TeamEndGame.Location = new System.Drawing.Point(238, 136);
            this.flp_TeamEndGame.Name = "flp_TeamEndGame";
            this.flp_TeamEndGame.Size = new System.Drawing.Size(534, 541);
            this.flp_TeamEndGame.TabIndex = 1;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapDemo.Properties.Resources.Congratulation_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.flp_TeamEndGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả thi đấu";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flp_TeamEndGame;
    }
}