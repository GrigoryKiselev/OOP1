using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace OOP1
{
    public partial class Form1 : Form
    {
        List<Shape> shapeList = new List<Shape>();

        

        Shape shapeCurr;
        Color currColor = Color.Red;
        int currPenWidth;
        
        Line line1;
        Line line2;
        List<Line> lineList = new List<Line>();
        List<Rect> rectList = new List<Rect>();

        public PictureBox GetPictureBox()
        {
            return picture;
        }

        bool mouseDown;

        public Bitmap bmp { get; set; }
        public Graphics g { get; set; }
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
            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            line1 = new Line(100, 100, 200, 10, Color.Red, 1);
            line2 = new Line(200, 10, 300, 100, Color.Purple, 2);

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

        //private void Draw (Shape shape)
        //{
        //    foreach(float[] pointList in shapeCurr.pointList)
        //    {
        //        g.DrawLine(myPen, pointList[0], pointList[1], pointList[2], pointList[3]);
        //    }
        //}

        private void Draw(Line line)
        {
            foreach(float[] pointList in line.pointList)
            {
                g.DrawLine(myPen, pointList[0], pointList[1], pointList[2], pointList[3]);
            }
            picture.Image = bmp;
        }

        private void Draw(Rect rectangle)
        {
            foreach (float[] pointList in rectangle.pointList)
            {
                g.DrawLine(myPen, pointList[0], pointList[1], pointList[2], pointList[3]);
            }
            //Rectangle rect = new Rectangle(rectangle.x1, rectangle.y1, rectangle.width, rectangle.height);
            //if (rbEllipse.Checked)
            //{
            //    g.DrawEllipse(myPen, rect);
            //}
            //else if (rbRectangle.Checked)
            //{
            //    g.DrawRectangle(myPen, rect);
            //}
            picture.Image = bmp;
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            myPen.Color = currColor;
            myPen.Width = tbWidth.Value;
            currPenWidth = tbWidth.Value;
            

            mouseDown = true;
            x1 = e.Location.X;
            y1 = e.Location.Y;

            if (rbRectangle.Checked )
            {
                shapeCurr = new Rect(x1, y1, 0, 0, currColor, currPenWidth);
                shapeCurr.Draw(x1, y1, 0, 0, currColor, currPenWidth, this, myPen);
            }
            else if(rbTriangle.Checked)
            {
                shapeCurr = new Triangle(x1, y1, 0, 0, currColor, currPenWidth);
            }
            else if(rbRhombus.Checked)
            {
                shapeCurr = new Rhombus(x1, y1, 0, 0, currColor, currPenWidth);
            }
            else if (rbLine.Checked)
            {
                shapeCurr = new Line(x1, y1, 0, 0, currColor, currPenWidth);
            }
            else if (rbEllipse.Checked)
            {
                shapeCurr = new Ellipse(x1, y1, 0, 0, currColor, currPenWidth);
            }
            else if (rbPentagon.Checked)
            {
                shapeCurr = new Pentagon(x1, y1, 0, 0, currColor, currPenWidth);
            }
            else if (rbStar.Checked)
            {
                shapeCurr = new Star(x1, y1, 0, 0, currColor, currPenWidth);
            }
            
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                x2 = e.Location.X;
                y2 = e.Location.Y;

            //    if (rbRectangle.Checked || rbTriangle.Checked || rbRhombus.Checked || rbLine.Checked || rbEllipse.Checked || rbPentagon.Checked)
                {

                    if (x2 < x1 && y2 > y1)
                    {
                        shapeCurr.x1 = x2;
                        shapeCurr.Calculate(x2, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                    }
                    if (x2 > x1 && y2 > y1)
                    {
                        //    rectCurr.x1 = x2;
                        shapeCurr.Calculate(x1, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                    }
                    if (x2 < x1 && y2 < y1)
                    {
                        shapeCurr.x1 = x2;
                        shapeCurr.y1 = y2;
                        shapeCurr.Calculate(x2, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                    }
                    if (x2 > x1 && y2 < y1)
                    {
                        shapeCurr.y1 = y2;
                        shapeCurr.Calculate(x1, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                    }

                    shapeCurr.width = Math.Abs(x2 - x1);
                    shapeCurr.height = Math.Abs(y2 - y1);

                    //  rectCurr.Calculate(x1, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));

                    //DrawRects();
                    DrawShapes();
                    shapeCurr.Draw(x1, y1, shapeCurr.width, shapeCurr.height, currColor, currPenWidth, this, myPen);
                }
                           
            }
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;


            x2 = e.Location.X;
            y2 = e.Location.Y;


          //  if (rbRectangle.Checked || rbTriangle.Checked || rbRhombus.Checked || rbLine.Checked || rbEllipse.Checked || rbPentagon.Checked)
            {
                if(x2 < x1)
                {
                    shapeCurr.x1 = x2;
                }

                if (y2 < y1)
                {
                    shapeCurr.y1 = y2;
                }

                shapeCurr.width = Math.Abs(x2 - x1);
                shapeCurr.height = Math.Abs(y2 - y1);
                shapeCurr.color = currColor;
                shapeCurr.penWidth = currPenWidth;

                DrawShapes();
                //DrawRects();
                shapeCurr.Draw(x1, y1, shapeCurr.width, shapeCurr.height, currColor, currPenWidth, this, myPen);

             //   rectList.Add(rectCurr);

                shapeList.Add(shapeCurr);
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

        //public void DrawRects()
        //{
        //    g.Clear(Color.White);
        //    foreach(Rect rect in rectList)
        //    {
        //        rect.Draw(x1, y1, 0, 0, this, myPen);
        //    }
        //}

        public void DrawShapes()
        {
            g.Clear(Color.White);
            foreach (Shape shape in shapeList)
            {
                myPen.Color = shape.color;
                myPen.Width = shape.penWidth;
                shape.Draw(x1, y1, shape.width, shape.height, shape.color, shape.penWidth, this, myPen);
            }
            myPen.Width = currPenWidth;
            myPen.Color = currColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shapeList.RemoveAt(shapeList.Count - 1);
            DrawShapes();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        //public List<Shape> ReadAndDeserialize(string path)
        //{
        //    var serializer = new XmlSerializer(typeof(List<Shape>));
        //    using (var reader = new StreamReader(path))
        //    {
        //        return (List<Shape>)serializer.Deserialize(reader);
        //    }
        //}

        //public void SerializeAndSave(string path, List<Shape> data)
        //{
        //    var serializer = new XmlSerializer(typeof(List<Shape>));
        //    using (var writer = new StreamWriter(path))
        //    {
        //        serializer.Serialize(writer, data);
        //    }
        //}
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                currColor = MyDialog.Color;
        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {

        }
    }
}
