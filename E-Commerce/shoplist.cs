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
            
                listBox1.Items.Add(review.sum1.ToString());
                listBox2.Items.Add(review.sum2.ToString());
                listBox3.Items.Add(review.sum3.ToString());
                listBox4.Items.Add(review.sum4.ToString());
                listBox5.Items.Add(review.sum5.ToString());
                listBox6.Items.Add(review.sum6.ToString());




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 q1 = new Form1();
            q1.Show();
            this.Hide();

        }
    }
}
