using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_Commerce
{
    public partial class shoplist : Form
    {
        
        public shoplist()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void batapoints_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shoplist_Load(object sender, EventArgs e)
        {

            listBox1.Items.Add("Shop ID: 01");
            listBox1.Items.Add($"Points earned: {utility.sum1.ToString()}");
            listBox1.Items.Add($"Warnings till now: {utility.sum6.ToString()}");
            listBox1.Items.Add("Number of products: 10");
            listBox1.Items.Add("Measurements available:");
            listBox1.Items.Add("36,38,40,42");

            listBox2.Items.Add("Shop ID: 02");
            listBox2.Items.Add($"Points earned: {utility.sum2.ToString()}");
            listBox2.Items.Add($"Warnings till now:{utility.sum5.ToString()}");
            listBox2.Items.Add("Number of products: 5");
            listBox2.Items.Add("Measurements available:");
            listBox2.Items.Add("36,38,40,42");

            listBox3.Items.Add("Shop ID: 03");
            listBox3.Items.Add($"Points earned: {utility.sum3.ToString()}");
            listBox3.Items.Add($"Warnings till now: {utility.sum4.ToString()}");
            listBox3.Items.Add("Number of products: 5");
            listBox3.Items.Add("Measurements available:");
            listBox3.Items.Add("36,38,40,42");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            login q1 = new login();
            q1.Show();
            this.Hide();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
