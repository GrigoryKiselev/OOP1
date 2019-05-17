using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


[Serializable]
public class Line : Shape, IPlugin
{
    public int counter = 0;
    public List<Point> points = new List<Point>();
    public Line(int x1, int y1, int width, int height, int color, int penWidth)
    {

        X1 = x1;
        Y1 = y1;
        Width = width;
        Height = height;
        Color = color;
        PenWidth = penWidth;

        Calculate(X1, Y1, Width, Height);
        Calculate(new Point(X1, Y1), new Point(X1, Y1));
    }

    public Line() { }

    public override void Calculate(int x1, int y1, int width, int height)
    {
        pointList.Clear();
        pointList.Add(new float[4] { x1, y1, x1 + width, y1 + height });
    }

    public override void Calculate(Point from, Point to)
    {
        points.Clear();
        points.Add(from);
        points.Add(to);
    }

    public override void Draw(Form form, Pen pen, Graphics g)
    {
        g.DrawLine(pen, points[0], points[1]);
    }

    public override Shape FactoryMethod()
    {
        return new Line();
    }

    public Shape Load(Form form)
    {
        return FactoryMethod();
    }
}

