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
        public static Image[] pics =
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

        public static void Roll(PictureBox pb1, PictureBox pb2, PictureBox pb3, Label result)
        {
            //--balance
            result.Text = "";
            Random r = new Random();

            int left = r.Next(8);
            int middle = r.Next(8);
            int right = r.Next(8);

            pb1.Image = new Bitmap(pics[left],pb1.Size);
            pb2.Image = new Bitmap(pics[middle],pb2.Size);
            pb3.Image = new Bitmap(pics[right],pb3.Size);

            if (left==middle||left==right||right==middle)
            {
                result.Text = "2 of a kind!\n" +
                              "You won $200";
                //++balance
            }
            else if (left == middle && middle == right)
            {
                result.Text = "3 of a kind!\n" +
                              "You won $500";
                //++balance
                
            }
            else
            {
                result.Text = "You lose";
            }
        }
    }
}
