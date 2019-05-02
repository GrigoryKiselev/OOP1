﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP1
{
    [Serializable]
    public class Rhombus : Shape, ISelectable, IEditable
    {
        public Rhombus(int x1, int y1, int width, int height, int color, int penWidth)
        {
            X1 = x1;
            Y1 = y1;
            Width = width;
            Height = height;
            Color = color;
            PenWidth = penWidth;
            Calculate(X1, Y1, Width, Height);
        }

        public Rhombus() { }

        public override void Calculate(int x1, int y1, int width, int height)
        {
            pointList.Clear();
            pointList.Add(new float[4] { x1 + (width / 2), y1         , x1 + width, y1 + (height/2) });
            pointList.Add(new float[4] { x1 + width, y1 + (height / 2), x1 + (width / 2), y1 + height });
            pointList.Add(new float[4] { x1 + (width / 2), y1 + height, x1, y1 + (height/2) });
            pointList.Add(new float[4] { x1, y1 + (height / 2), x1 + (width / 2), y1 });
        }

        public override void Draw(Form_Kiselev_Paint form, Pen pen)
        {
            foreach (float[] pointL in pointList)
            {
                form.g.DrawLine(pen, pointL[0], pointL[1], pointL[2], pointL[3]);
            }
            form.GetPictureBox().Image = form.bmp;
        }

        public override Shape FactoryMethod(int x1, int y1, int width, int height, int color, int penWidth)
        {
            return new Rhombus(x1, y1, width, height, color, penWidth);
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
    }
}
