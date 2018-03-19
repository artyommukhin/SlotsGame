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
            SlotMachine.Roll(pictureBox1, pictureBox2, pictureBox3, ResultLabel, BalanceCount, WagerInput, TotalWageredInfo, TotalEarnsInfo);
        }

        private void AddMoneyButton_Click(object sender, EventArgs e)
        {
            SlotMachine.AddMoney(BalanceCount,MoneyInput);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            int Money = 0;
            if (Int32.Parse(BalanceCount.Text)<0)
            {
            BalanceCount.Text +=Money;
            }
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
