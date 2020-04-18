using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class Square : Shape
    {
        public int Side { get; private set; }
        public Square(Point startPoint, int side) : base(startPoint, "Square") { Side = side; }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Red, new System.Drawing.Rectangle(StartPoint, new Size(Side, Side)));
        }
    }
}
