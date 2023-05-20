namespace E_Commerce
{
    partial class cartorder
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
            this.ordertab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dudsize = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.contacttextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.btnneworder = new System.Windows.Forms.Button();
            this.lblitemsordered = new System.Windows.Forms.Label();
            this.btnaddtoorder = new System.Windows.Forms.Button();
            this.dudproducts = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtorderaddsress = new System.Windows.Forms.TextBox();
            this.shoppingtab = new System.Windows.Forms.TabPage();
            this.listsize = new System.Windows.Forms.ListBox();
            this.lblcost = new System.Windows.Forms.Label();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.mailtab = new System.Windows.Forms.TabPage();
            this.contactlabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mailinglabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ordertab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.shoppingtab.SuspendLayout();
            this.mailtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ordertab
            // 
            this.ordertab.Controls.Add(this.tabPage1);
            this.ordertab.Controls.Add(this.shoppingtab);
            this.ordertab.Controls.Add(this.mailtab);
            this.ordertab.Location = new System.Drawing.Point(351, 97);
            this.ordertab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ordertab.Name = "ordertab";
            this.ordertab.SelectedIndex = 0;
            this.ordertab.Size = new System.Drawing.Size(738, 461);
            this.ordertab.TabIndex = 1;
            this.ordertab.SelectedIndexChanged += new System.EventHandler(this.ordertab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.dudsize);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.contacttextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.emailtextBox);
            this.tabPage1.Controls.Add(this.btnneworder);
            this.tabPage1.Controls.Add(this.lblitemsordered);
            this.tabPage1.Controls.Add(this.btnaddtoorder);
            this.tabPage1.Controls.Add(this.dudproducts);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtorderaddsress);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Info;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(730, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Order Form";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dudsize
            // 
            this.dudsize.Location = new System.Drawing.Point(328, 205);
            this.dudsize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dudsize.Name = "dudsize";
            this.dudsize.Size = new System.Drawing.Size(256, 26);
            this.dudsize.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(246, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contact no";
            // 
            // contacttextBox
            // 
            this.contacttextBox.Location = new System.Drawing.Point(252, 134);
            this.contacttextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contacttextBox.Multiline = true;
            this.contacttextBox.Name = "contacttextBox";
            this.contacttextBox.Size = new System.Drawing.Size(450, 34);
            this.contacttextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(246, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email Address ";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(251, 59);
            this.emailtextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailtextBox.Multiline = true;
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(451, 32);
            this.emailtextBox.TabIndex = 6;
            // 
            // btnneworder
            // 
            this.btnneworder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnneworder.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnneworder.Location = new System.Drawing.Point(22, 369);
            this.btnneworder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnneworder.Name = "btnneworder";
            this.btnneworder.Size = new System.Drawing.Size(171, 39);
            this.btnneworder.TabIndex = 5;
            this.btnneworder.Text = "New order";
            this.btnneworder.UseVisualStyleBackColor = true;
            this.btnneworder.Click += new System.EventHandler(this.btnneworder_Click);
            // 
            // lblitemsordered
            // 
            this.lblitemsordered.AutoSize = true;
            this.lblitemsordered.BackColor = System.Drawing.Color.LightGray;
            this.lblitemsordered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblitemsordered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemsordered.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblitemsordered.Location = new System.Drawing.Point(22, 316);
            this.lblitemsordered.Name = "lblitemsordered";
            this.lblitemsordered.Size = new System.Drawing.Size(196, 31);
            this.lblitemsordered.TabIndex = 4;
            this.lblitemsordered.Text = "Items ordered : 0";
            this.lblitemsordered.Click += new System.EventHandler(this.lblitemsordered_Click);
            // 
            // btnaddtoorder
            // 
            this.btnaddtoorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtoorder.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnaddtoorder.Location = new System.Drawing.Point(22, 256);
            this.btnaddtoorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddtoorder.Name = "btnaddtoorder";
            this.btnaddtoorder.Size = new System.Drawing.Size(171, 39);
            this.btnaddtoorder.TabIndex = 3;
            this.btnaddtoorder.Text = "Add to order";
            this.btnaddtoorder.UseVisualStyleBackColor = true;
            this.btnaddtoorder.Click += new System.EventHandler(this.btnaddtoorder_Click);
            // 
            // dudproducts
            // 
            this.dudproducts.Location = new System.Drawing.Point(22, 205);
            this.dudproducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dudproducts.Name = "dudproducts";
            this.dudproducts.Size = new System.Drawing.Size(256, 26);
            this.dudproducts.TabIndex = 2;
            this.dudproducts.SelectedItemChanged += new System.EventHandler(this.dudproducts_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Address ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtorderaddsress
            // 
            this.txtorderaddsress.Location = new System.Drawing.Point(22, 59);
            this.txtorderaddsress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtorderaddsress.Multiline = true;
            this.txtorderaddsress.Name = "txtorderaddsress";
            this.txtorderaddsress.Size = new System.Drawing.Size(199, 109);
            this.txtorderaddsress.TabIndex = 0;
            this.txtorderaddsress.TextChanged += new System.EventHandler(this.txtorderaddsress_TextChanged);
            // 
            // shoppingtab
            // 
            this.shoppingtab.BackColor = System.Drawing.Color.Transparent;
            this.shoppingtab.Controls.Add(this.listsize);
            this.shoppingtab.Controls.Add(this.lblcost);
            this.shoppingtab.Controls.Add(this.listProducts);
            this.shoppingtab.Location = new System.Drawing.Point(4, 29);
            this.shoppingtab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shoppingtab.Name = "shoppingtab";
            this.shoppingtab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shoppingtab.Size = new System.Drawing.Size(730, 428);
            this.shoppingtab.TabIndex = 1;
            this.shoppingtab.Text = "Shopping Cart";
            // 
            // listsize
            // 
            this.listsize.FormattingEnabled = true;
            this.listsize.ItemHeight = 20;
            this.listsize.Location = new System.Drawing.Point(34, 185);
            this.listsize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listsize.Name = "listsize";
            this.listsize.Size = new System.Drawing.Size(565, 124);
            this.listsize.TabIndex = 4;
            // 
            // lblcost
            // 
            this.lblcost.BackColor = System.Drawing.Color.Gainsboro;
            this.lblcost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcost.Location = new System.Drawing.Point(34, 329);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(494, 42);
            this.lblcost.TabIndex = 2;
            this.lblcost.Text = "Total Cost";
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.ItemHeight = 20;
            this.listProducts.Location = new System.Drawing.Point(34, 36);
            this.listProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(565, 124);
            this.listProducts.TabIndex = 0;
            // 
            // mailtab
            // 
            this.mailtab.Controls.Add(this.contactlabel);
            this.mailtab.Controls.Add(this.emaillabel);
            this.mailtab.Controls.Add(this.button1);
            this.mailtab.Controls.Add(this.mailinglabel);
            this.mailtab.Location = new System.Drawing.Point(4, 29);
            this.mailtab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailtab.Name = "mailtab";
            this.mailtab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailtab.Size = new System.Drawing.Size(730, 428);
            this.mailtab.TabIndex = 2;
            this.mailtab.Text = "Mailing Label";
            this.mailtab.UseVisualStyleBackColor = true;
            // 
            // contactlabel
            // 
            this.contactlabel.BackColor = System.Drawing.Color.Snow;
            this.contactlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactlabel.Enabled = false;
            this.contactlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlabel.Location = new System.Drawing.Point(35, 236);
            this.contactlabel.Name = "contactlabel";
            this.contactlabel.Size = new System.Drawing.Size(361, 52);
            this.contactlabel.TabIndex = 6;
            // 
            // emaillabel
            // 
            this.emaillabel.BackColor = System.Drawing.Color.Snow;
            this.emaillabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emaillabel.Enabled = false;
            this.emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(35, 162);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(646, 54);
            this.emaillabel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(508, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mailinglabel
            // 
            this.mailinglabel.BackColor = System.Drawing.Color.Snow;
            this.mailinglabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailinglabel.Enabled = false;
            this.mailinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailinglabel.Location = new System.Drawing.Point(35, 39);
            this.mailinglabel.Name = "mailinglabel";
            this.mailinglabel.Size = new System.Drawing.Size(646, 107);
            this.mailinglabel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::E_Commerce.Properties.Resources.rm184_aum_06e1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1441, 659);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cartorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 656);
            this.Controls.Add(this.ordertab);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cartorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cartorder";
            this.Load += new System.EventHandler(this.cartorder_Load);
            this.ordertab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.shoppingtab.ResumeLayout(false);
            this.mailtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ordertab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnneworder;
        private System.Windows.Forms.Label lblitemsordered;
        private System.Windows.Forms.Button btnaddtoorder;
        private System.Windows.Forms.DomainUpDown dudproducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtorderaddsress;
        private System.Windows.Forms.TabPage shoppingtab;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.TabPage mailtab;
        private System.Windows.Forms.Label mailinglabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contacttextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label contactlabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.ListBox listsize;
        private System.Windows.Forms.DomainUpDown dudsize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}