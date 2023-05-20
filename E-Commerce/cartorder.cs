using System;
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
        private Main_Welcome mainWelcomeForm; // Declare a variable to hold the instance of Main_Welcome form
        public cartorder()
        {
            InitializeComponent();
        }
        int itemsordered;
        int sizenum;
        int c;

        const int numberofproducts = 20;
        const int numberofsize = 4;
        product[] products = new product[numberofproducts];
        productsize[] sizes = new productsize[numberofsize];

        private List<int> orderedSizes = new List<int>();
        public cartorder(Main_Welcome mainWelcomeForm)
        {
            InitializeComponent();
            this.mainWelcomeForm = mainWelcomeForm;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtorderaddsress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dudproducts_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnaddtoorder_Click(object sender, EventArgs e)
        {
            products[dudproducts.SelectedIndex].numberordered++;
            sizes[dudsize.SelectedIndex].sizeordered++;

            itemsordered++;
            sizenum++;

            lblitemsordered.Text = "Items Ordered: " + itemsordered.ToString();


            int selectedSize = sizes[dudsize.SelectedIndex].size;
            if (!orderedSizes.Contains(selectedSize))
            {
                orderedSizes.Add(selectedSize);
                c++;

            }

        }

        private void lblitemsordered_Click(object sender, EventArgs e)
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
            for (int i = 0; i < numberofsize; i++)
            {
                sizes[i].sizeordered = 0;
            }

            dudproducts.SelectedIndex = 0;
            dudsize.SelectedIndex = 0;
            listProducts.Items.Clear();
            listsize.Items.Clear();
            lblcost.Text = "Total Cost";
            mailinglabel.Text = "";

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
            products[10] = new product("Black Handloom Printed And Embroidered Viscose-Cotton Shalwar Kameez Set", 1584);
            products[11] = new product("Burgundy Appliqued Printed And Embroidered Cotton Shalwar kameez set With Coaty", 2560);
            products[12] = new product("Olive Green printed and Embroidered Viscose-Cotton Shalwar Kameez Set", 2500);
            products[13] = new product("Pastel Green Printed and Embroidered Viscose-Cotton Shalwar Kameez", 2300);
            products[14] = new product("Salmon Printed and Embroidered Endi Silk Shalwar Kameez", 2199);
            products[15] = new product("Fine cotton tie collar tailored fit woven shirt  Royal Blue", 2000);
            products[16] = new product("Giza cotton tie collar tailored fit woven formal shirt  Lavender", 2600);
            products[17] = new product("Zaviyar Premium Panjabi  (Batik print)", 1800.99);
            products[18] = new product("Zaviyar Premium Panjabi  Aquamarine", 1700);
            products[19] = new product("Zaviyar Premium Panjabi  Oil Black", 1499);
 sizes[0] = new productsize(36);
            sizes[1] = new productsize(38);
            sizes[2] = new productsize(40);
            sizes[3] = new productsize(42);
           
            for (int i = 0; i < numberofproducts; i++)
            {
                dudproducts.Items.Add(products[i].description);
              
            }
            dudproducts.SelectedIndex = 0;
            for (int i = 0; i < numberofsize; i++)
            {
                dudsize.Items.Add(sizes[i].size);
            }
            
            dudsize.SelectedIndex = 0;
        }

        private void ordertab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ordertab.SelectedIndex)
            {
                case 1:
                    if (itemsordered == 0 && sizenum == 0)
                    {
                        MessageBox.Show("No items were ordered,", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ordertab.SelectedIndex = 0;
                    }
                    else
                    {
                        double totalcost = 0;
                        listProducts.Items.Clear();
                        listsize.Items.Clear();
                        for (int i = 0; i < numberofproducts; i++)
                        {
                            if (products[i].numberordered != 0)
                            {
                                listProducts.Items.Add(products[i].numberordered.ToString() + " " + products[i].description);


                               
                                
                                    listsize.Items.Add(products[i].description + " " + orderedSizes[0]);



                                



                                totalcost += products[i].cost * products[i].numberordered;
                            }
                        }


                        lblcost.Text = "Total Cost: $" + string.Format("{0:f2}", totalcost);
                    }
                    break;
                case 2:
                    if (txtorderaddsress.Text == "" || emailtextBox.Text == "" || contacttextBox.Text == "")
                    {
                        MessageBox.Show("No address or email or contact was entered.", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ordertab.SelectedIndex = 0;
                        txtorderaddsress.Focus();
                        emailtextBox.Focus();
                        contacttextBox.Focus();
                    }
                    else
                    {
                        string address = txtorderaddsress.Text;
                        mailinglabel.Text = $"Mailing address: {address}";
                        string email = emailtextBox.Text;
                        emaillabel.Text = $"Email address: {email}";
                        string contact = contacttextBox.Text;
                        contactlabel.Text = $"Contact Info: {contact}";

                    }
                    break;


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aftercheckout acc = new aftercheckout(mainWelcomeForm);
            acc.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
