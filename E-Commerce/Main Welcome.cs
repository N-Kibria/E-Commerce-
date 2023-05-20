using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_Commerce
{
    public partial class Main_Welcome : Form
    {
        private string user_name;
        public Main_Welcome(string username)
        {
            InitializeComponent();
            this.user_name = username;
        }
        public Main_Welcome() { }

        private void button1_Click(object sender, EventArgs e)
        {
            profile p1 = new profile(this, user_name);
            p1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Add p1 = new Add();
            p1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            review p1 = new review(this);
            p1.Show();
            this.Hide();
        }


        private void Main_Welcome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 w1 =new Form1();
            w1.Show();
            this.Hide();
        }
    }
}
