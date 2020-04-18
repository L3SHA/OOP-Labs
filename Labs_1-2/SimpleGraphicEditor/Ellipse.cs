using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Ellipse : Shape
    {
        public int XAxis { get; private set; }
        public int YAxis { get; private set; }
        public Ellipse(Point startPoint, int xAxis, int yAxis) : base(startPoint, "Ellipse")  { StartPoint = startPoint; XAxis = xAxis; YAxis = yAxis; }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, new System.Drawing.Rectangle(StartPoint, new Size(XAxis, YAxis)));
        }
    }
}
