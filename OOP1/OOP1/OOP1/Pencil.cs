using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP1
{
    class Pencil : Shape
    {
        public int counter = 0;//счетчик чтобы запоминать только каждую n-ю точку 
        public List<Point> points = new List<Point>();
        public Pencil(int x1, int y1, int width, int height, Color color, int penWidth)
        {

            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;
            this.color = color;
            this.penWidth = penWidth;

            Calculate(this.x1, this.y1, this.width, this.height);
            Calculate(new Point(this.x1, this.y1), new Point(this.x1, this.y1));
        }

        public override void Calculate(int x1, int y1, int width, int height)
        {
            pointList.Clear();
            pointList.Add(new float[4] { x1, y1, x1 + width, y1 + height });
        }
        
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

        public override void Draw(int x1, int y1, int width, int height, Color color, int penWidth, Form1 form, Pen pen)
        {

            form.g.DrawLine(pen, points[0], points[1]);
            form.GetPictureBox().Image = form.bmp;

            Graphics canvas = form.g;
            for (int i = 0; i < (points.Count - 1); i++)
            {
                canvas.DrawLine(pen, points[i], points[i + 1]);
            }
            form.GetPictureBox().Image = form.bmp;



        }
    }
}
