namespace E_Commerce
{
    partial class profile
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
            this.backbtn = new System.Windows.Forms.Button();
            this.infobtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.backbtn.Location = new System.Drawing.Point(460, 565);
            this.backbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(227, 66);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "Back to Welcome Page";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // infobtn
            // 
            this.infobtn.BackColor = System.Drawing.Color.White;
            this.infobtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infobtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.infobtn.Location = new System.Drawing.Point(216, 161);
            this.infobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(302, 105);
            this.infobtn.TabIndex = 4;
            this.infobtn.Text = "User Information";
            this.infobtn.UseVisualStyleBackColor = false;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::E_Commerce.Properties.Resources.Screenshot_2023_05_21_0030401;
            this.pictureBox1.Location = new System.Drawing.Point(739, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 654);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1441, 656);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.infobtn);
            this.Controls.Add(this.backbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button infobtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}