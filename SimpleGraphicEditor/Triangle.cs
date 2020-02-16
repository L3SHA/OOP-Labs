using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Point SecondPoint { get; private set; }
        public Point ThirdPoint { get; private set; }
        public Triangle(Point startPoint, Point secondPoint, Point thirdPoint) : base(startPoint, "Triangle") { SecondPoint = secondPoint; ThirdPoint = thirdPoint; }
        public override void Draw(Graphics g)
        {
            Point[] triangle = new Point[3];
            triangle[0] = StartPoint;
            triangle[1] = SecondPoint;
            triangle[2] = ThirdPoint;
            g.FillPolygon(Brushes.Gray, triangle);
        }
    }
}
