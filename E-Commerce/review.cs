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

       

        private Main_Welcome mainWelcomeForm;
        public review(Main_Welcome mainWelcomeForm)
        {
            InitializeComponent();
            this.mainWelcomeForm = mainWelcomeForm;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
          login p1 = new login();
            p1.Show();
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
                    (utility.sum1)++;
                }
                else
                {

                    (utility.sum6)++;
                }
            }
            else if (shop1 == "AARONG")
            {
                if (rating == "3 STAR" || rating == "4 STAR" || rating == "5 STAR")
                {

                    (utility.sum2)++;
                }
                else
                {

                    (utility.sum5)++;
                }
            }
            else if (shop1 == "TEXTMART")
            {
                if (rating == "3 STAR" || rating == "4 STAR" || rating == "5 STAR")
                {

                    (utility.sum3)++;
                }
                else
                {

                    (utility.sum4)++;
                }
            }
            MessageBox.Show("The Shop Has been Rated.");

    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void review_Load(object sender, EventArgs e)
        {

        }
    }
}
