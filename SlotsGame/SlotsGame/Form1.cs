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
            SlotMachine.Roll(pictureBox1,pictureBox2,pictureBox3,ResultLabel);
        }

        private void ResultText_Click(object sender, EventArgs e)
        {

        }

        private void Cash_Click(object sender, EventArgs e)
        {
        
        }

        private void EnterMoney_Click(object sender, EventArgs e)
        {
            int Money = 1000;
            Cash.Text += (int.Parse(Cash.Text) + Money).ToString();

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
         
        }
    }
}
