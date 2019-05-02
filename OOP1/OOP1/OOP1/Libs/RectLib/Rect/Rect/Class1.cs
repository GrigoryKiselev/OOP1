﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


    [Serializable]
    public class Rect : Shape, IEditable, ISelectable
    {
        public Rect(int x1, int y1, int width, int height, int color, int penWidth)
        {
            X1 = x1;
            Y1 = y1;
            Width = width;
            Height = height;
            Color = color;
            PenWidth = penWidth;
            Calculate(X1, Y1, Width, Height);
        }

        public Rect() { }

        public override void Calculate(int x1, int y1, int width, int height)
        {
            pointList.Clear();
            pointList.Add(new float[4] { x1, y1, x1, y1 + height });
            pointList.Add(new float[4] { x1, y1, x1 + width, y1 });
            pointList.Add(new float[4] { x1 + width, y1, x1 + width, y1 + height });
            pointList.Add(new float[4] { x1, y1 + height, x1 + width, y1 + height });
        }

        public override void Draw(Form form, Pen pen, Graphics g)
        {
            foreach (float[] pointL in pointList)
            {
                g.DrawLine(pen, pointL[0], pointL[1], pointL[2], pointL[3]);
            }
        }

        public override Shape FactoryMethod(int x1, int y1, int width, int height, int color, int penWidth)
        {
            return new Rect(x1, y1, width, height, color, penWidth);
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

