using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotsGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            SlotMachine.Roll(pictureBox1,pictureBox2,pictureBox3);
            //pictureBox1.Image = new Bitmap(Image.FromFile(@"..\..\banana.png"), pictureBox1.Size);
        }
    }
}
