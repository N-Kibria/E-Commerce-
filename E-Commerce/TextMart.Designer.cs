﻿namespace E_Commerce
{
    partial class TextMart
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
            this.listViewfile = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewfile
            // 
            this.listViewfile.BackColor = System.Drawing.SystemColors.Info;
            this.listViewfile.HideSelection = false;
            this.listViewfile.Location = new System.Drawing.Point(-11, 33);
            this.listViewfile.Name = "listViewfile";
            this.listViewfile.Size = new System.Drawing.Size(963, 553);
            this.listViewfile.TabIndex = 2;
            this.listViewfile.UseCompatibleStateImageBehavior = false;
            this.listViewfile.SelectedIndexChanged += new System.EventHandler(this.listViewfile_SelectedIndexChanged);
            this.listViewfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewfile_MouseClick);
            this.listViewfile.MouseCaptureChanged += new System.EventHandler(this.listViewfile_MouseCaptureChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(880, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back to Order here Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::E_Commerce.Properties.Resources.Screenshot_2023_05_21_0204281;
            this.pictureBox1.ImageLocation = "1063, 606";
            this.pictureBox1.Location = new System.Drawing.Point(958, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 288);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TextMart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1424, 687);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewfile);
            this.Name = "TextMart";
            this.Text = "TextMart product list";
            this.Load += new System.EventHandler(this.TextMart_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextMart_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}