using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class Rectangle : Shape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Rectangle(Point startPoint, int width, int height) : base(startPoint, "Rectangle") { Width = width; Height = height; }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Red, new System.Drawing.Rectangle(StartPoint, new Size(Width, Height)));
        }
    }
}
