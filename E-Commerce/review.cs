using E_Commerce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class review : Form
    {
        public static string shop1 ="";
        public static string rating ="";

        public static double Bpoints = 0;
        public static double Bwarnings = 0;
        public static double Apoints = 0;
        public static double Awarnings = 0;
        public static double Tpoints = 0;
        public static double Twarnings = 0;

        public static double sum1;
        public static double sum2;
        public static double sum3;
        public static double sum4;
        public static double sum5;
        public static double sum6;



        public review()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 we = new Form1();
            we.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shop1 = comboBox1.SelectedItem.ToString();
            rating = comboBox2.SelectedItem.ToString();

        
                if (shop1 == "BATA")
                {
                    if (rating == "3 STAR" || rating == "4 STAR" || rating == "5 STAR")
                    {
                        Bpoints++;
                        sum1 = Bpoints;
                   }
                    else
                    {
                        Bwarnings++;
                        sum6 = Bwarnings;
                    }
                }
                else if (shop1 == "AARONG")
                {
                    if (rating == "3 STAR" || rating == "4 STAR" || rating == "5 STAR")
                    {
                        Apoints++;
                        sum2 = Apoints;
                    }
                    else
                    {
                        Awarnings++;
                        sum5 = Awarnings;
                    }
                }
                else if (shop1 == "TEXTMART")
                {
                    if (rating == "3 STAR" ||rating == "4 STAR" || rating == "5 STAR")
                    {
                        Tpoints++;
                        sum3 = Tpoints;
                    }
                    else
                    {
                        Twarnings++;
                        sum4 = Twarnings;
                    }
                }

    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
