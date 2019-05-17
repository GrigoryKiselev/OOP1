using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



[Serializable]
public class Star : Shape, ISelectable, IEditable, IPlugin
{
    public List<Point> points = new List<Point>();

    public Star(int x1, int y1, int width, int height, int color, int penWidth)
    {
        X1 = x1;
        Y1 = y1;
        Width = width;
        Height = height;
        Color = color;
        PenWidth = penWidth;
        Calculate(X1, Y1, Width, Height);
    }

    public Star() { }

    public override void Calculate(int x1, int y1, int width, int height)
    {
        points.Clear();

        Point center = new Point(x1 + width / 2, y1 + height / 2);
        const int angleCount = 5;
        const int angle = 360 / angleCount;

        for (int i = 0; i <= 360; i += angle)
        {
            double psi = (((i - 90) % 360) * 3.14159f / 180.0f);
            double fi = Math.Atan2(width * Math.Sin(psi), height * Math.Cos(psi));
            float x = (float)((width / 2 * Math.Cos(fi)) + center.X);
            float y = (float)(height / 2 * Math.Sin(fi) + center.Y);
            points.Add(new Point(Convert.ToInt32(x), Convert.ToInt32(y)));

            psi = ((((i - 90) + angle / 2) % 360) * 3.14159f / 180.0f);
            fi = Math.Atan2(width * Math.Sin(psi), height * Math.Cos(psi));
            x = (float)((width / 4 * Math.Cos(fi)) + center.X);
            y = (float)(height / 4 * Math.Sin(fi) + center.Y);
            points.Add(new Point(Convert.ToInt32(x), Convert.ToInt32(y)));
        }
    }

    public override void Draw(Form form, Pen pen, Graphics g)
    {
        Graphics canvas = g;
        for (int i = 0; i < points.Count; i++)
        {
            canvas.DrawLine(pen, points[i], points[((i + 1) % points.Count)]);
        }
    }

    public override Shape FactoryMethod()
    {
        return new Star();
    }

    public int GetX1() { return X1; }
    public int GetY1() { return Y1; }
    public int GetWidth() { return Width; }
    public int GetHeight() { return Height; }
    public int GetColor() { return Color; }
    public int GetPenWidth() { return PenWidth; }

    public bool isEditable()
    {
        return true;
    }

    public Shape Load(Form form)
    {
        return FactoryMethod();
    }
}


