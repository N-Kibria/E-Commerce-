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
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Info;
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(411, 404);
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
            this.infobtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infobtn.Location = new System.Drawing.Point(189, 153);
            this.infobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(295, 101);
            this.infobtn.TabIndex = 4;
            this.infobtn.Text = "User Information";
            this.infobtn.UseVisualStyleBackColor = true;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 550);
            this.Controls.Add(this.infobtn);
            this.Controls.Add(this.backbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button infobtn;
    }
}