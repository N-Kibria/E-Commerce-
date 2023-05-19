using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bata f2 = new bata();
            f2.Show();
            this.Hide();

        }

        private void Aarong_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aarong ew = new aarong(); 
            ew.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextMart r2 = new TextMart();
            r2.Show();
            this.Hide();

        }

        private void orderbutton_Click(object sender, EventArgs e)
        {
            cartorder c1 = new cartorder();
            c1.Show();
            this.Hide();
        }
    }
}
