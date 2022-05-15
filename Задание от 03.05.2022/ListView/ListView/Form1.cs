using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView3.SmallImageList = imageList2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                lvi.ImageIndex = 0;
                listView3.Items.Add(lvi);
           
            }
        }
    }
}
