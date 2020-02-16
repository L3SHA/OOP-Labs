using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class MainWindow : Form
    {
        List<Shape> shapesList = new List<Shape>();
        public MainWindow()
        {
            InitializeComponent();
            shapesList.Add(new Circle(new Point(100, 100), 80));
            shapesList.Add(new Ellipse(new Point(200, 100), 40, 30));
            shapesList.Add(new Rectangle(new Point(300, 100), 70, 50));
            shapesList.Add(new Square(new Point(400, 100), 50));
            shapesList.Add(new Line(new Point(600, 125), new Point(650, 125)));
            shapesList.Add(new Triangle(new Point(550, 150), new Point(500, 150), new Point(550, 100)));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            PointF point = new PointF(100, 50);
            foreach (Shape shape in shapesList)
            {
                shape.Draw(g);
                g.DrawString(shape.ShapeName, new Font(SystemFonts.DefaultFont, FontStyle.Regular), Brushes.Black, point);
                point.X += 100;
            }
        }
    }
}
