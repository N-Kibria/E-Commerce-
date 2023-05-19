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
    public partial class TextMart : Form
    {
        private ImageList txx = new ImageList();
        public TextMart()
        {
            InitializeComponent();
        }
        private Dictionary<int, decimal> shoePrices = new Dictionary<int, decimal>
{
    { 0, 1584m },
    { 1, 1480m },
    { 2, 1560m },
    { 3, 1584m },
    { 4, 1584m },
   
    
    // Add more key-value pairs as needed
};


        private void TextMart_Load(object sender, EventArgs e)
        {
            listViewfile.View = View.Details;
            listViewfile.Columns.Add("TextMart", 100);
            listViewfile.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            // Initialize and assign ImageList control to ListView
            txx.ImageSize = new Size(250, 250);
            listViewfile.SmallImageList = txx;

            // Populate ListView and ImageList
            populate();
        }
        private void populate()
        {
            string[] paths = Directory.GetFiles(@"C:\Users\user\Desktop\ecom\TextMart");
            try
            {
                int index = 0;
                foreach (string path in paths)
                {
                    txx.Images.Add(Image.FromFile(path));
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

        private void TextMart_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listViewfile_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

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

        private void listViewfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add t1 = new Add();
            t1.Show();
            this.Hide();
        }
    }
}
