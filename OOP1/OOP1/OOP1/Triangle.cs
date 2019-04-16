﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP1
{
    class Triangle : Shape
    {
        public new int x1;// { get { return x1; } set { Calculate(x1, y1, width, height); } }
        public new int y1;// { get { return y1; } set { Calculate(x1, y1, width, height); } }
        public new int width;// { get { return width; } set { Calculate(x1, y1, width, height); } }
        public new int height;// { get { return height; } set { Calculate(x1, y1, width, height); } }

        public Triangle(int x1, int y1, int width, int height) : base(x1, y1, width, height)
        {

            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;

            Calculate(this.x1, this.y1, this.width, this.height);
        }

        public override void Calculate(int x1, int y1, int width, int height)
        {
            pointList.Clear();
            pointList.Add(new float[4] { x1 + (width / 2), y1, x1, y1 + height });
            pointList.Add(new float[4] { x1, y1 + height, x1 + width, y1 + height });
            pointList.Add(new float[4] { x1 + (width / 2), y1, x1 + width, y1 + height });
        }

        public override void Draw(int x1, int y1, int width, int height, Form1 form, Pen pen)
        {
            foreach (float[] pointL in pointList)
            {
                form.g.DrawLine(pen, pointL[0], pointL[1], pointL[2], pointL[3]);
            }
            form.GetPictureBox().Image = form.bmp;
        }
    }
}
