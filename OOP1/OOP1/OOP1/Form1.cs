﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form1 : Form
    {
        Line line1;
        Line line2;
        Line lineCurr;
        List<Line> lineList = new List<Line>();
        List<Rect> rectList = new List<Rect>();

        Rect rectCurr;

        bool mouseDown;

        Bitmap bmp;
        Graphics g;
        SolidBrush myBrush;
        Pen myPen;

        int x1;
        int y1;
        int x2;
        int y2;
        
        public Form1()
        {
            InitializeComponent();
            Init();
            Form1_Paint();
        }

        private void Init ()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(bmp);
            myBrush = new SolidBrush(Color.Red);
            myPen = new Pen(Color.Blue);
            line1 = new Line(100, 100, 200, 10);
            line2 = new Line(200, 10, 300, 100);
        }

        private void Form1_Paint()
        {
           
            g.FillEllipse(myBrush, new Rectangle(0, 0, 200, 300));
            g.DrawRectangle(myPen, 100, 100, 200, 200);
            Draw(line1);
            Draw(line2);    
            picture.Image = bmp;
           // g.Dispose();
          //  myBrush.Dispose();
        }

        private void Draw (Line line)
        {
            g.DrawLine(myPen, line.x1, line.y1, line.x2, line.y2);
            picture.Image = bmp;
        }

        private void Draw (Rect rectangle)
        {
            Rectangle rect = new Rectangle(rectangle.x1, rectangle.y1, rectangle.width, rectangle.height);
            g.DrawRectangle(myPen, rect);
            picture.Image = bmp;
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            x1 = e.Location.X;
            y1 = e.Location.Y;

            if (rbRectangle.Checked)
            {
                rectCurr = new Rect(0, x1, y1, 0, 0);
                Draw(rectCurr);
            }
            else
            {
                lineCurr = new Line(x1, y1, x1, y1);
                Draw(lineCurr);
            }
            
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                x2 = e.Location.X;
                y2 = e.Location.Y;

                if (rbRectangle.Checked)
                {
                    rectCurr.width = x2 - x1;
                    rectCurr.height = y2 - y1;

                    DrawRects();
                    Draw(rectCurr);
                }
                else
                {
                    lineCurr.x2 = x2;
                    lineCurr.y2 = y2;


                    DrawLines();
                    Draw(lineCurr);
                }             
            }
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;


            x2 = e.Location.X;
            y2 = e.Location.Y;

            if (rbRectangle.Checked)
            {
                rectCurr.width = x2 - x1;
                rectCurr.height = y2 - y1;

                Draw(rectCurr);

                rectList.Add(rectCurr);
            }
            else
            {
                lineCurr.x2 = x2;
                lineCurr.y2 = y2;

                Draw(lineCurr);

                lineList.Add(lineCurr);
            }            
        }

        public void DrawLines()
        {
            g.Clear(Color.White);
            foreach (Line line in lineList)
            {
                Draw(line);
            }
        }

        public void DrawRects()
        {
            g.Clear(Color.White);
            foreach(Rect rect in rectList)
            {
                Draw(rect);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lineList.RemoveAt(lineList.Count - 1);
            DrawLines();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
