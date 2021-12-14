using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += LoadEvent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}