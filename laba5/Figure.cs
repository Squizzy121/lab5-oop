using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab5
{
    public abstract class Figure
    {
        public int x { get; set; }
        public int y { get; set; }


        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void DrawBlack(PictureBox pbox);
        public abstract void HideDrawingBackGround(PictureBox pbox);
        public void MoveRight(PictureBox pbox)
        {
            DrawBlack(pbox);
            pbox.Image = pbox.Image;
            System.Threading.Thread.Sleep(100);
            HideDrawingBackGround(pbox);
            x += 10;
            
        }
    }
}
