using System;
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
    public partial class Form2 : Form
    {
        private ImageList imgs = new ImageList();

        public Form2()
        {
            InitializeComponent();
        }
        private Dictionary<int, decimal> shoePrices = new Dictionary<int, decimal>
{
    { 0, 1500m },
    { 1, 1700.99m },
    { 2, 2000m },
      { 3, 1499m },
    { 4, 1999m },
    { 5, 2000m },
     { 6, 1500m },
    { 7, 1800.99m },
    { 8, 2000m },
      { 9, 1499m },
    
    // Add more key-value pairs as needed
};


        private void listViewfile_MouseClick(object sender, MouseEventArgs e)
            {
                // Get the index of the selected item
                int selectedIndex = listViewfile.SelectedIndices[0];

                // Get the file name and price of the selected shoe
                string fileName = Path.GetFileNameWithoutExtension(listViewfile.Items[selectedIndex].Text);
                decimal price = shoePrices[selectedIndex];

                // Display the name and price of the selected shoe
                MessageBox.Show(fileName + " - Price: Tk" + price);
            }


        

        private void listViewfile_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listViewfile.View = View.Details;
            listViewfile.Columns.Add("Shoes", 100);
            listViewfile.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            // Initialize and assign ImageList control to ListView
            imgs.ImageSize = new Size(250,250);
            listViewfile.SmallImageList = imgs;

            // Populate ListView and ImageList
            populate();
        }
        private void populate()
        {
            string[] paths = Directory.GetFiles(@"C:\Users\User\Desktop\projectt\shoes");
            try
            {
                int index = 0;
                foreach (string path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                    string fileName = Path.GetFileNameWithoutExtension(path);
                    listViewfile.Items.Add(new ListViewItem(fileName, index));
                    index++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void listViewfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add qwe = new Add();
            qwe.Show();
            this.Hide();
        }
    }
}
