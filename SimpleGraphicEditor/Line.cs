using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class Line : Shape
    {
        public Point EndPoint { get; private set; }
        public Line(Point startPoint, Point endPoint) : base(startPoint, "Line") { EndPoint = endPoint; }
        public override void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color.Blue), StartPoint, EndPoint);
            
        }
    }
}
