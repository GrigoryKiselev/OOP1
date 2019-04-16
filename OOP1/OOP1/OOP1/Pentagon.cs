using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP1
{
    [Serializable]
    class Pentagon : Shape
    {
        public new int x1;// { get { return x1; } set { Calculate(x1, y1, width, height); } }
        public new int y1;// { get { return y1; } set { Calculate(x1, y1, width, height); } }
        public new int width;// { get { return width; } set { Calculate(x1, y1, width, height); } }
        public new int height;// { get { return height; } set { Calculate(x1, y1, width, height); } }
        public new Color color;
        public new int penWidth;
        public List<Point> points = new List<Point>();

        public Pentagon(int x1, int y1, int width, int height, Color color, int penWidth) : base(x1, y1, width, height, color, penWidth)
        {

            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;
            this.color = color;
            this.penWidth = penWidth;

            Calculate(this.x1, this.y1, this.width, this.height);
        }

        public override void Calculate(int x1, int y1, int width, int height)
        {
            pointList.Clear();

            points.Clear();
            for (int i = 0; i <= 360; i += 360 / 5)
            {
                double psi = (((i - 90) % 360) * 3.14159f / 180.0f);
                double fi = Math.Atan2(width * Math.Sin(psi), height * Math.Cos(psi));
                float x = (float)((width * Math.Cos(fi)) + x1);
                float y = (float)(height * Math.Sin(fi) + y1);
                points.Add(new Point(Convert.ToInt32(x), Convert.ToInt32(y)));
            }

            //pointList.Add(new float[4] { x1 + (width / 2), y1, x1 + width, y1 + (height / 2) });
            //pointList.Add(new float[4] { x1 + width, y1 + (height / 2), x1 + (width / 2), y1 + height });
            //pointList.Add(new float[4] { x1 + (width / 2), y1 + height, x1, y1 + (height / 2) });
            //pointList.Add(new float[4] { x1, y1 + (height / 2), x1 + (width / 2), y1 });
        }

        public override void Draw(int x1, int y1, int width, int height, Color color, int penWidth, Form1 form, Pen pen)
        {
            Graphics canvas = form.g;
            for (int i = 0; i < points.Count; i++)
            {
                canvas.DrawLine(pen, points[i], points[((i + 1) % points.Count)]);
            }
            form.GetPictureBox().Image = form.bmp;
        }
    }
}
