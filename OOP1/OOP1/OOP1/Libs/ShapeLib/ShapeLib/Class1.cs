﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Drawing;

namespace Class1
{
    public abstract class Shape
    {

        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int PenWidth { get; set; }
        public int Color { get; set; }
        public List<float[]> pointList = new List<float[]>();
        
        public virtual void Calculate(int x1, int y1, int width, int height) { }
        public virtual void Calculate(Point from, Point to) { }

        public virtual void Draw(Form_Kiselev_Paint form, Pen pen) { }
        public abstract Shape FactoryMethod(int x1, int y1, int width, int height, int color, int penWidth);

        public void SelectFigure() { }
    }
}

