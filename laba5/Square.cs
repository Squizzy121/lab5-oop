using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab5
{
    class Square:Figure
    {
        private int sideLength { get; set; }
        public Square(int x, int y, int side) :base(x,y)
        {
            this.sideLength = side;          
        }
        public override void DrawBlack(PictureBox pbox)
        {
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawRectangle(Pens.Black, x, y, sideLength, sideLength);
            }
        }
        public override void HideDrawingBackGround(PictureBox pbox)
        {
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawRectangle(Pens.White, x, y, sideLength, sideLength);
            }
        }
    }
}
