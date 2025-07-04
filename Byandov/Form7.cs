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


namespace Byandov
{
    public partial class Form7 : Form
    {
        PictureBox character;

        public Form7()
        {
            InitializeComponent();

            // Make sure the form receives key events
            this.KeyPreview = true;
            this.KeyDown += Form7_KeyDown;

            // Create the character
            character = new PictureBox
            {
                Image = Image.FromFile(@"C:\Path\To\Your\character.png"), // << Change this!
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(80, 120),
                Location = new Point(100, 100),
                BackColor = Color.Transparent // Optional: see-through background
            };

            // Add character to form
            this.Controls.Add(character);
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            int step = 10;

            if (e.KeyCode == Keys.Right)
                character.Left += step;
            else if (e.KeyCode == Keys.Left)
                character.Left -= step;
            else if (e.KeyCode == Keys.Up)
                character.Top -= step;
            else if (e.KeyCode == Keys.Down)
                character.Top += step;
        }
    }
}
