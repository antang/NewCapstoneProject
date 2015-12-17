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
            this.lbl_SequencePlayer = new System.Windows.Forms.Label();
            this.txt_Point = new System.Windows.Forms.TextBox();
            this.lbl_IDPlayer = new System.Windows.Forms.Label();
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
            // lbl_SequencePlayer
            // 
            this.lbl_SequencePlayer.AutoSize = true;
            this.lbl_SequencePlayer.Location = new System.Drawing.Point(0, 0);
            this.lbl_SequencePlayer.Name = "lbl_SequencePlayer";
            this.lbl_SequencePlayer.Size = new System.Drawing.Size(18, 13);
            this.lbl_SequencePlayer.TabIndex = 1;
            this.lbl_SequencePlayer.Text = "se";
            this.lbl_SequencePlayer.Visible = false;
            // 
            // txt_Point
            // 
            this.txt_Point.Enabled = false;
            this.txt_Point.Location = new System.Drawing.Point(0, 325);
            this.txt_Point.Multiline = true;
            this.txt_Point.Name = "txt_Point";
            this.txt_Point.Size = new System.Drawing.Size(90, 25);
            this.txt_Point.TabIndex = 2;
            this.txt_Point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_IDPlayer
            // 
            this.lbl_IDPlayer.AutoSize = true;
            this.lbl_IDPlayer.Location = new System.Drawing.Point(41, 0);
            this.lbl_IDPlayer.Name = "lbl_IDPlayer";
            this.lbl_IDPlayer.Size = new System.Drawing.Size(15, 13);
            this.lbl_IDPlayer.TabIndex = 3;
            this.lbl_IDPlayer.Text = "id";
            this.lbl_IDPlayer.Visible = false;
            // 
            // Player_Lane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.Controls.Add(this.lbl_IDPlayer);
            this.Controls.Add(this.txt_Point);
            this.Controls.Add(this.lbl_SequencePlayer);
            this.Controls.Add(this.btn_Player);
            this.Name = "Player_Lane";
            this.Size = new System.Drawing.Size(90, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Player;
        public System.Windows.Forms.Label lbl_SequencePlayer;
        public System.Windows.Forms.TextBox txt_Point;
        public System.Windows.Forms.Label lbl_IDPlayer;
    }
}
