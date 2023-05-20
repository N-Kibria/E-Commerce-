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
    public partial class aftercheckout : Form
    {
        public string delivery ="";
        public string payment ="";
        public Main_Welcome mainWelcomeForm; // Declare a variable to hold the instance of Main_Welcome form

        public aftercheckout()
        {

        }
        public aftercheckout(Main_Welcome mainWelcomeForm)
        {
            InitializeComponent();
            this.mainWelcomeForm = mainWelcomeForm;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delivery = comboBox1.SelectedItem.ToString();
            payment = comboBox2.SelectedItem.ToString();
            MessageBox.Show($"You have selected {delivery} and {payment} for your order.");
            MessageBox.Show("Your order has been successfully placed. Thank you.");

     
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aftercheckout_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add c1 = new Add();
            c1.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
