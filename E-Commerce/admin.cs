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
    public partial class admin : Form
    {
        private string CorrectPassword = "teamlevel3";
        public admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredPassword = textBox1.Text;

            if (enteredPassword == CorrectPassword)
            {
                shoplist sl = new shoplist();
                sl.Show();
                this.Hide();
            }
            else
            { 
                MessageBox.Show("Incorrect password. You cannot login as Admin.");

                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();

                textBox1.Clear();
                
            }

        }
    }
}
