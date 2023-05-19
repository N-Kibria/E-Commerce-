﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class cartorder : Form
    {
        public cartorder()
        {
            InitializeComponent();
        }
        int itemsordered;
        const int numberofproducts = 10;
        product[] products = new product[numberofproducts];

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblcost_Click(object sender, EventArgs e)
        {

        }

        private void cartorder_Load(object sender, EventArgs e)
        {
            products[0] = new product("Black Boots", 1500);
            products[1] = new product("Black Converse", 1700.99);
            products[2] = new product("Black High Boots", 2000);
            products[3] = new product("Black Nike Shoes", 1499);
            products[4] = new product("Brown Boots", 1999);
            products[5] = new product("casual Lace Up Sneakers", 2000);
            products[6] = new product("casual Sneakers", 1500);
            products[7] = new product("High Boots", 1800.99);
            products[8] = new product("Nike Shoe", 2000);
            products[9] = new product("pink white sneakers", 1499);
            for (int i = 0; i < numberofproducts; i++)
            {
                dudproducts.Items.Add(products[i].description);
            }
            dudproducts.SelectedIndex = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void btnneworder_Click(object sender, EventArgs e)
        {
            txtorderaddsress.Text = "";
            itemsordered = 0;
            lblitemsordered.Text = "Items Ordered: 0";

            for (int i = 0; i < numberofproducts; i++)
            {
                products[i].numberordered = 0;
            }
            dudproducts.SelectedIndex = 0;
            listProducts.Items.Clear();
            lblcost.Text = "Total Cost";
            mailinglabel.Text = "";

        }

        private void btnaddtoorder_Click(object sender, EventArgs e)
        {
            products[dudproducts.SelectedIndex].numberordered++;
            itemsordered++;
            lblitemsordered.Text = "Items Ordered: " + itemsordered.ToString();
        }

        private void tabcartorder_selectedIndexChanged(object sender, EventArgs e)
        {
            switch (ordertab.SelectedIndex)
            {
                case 1:
                    if (itemsordered == 0)
                    {
                        MessageBox.Show("No items were ordered,", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ordertab.SelectedIndex = 0;
                    }
                    else
                    {
                        double totalcost = 0;
                        listProducts.Items.Clear();
                        for (int i = 0; i < numberofproducts; i++)
                        {
                            if (products[i].numberordered != 0)
                            {
                                listProducts.Items.Add(products[i].numberordered.ToString() + " " + products[i].description);
                                totalcost += products[i].cost * products[i].numberordered;
                            }
                        }
                        lblcost.Text = "Total Cost: $" + string.Format("{0:f2}", totalcost);
                    }
                    break;
                case 2:
                    if (txtorderaddsress.Text == "")
                    {
                        MessageBox.Show("No address was entered,", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ordertab.SelectedIndex = 0;
                        txtorderaddsress.Focus();
                    }
                    else
                    {
                        string address = txtorderaddsress.Text;
                        mailinglabel.Text = address;
                    }
                    break;


            }
        }
    }
}