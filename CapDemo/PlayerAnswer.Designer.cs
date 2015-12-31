namespace CapDemo
{
    partial class PlayerAnswer
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
            this.pb_TeamShirt = new System.Windows.Forms.PictureBox();
            this.lbl_TeamAnswer = new System.Windows.Forms.Label();
            this.lbl_IDPlayer = new System.Windows.Forms.Label();
            this.lbl_Check = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_TeamShirt
            // 
            this.pb_TeamShirt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_TeamShirt.BackgroundImage = global::CapDemo.Properties.Resources.ao_lon;
            this.pb_TeamShirt.Location = new System.Drawing.Point(31, 0);
            this.pb_TeamShirt.Name = "pb_TeamShirt";
            this.pb_TeamShirt.Size = new System.Drawing.Size(72, 80);
            this.pb_TeamShirt.TabIndex = 0;
            this.pb_TeamShirt.TabStop = false;
            // 
            // lbl_TeamAnswer
            // 
            this.lbl_TeamAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeamAnswer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamAnswer.ForeColor = System.Drawing.Color.White;
            this.lbl_TeamAnswer.Location = new System.Drawing.Point(3, 83);
            this.lbl_TeamAnswer.Name = "lbl_TeamAnswer";
            this.lbl_TeamAnswer.Size = new System.Drawing.Size(141, 27);
            this.lbl_TeamAnswer.TabIndex = 1;
            this.lbl_TeamAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IDPlayer
            // 
            this.lbl_IDPlayer.AutoSize = true;
            this.lbl_IDPlayer.Location = new System.Drawing.Point(4, 21);
            this.lbl_IDPlayer.Name = "lbl_IDPlayer";
            this.lbl_IDPlayer.Size = new System.Drawing.Size(0, 13);
            this.lbl_IDPlayer.TabIndex = 2;
            this.lbl_IDPlayer.Visible = false;
            // 
            // lbl_Check
            // 
            this.lbl_Check.AutoSize = true;
            this.lbl_Check.Location = new System.Drawing.Point(110, 21);
            this.lbl_Check.Name = "lbl_Check";
            this.lbl_Check.Size = new System.Drawing.Size(0, 13);
            this.lbl_Check.TabIndex = 3;
            this.lbl_Check.Visible = false;
            // 
            // PlayerAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Check);
            this.Controls.Add(this.lbl_IDPlayer);
            this.Controls.Add(this.lbl_TeamAnswer);
            this.Controls.Add(this.pb_TeamShirt);
            this.Name = "PlayerAnswer";
            this.Size = new System.Drawing.Size(144, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pb_TeamShirt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_TeamShirt;
        public System.Windows.Forms.Label lbl_TeamAnswer;
        public System.Windows.Forms.Label lbl_IDPlayer;
        public System.Windows.Forms.Label lbl_Check;

    }
}
