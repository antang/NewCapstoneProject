namespace CapDemo
{
    partial class Player_Lane
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
            this.btn_Player = new System.Windows.Forms.Button();
            this.lbl_IDPlayer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Player
            // 
            this.btn_Player.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Player.Location = new System.Drawing.Point(1, 250);
            this.btn_Player.Name = "btn_Player";
            this.btn_Player.Size = new System.Drawing.Size(89, 30);
            this.btn_Player.TabIndex = 0;
            this.btn_Player.Text = "Name Player";
            this.btn_Player.UseVisualStyleBackColor = true;
            // 
            // lbl_IDPlayer
            // 
            this.lbl_IDPlayer.AutoSize = true;
            this.lbl_IDPlayer.Location = new System.Drawing.Point(0, 0);
            this.lbl_IDPlayer.Name = "lbl_IDPlayer";
            this.lbl_IDPlayer.Size = new System.Drawing.Size(35, 13);
            this.lbl_IDPlayer.TabIndex = 1;
            this.lbl_IDPlayer.Text = "label1";
            this.lbl_IDPlayer.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 325);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player_Lane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_IDPlayer);
            this.Controls.Add(this.btn_Player);
            this.Name = "Player_Lane";
            this.Size = new System.Drawing.Size(90, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Player;
        public System.Windows.Forms.Label lbl_IDPlayer;
        public System.Windows.Forms.TextBox textBox1;
    }
}
