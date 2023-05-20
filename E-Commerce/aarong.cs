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
    public partial class aarong : Form
    {
        private ImageList arr = new ImageList();
        public aarong()
        {
            InitializeComponent();
        }
        private Dictionary<int, decimal> AarongPrices = new Dictionary<int, decimal>
{
    { 0, 1584m },
    { 1, 2560m },
    { 2, 2500m },
    { 3,  2300m },
    { 4, 2199m },
   
    
    // Add more key-value pairs as needed
};

        private void button1_Click(object sender, EventArgs e)
        {
            Add qaw = new Add();
            qaw.Show();
            this.Hide();
        }

        private void listViewfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewfile_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the index of the selected item
            int selectedIndex = listViewfile.SelectedIndices[0];

            // Get the file name and price of the selected shoe
            string fileName = Path.GetFileNameWithoutExtension(listViewfile.Items[selectedIndex].Text);
            decimal price = AarongPrices[selectedIndex];

            // Display the name and price of the selected shoe
            MessageBox.Show(fileName + " - Price: Tk" + price);
        }

        private void listViewfile_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void aarong_Load(object sender, EventArgs e)
        {
            listViewfile.View = View.Details;
            listViewfile.Columns.Add("Aarong", 100);
            listViewfile.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            // Initialize and assign ImageList control to ListView
            arr.ImageSize = new Size(250, 250);
            listViewfile.SmallImageList = arr;

            // Populate ListView and ImageList
            populate();
        }
        private void populate()
        {
            string[] paths = Directory.GetFiles(@"C:\Users\User\Desktop\projecttt\Aarong");
            try
            {
                int index = 0;
                foreach (string path in paths)
                {
                    arr.Images.Add(Image.FromFile(path));
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
    }
}
