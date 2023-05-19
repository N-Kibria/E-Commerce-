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
            this.btnneworder = new System.Windows.Forms.Button();
            this.lblitemsordered = new System.Windows.Forms.Label();
            this.btnaddtoorder = new System.Windows.Forms.Button();
            this.dudproducts = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtorderaddsress = new System.Windows.Forms.TextBox();
            this.shoppingtab = new System.Windows.Forms.TabPage();
            this.lblcost = new System.Windows.Forms.Label();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.mailtab = new System.Windows.Forms.TabPage();
            this.mailinglabel = new System.Windows.Forms.Label();
            this.ordertab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.shoppingtab.SuspendLayout();
            this.mailtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordertab
            // 
            this.ordertab.Controls.Add(this.tabPage1);
            this.ordertab.Controls.Add(this.shoppingtab);
            this.ordertab.Controls.Add(this.mailtab);
            this.ordertab.Location = new System.Drawing.Point(72, 41);
            this.ordertab.Name = "ordertab";
            this.ordertab.SelectedIndex = 0;
            this.ordertab.Size = new System.Drawing.Size(656, 369);
            this.ordertab.TabIndex = 1;
            this.ordertab.SelectedIndexChanged += new System.EventHandler(this.ordertab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnneworder);
            this.tabPage1.Controls.Add(this.lblitemsordered);
            this.tabPage1.Controls.Add(this.btnaddtoorder);
            this.tabPage1.Controls.Add(this.dudproducts);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtorderaddsress);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Order Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnneworder
            // 
            this.btnneworder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnneworder.Location = new System.Drawing.Point(20, 295);
            this.btnneworder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnneworder.Name = "btnneworder";
            this.btnneworder.Size = new System.Drawing.Size(152, 31);
            this.btnneworder.TabIndex = 5;
            this.btnneworder.Text = "New order";
            this.btnneworder.UseVisualStyleBackColor = true;
            this.btnneworder.Click += new System.EventHandler(this.btnneworder_Click);
            // 
            // lblitemsordered
            // 
            this.lblitemsordered.AutoSize = true;
            this.lblitemsordered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblitemsordered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemsordered.Location = new System.Drawing.Point(20, 253);
            this.lblitemsordered.Name = "lblitemsordered";
            this.lblitemsordered.Size = new System.Drawing.Size(160, 27);
            this.lblitemsordered.TabIndex = 4;
            this.lblitemsordered.Text = "Items ordered : 0";
            this.lblitemsordered.Click += new System.EventHandler(this.lblitemsordered_Click);
            // 
            // btnaddtoorder
            // 
            this.btnaddtoorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtoorder.Location = new System.Drawing.Point(20, 205);
            this.btnaddtoorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddtoorder.Name = "btnaddtoorder";
            this.btnaddtoorder.Size = new System.Drawing.Size(152, 31);
            this.btnaddtoorder.TabIndex = 3;
            this.btnaddtoorder.Text = "Add to order";
            this.btnaddtoorder.UseVisualStyleBackColor = true;
            this.btnaddtoorder.Click += new System.EventHandler(this.btnaddtoorder_Click);
            // 
            // dudproducts
            // 
            this.dudproducts.Location = new System.Drawing.Point(20, 164);
            this.dudproducts.Name = "dudproducts";
            this.dudproducts.Size = new System.Drawing.Size(228, 22);
            this.dudproducts.TabIndex = 2;
            this.dudproducts.SelectedItemChanged += new System.EventHandler(this.dudproducts_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtorderaddsress
            // 
            this.txtorderaddsress.Location = new System.Drawing.Point(20, 47);
            this.txtorderaddsress.Multiline = true;
            this.txtorderaddsress.Name = "txtorderaddsress";
            this.txtorderaddsress.Size = new System.Drawing.Size(528, 88);
            this.txtorderaddsress.TabIndex = 0;
            this.txtorderaddsress.TextChanged += new System.EventHandler(this.txtorderaddsress_TextChanged);
            // 
            // shoppingtab
            // 
            this.shoppingtab.BackColor = System.Drawing.Color.Transparent;
            this.shoppingtab.Controls.Add(this.lblcost);
            this.shoppingtab.Controls.Add(this.listProducts);
            this.shoppingtab.Location = new System.Drawing.Point(4, 25);
            this.shoppingtab.Name = "shoppingtab";
            this.shoppingtab.Padding = new System.Windows.Forms.Padding(3);
            this.shoppingtab.Size = new System.Drawing.Size(648, 340);
            this.shoppingtab.TabIndex = 1;
            this.shoppingtab.Text = "Shopping Cart";
            // 
            // lblcost
            // 
            this.lblcost.BackColor = System.Drawing.Color.Gainsboro;
            this.lblcost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcost.Location = new System.Drawing.Point(30, 262);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(439, 34);
            this.lblcost.TabIndex = 2;
            this.lblcost.Text = "Total Cost";
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.ItemHeight = 16;
            this.listProducts.Location = new System.Drawing.Point(30, 29);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(439, 212);
            this.listProducts.TabIndex = 0;
            // 
            // mailtab
            // 
            this.mailtab.Controls.Add(this.mailinglabel);
            this.mailtab.Location = new System.Drawing.Point(4, 25);
            this.mailtab.Name = "mailtab";
            this.mailtab.Padding = new System.Windows.Forms.Padding(3);
            this.mailtab.Size = new System.Drawing.Size(648, 340);
            this.mailtab.TabIndex = 2;
            this.mailtab.Text = "Mailing Label";
            this.mailtab.UseVisualStyleBackColor = true;
            // 
            // mailinglabel
            // 
            this.mailinglabel.BackColor = System.Drawing.Color.Snow;
            this.mailinglabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailinglabel.Enabled = false;
            this.mailinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailinglabel.Location = new System.Drawing.Point(31, 31);
            this.mailinglabel.Name = "mailinglabel";
            this.mailinglabel.Size = new System.Drawing.Size(571, 251);
            this.mailinglabel.TabIndex = 3;
            // 
            // cartorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordertab);
            this.Name = "cartorder";
            this.Text = "cartorder";
            this.Load += new System.EventHandler(this.cartorder_Load);
            this.ordertab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.shoppingtab.ResumeLayout(false);
            this.mailtab.ResumeLayout(false);
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
    }
}