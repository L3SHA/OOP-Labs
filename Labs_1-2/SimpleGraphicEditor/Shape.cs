using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public abstract class Shape : IDrawble
    {   
        public string ShapeName { get; set; }
        public Point StartPoint { get; set; }
        public Shape(Point startPoint, string shapeName) { StartPoint = startPoint; ShapeName = shapeName; }
        public abstract void Draw(Graphics g);
    }
}
