namespace E_Commerce
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // listViewfile
            // 
            this.listViewfile.HideSelection = false;
            this.listViewfile.Location = new System.Drawing.Point(12, 21);
            this.listViewfile.Name = "listViewfile";
            this.listViewfile.Size = new System.Drawing.Size(1166, 585);
            this.listViewfile.TabIndex = 0;
            this.listViewfile.UseCompatibleStateImageBehavior = false;
            this.listViewfile.SelectedIndexChanged += new System.EventHandler(this.listViewfile_SelectedIndexChanged);
            this.listViewfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewfile_MouseClick);
            this.listViewfile.MouseCaptureChanged += new System.EventHandler(this.listViewfile_MouseCaptureChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 676);
            this.Controls.Add(this.listViewfile);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewfile;
    }
}