using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab5
{
    class Circle:Figure
    {
        double radius { get; set; }
        public Circle(int x, int y, double radius) :base(x,y)
        {
            this.radius = radius;         
        }
        public override void DrawBlack(PictureBox pbox)
        {
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawEllipse(Pens.Black, x, y, (int)radius, (int)radius);
            }
        }
        public override void HideDrawingBackGround(PictureBox pbox)
        {
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawEllipse(Pens.White, x, y, (int)radius, (int)radius);
            }
        }
    }
}
