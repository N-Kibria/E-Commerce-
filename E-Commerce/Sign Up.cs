﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login f1 = new login();
            f1.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            string user_name = textBox3.Text;
            string password = textBox2.Text;
            int count = password.Length;
            string retype_pass = textBox1.Text;
            bool usernameExists = false;

            // Load the list of users from the text file
            utility.load_users();

            // Check if the username already exists in the list of users
            foreach (user u in utility.users)
            {
                if (u.username.Equals(user_name))
                {
                    MessageBox.Show("Username already exists. Try another");
                    usernameExists = true;
                    break;
                }
            }

            // If the username doesn't already exist, create a new user
            if (!usernameExists)
            {
                if (count >= 6)
                {
                    if (password == retype_pass)
                    {
                        string path = @"C:\Users\user\Desktop\Ecom-level@3\Information.txt";
                        StreamWriter sw = File.AppendText(path);
                        user uu = new user(user_name, password,name);
                        utility.users.Add(uu);
                        string ss = $"{user_name},{password},{name}";
                        sw.WriteLine(ss);
                        sw.Close();

                        MessageBox.Show("User created successfully");

                        // Show the login form
                        login lf = new login();
                        lf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match");
                    }

                }
                else
                {
                    MessageBox.Show("Password must be 6 or more characters");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

