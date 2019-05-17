using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


[Serializable]
public class Pencil : Shape, IPlugin
{
    public int counter = 0;//счетчик чтобы запоминать только каждую n-ю точку 
    public List<Point> points = new List<Point>();
    public Pencil(int x1, int y1, int width, int height, int color, int penWidth)
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

    public Pencil() { }

    public override void Calculate(Point from, Point to)
    {
        if (points.Count == 0)
        {
            points.Add(from);
            points.Add(to);
        }

        if ((++counter) % 3 == 0)
        {
            counter = 0;
            points.Add(to);
        }
    }

    public override void Draw(Form form, Pen pen, Graphics g)
    {

        g.DrawLine(pen, points[0], points[1]);

        Graphics canvas = g;
        for (int i = 0; i < (points.Count - 1); i++)
        {
            canvas.DrawLine(pen, points[i], points[i + 1]);
        }

    }

    public override Shape FactoryMethod()
    {
        return new Pencil();
    }

    public Shape Load(Form form)
    {
        return FactoryMethod();
    }
}

