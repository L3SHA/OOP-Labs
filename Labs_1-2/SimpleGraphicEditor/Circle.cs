using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(Point startPoint, int radius) : base(startPoint, "Circle") { Radius = radius; }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, new System.Drawing.Rectangle(StartPoint, new Size(Radius, Radius)));
        }
    }
}
