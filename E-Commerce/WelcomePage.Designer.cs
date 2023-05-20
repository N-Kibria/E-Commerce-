namespace E_Commerce
{
    partial class WelcomePage
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
            this.cartbtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.reviewbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cartbtn
            // 
            this.cartbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartbtn.Location = new System.Drawing.Point(33, 189);
            this.cartbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cartbtn.Name = "cartbtn";
            this.cartbtn.Size = new System.Drawing.Size(205, 81);
            this.cartbtn.TabIndex = 1;
            this.cartbtn.Text = "Cart";
            this.cartbtn.UseVisualStyleBackColor = true;
            this.cartbtn.Click += new System.EventHandler(this.cartbtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.Location = new System.Drawing.Point(33, 64);
            this.profilebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(205, 81);
            this.profilebtn.TabIndex = 2;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // reviewbtn
            // 
            this.reviewbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewbtn.Location = new System.Drawing.Point(33, 319);
            this.reviewbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reviewbtn.Name = "reviewbtn";
            this.reviewbtn.Size = new System.Drawing.Size(205, 81);
            this.reviewbtn.TabIndex = 4;
            this.reviewbtn.Text = "Review";
            this.reviewbtn.UseVisualStyleBackColor = true;
            this.reviewbtn.Click += new System.EventHandler(this.reviewbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 74);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to DESHI DOSH";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reviewbtn);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.cartbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "welcome";
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cartbtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Button reviewbtn;
        private System.Windows.Forms.Label label1;
    }
}