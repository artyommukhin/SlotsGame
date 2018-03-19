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
        }

        private void ResultText_Click(object sender, EventArgs e)
        {

        }

        private void Cash_Click(object sender, EventArgs e)
        {
        
        }

        private void EnterMoney_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Cash2.Text)>=0)
            {
                Cash2.Text = (Int32.Parse(Cash2.Text) + Int32.Parse(EnterBalance.Text)).ToString();
            }

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            int Money = 0;
            Cash2.Text +=Money;
        }
    }
}
