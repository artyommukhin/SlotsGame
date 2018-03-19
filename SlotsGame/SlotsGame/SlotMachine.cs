using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotsGame
{
    public static class SlotMachine
    {
        static readonly Image[] pics =
        {
            Image.FromFile(@"..\..\banana.png"),
            Image.FromFile(@"..\..\bar.png"),
            Image.FromFile(@"..\..\cherry.png"),
            Image.FromFile(@"..\..\lemon.png"),
            Image.FromFile(@"..\..\lucky7.png"),
            Image.FromFile(@"..\..\melon.png"),
            Image.FromFile(@"..\..\orange.png"),
            Image.FromFile(@"..\..\plum.png")
        };

        public static void Roll(PictureBox pb1, PictureBox pb2, PictureBox pb3, 
                                Label result, Label balance, TextBox wager, 
                                Label totalwager, Label totalearns)
        {
            //
            if (int.Parse(balance.Text)<int.Parse(wager.Text))
            {
                result.Text = "Not enough money";
                return;
            }
            totalwager.Text = (int.Parse(totalwager.Text) + int.Parse(wager.Text)).ToString();
            balance.Text = (int.Parse(balance.Text) - int.Parse(wager.Text)).ToString();
            totalearns.Text = (int.Parse(totalearns.Text) - int.Parse(wager.Text)).ToString();
            result.Text = "";

            Random r = new Random();
            int left = r.Next(8);
            int middle = r.Next(8);
            int right = r.Next(8);
            
            pb1.Image = new Bitmap(pics[left],pb1.Size);
            pb2.Image = new Bitmap(pics[middle],pb2.Size);
            pb3.Image = new Bitmap(pics[right],pb3.Size);
            
            //3 in a row check and summarizing the earnings with current balance and overall earnings counter 
            if (left == middle && middle == right) 
            {
                result.Text = "3 of a kind!\n" +
                              "5x wager!\n" +
                              "You won $" + 5 * int.Parse(wager.Text);
                balance.Text = (int.Parse(balance.Text) + 5 * int.Parse(wager.Text)).ToString();
                totalearns.Text = (int.Parse(totalearns.Text) + 5 * int.Parse(wager.Text)).ToString();
            }
            //2 in a row check and analogical summarizing
            else if (left==middle||left==right||right==middle)
            {
                result.Text = "2 of a kind!\n" +
                              "2x wager!\n" +
                              "You won $"+ 2 * int.Parse(wager.Text);
                balance.Text = (int.Parse(balance.Text) + 2 * int.Parse(wager.Text)).ToString();
                totalearns.Text = (int.Parse(totalearns.Text) + 2 * int.Parse(wager.Text)).ToString();
            }
            else 
            {
                result.Text = "You lose";
            }
        }

        public static void AddMoney(Label cash, TextBox input)
        {
            if (int.Parse(input.Text) > 0)
            {
                cash.Text = (int.Parse(cash.Text) + int.Parse(input.Text)).ToString();
            }
        }
    }
}
