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
        List<Shape> shapeListBuf = new List<Shape>();
        
        Shape shapeCurr;
        Color currColor = Color.Red;
        int currPenWidth = 1;

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
            myPen = new Pen(Color.Red);
            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            shapeList.Add(new Rect(250, 250, 100, 150, Color.Brown, 7));
            shapeList.Add(new Rect(200, 200, 350, 200, Color.Orange, 7));
            shapeList.Add(new Triangle(200, 50, 350, 150, Color.Red, 7));
        }

        private void Form1_Paint()
        {
            DrawShapes();
            picture.Image = bmp;
        }

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
            else if(rbPencil.Checked)
            {
                shapeCurr = new Pencil(x1, y1, 0, 0, currColor, currPenWidth);
            }
            
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                x2 = e.Location.X;
                y2 = e.Location.Y;

          
                {
                    shapeCurr.width = Math.Abs(x2 - x1);
                    shapeCurr.height = Math.Abs(y2 - y1);
                    shapeCurr.Calculate(new Point(x1, y1), e.Location);

                    if (cbShift.Checked)
                    {
                        if (shapeCurr.width > shapeCurr.height)
                        {
                            shapeCurr.width = shapeCurr.height;
                        }
                        else
                        {
                            shapeCurr.height = shapeCurr.width;
                        }
                    }

                    if (x2 < x1 && y2 > y1)
                    {
                        shapeCurr.x1 = x2;
                        shapeCurr.Calculate(x2, y1, shapeCurr.width, shapeCurr.height);
                    }
                    if (x2 > x1 && y2 > y1)
                    {
                        shapeCurr.Calculate(x1, y1, shapeCurr.width, shapeCurr.height);
                    }
                    if (x2 < x1 && y2 < y1)
                    {
                        shapeCurr.x1 = x2;
                        shapeCurr.y1 = y2;
                        shapeCurr.Calculate(x2, y2, shapeCurr.width, shapeCurr.height);
                    }
                    if (x2 > x1 && y2 < y1)
                    {
                        shapeCurr.y1 = y2;
                        shapeCurr.Calculate(x1, y2, shapeCurr.width,shapeCurr.height);
                    }

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
                shapeCurr.Draw(x1, y1, shapeCurr.width, shapeCurr.height, currColor, currPenWidth, this, myPen);

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
            GetPictureBox().Image = bmp;
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            try
            {
                shapeListBuf.Add(shapeList[shapeList.Count - 1]);
                shapeList.RemoveAt(shapeList.Count - 1);
                DrawShapes();
            }
            catch { MessageBox.Show("Отмена невозможна"); }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            try
            {
                shapeList.Add(shapeListBuf[shapeListBuf.Count - 1]);
                shapeListBuf.RemoveAt(shapeListBuf.Count - 1);
                DrawShapes();
            }
            catch { MessageBox.Show("Восстановление невозможно"); }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            shapeList.Clear();
            DrawShapes();
        }

        private void tbWidth_Scroll(object sender, EventArgs e)
        {
            lblWidth.Text = String.Format("Pen width : {0}", tbWidth.Value);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                currColor = MyDialog.Color;
                btnColor.BackColor = currColor;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
