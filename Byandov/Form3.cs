using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Byandov
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Dead = new Form4();
            Dead.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 drawing = new Form5();
            drawing.Show();
            Hide();
        }
    }
}
