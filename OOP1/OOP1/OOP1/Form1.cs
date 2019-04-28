﻿using System;
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
using System.Reflection;

namespace OOP1
{
    //
    public partial class Form_Kiselev_Paint : Form
    {
        List<Shape> shapeList = new List<Shape>();
        List<Shape> shapeListBuf = new List<Shape>();
        List<Type> typeList = new List<Type>();
        Type[] arrList;

        Shape shapeCurr;
        int currColor = Color.Red.ToArgb();
        int currPenWidth = 1;

        Rectangle checkedRectangle;
        Shape checkedShape;

        public PictureBox GetPictureBox()
        {
            return picture;
        }

        bool isMouseDown;

        public Bitmap bmp { get; set; }
        public Graphics g { get; set; }
        SolidBrush myBrush;
        Pen myPen;
        Pen checkedPen;

        int x1;
        int y1;
        int x2;
        int y2;
        
        public Form_Kiselev_Paint()
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
            checkedPen = new Pen(Color.Red, 1); 
            checkedRectangle = new Rectangle();
            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            shapeCurr = new Rect();
            typeList.Add(shapeCurr.GetType());
            shapeCurr = new Pentagon();
            typeList.Add(shapeCurr.GetType());
            shapeCurr = new Rhombus();
            typeList.Add(shapeCurr.GetType());
            shapeCurr = new Star();
            typeList.Add(shapeCurr.GetType());
            shapeCurr = new Ellipse();
            typeList.Add(shapeCurr.GetType());
            shapeCurr = new Triangle();
            typeList.Add(shapeCurr.GetType());
            shapeCurr = new Line();
            typeList.Add(shapeCurr.GetType());
            shapeCurr = new Pencil();
            typeList.Add(shapeCurr.GetType());

            arrList = typeList.ToArray<Type>();

            shapeList.Add(new Rect(250, 250, 100, 150, Color.Brown.ToArgb(), 7));
            shapeList.Add(new Rect(200, 200, 350, 200, Color.Orange.ToArgb(), 7));
            shapeList.Add(new Triangle(200, 50, 350, 150, Color.Red.ToArgb(), 7));
            RefreshFigureList();
        }

        private void Form1_Paint()
        {
            DrawShapes();
            picture.Image = bmp;
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            if (rbFigure.Checked)
            {
                Figure_MouseDown(sender, e);
            }
            else if (rbCursor.Checked)
            {
                Cursor_MouseDown(sender, e);
            }
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (rbFigure.Checked)
            {
                Figure_MouseMove(sender, e);
            }
            else if (rbCursor.Checked)
            {
                Cursor_MouseMove(sender, e);
            }
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (rbFigure.Checked)
            {
                Figure_MouseUp(sender, e);
            }
            else if (rbCursor.Checked)
            {
                Cursor_MouseUp(sender, e);
            }
        }

        private void Figure_MouseDown(object sender, MouseEventArgs e)
        {
            shapeListBuf.Clear();
            myPen.Color = Color.FromArgb(currColor);
            myPen.Width = tbWidth.Value;
            currPenWidth = tbWidth.Value;


            
            x1 = e.Location.X;
            y1 = e.Location.Y;

            if (rbRectangle.Checked)
            {
                shapeCurr = new Rect(x1, y1, 0, 0, currColor, currPenWidth);
                //shapeCurr.FactoryMethod(x1, y1, 0, 0, currColor, currPenWidth);
            }
            else if (rbTriangle.Checked)
            {
                shapeCurr = new Triangle(x1, y1, 0, 0, currColor, currPenWidth);
            }
            else if (rbRhombus.Checked)
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
            else if (rbPencil.Checked)
            {
                shapeCurr = new Pencil(x1, y1, 0, 0, currColor, currPenWidth);
            }
        }

        private void Figure_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                x2 = e.Location.X;
                y2 = e.Location.Y;


                {
                    shapeCurr.Width = Math.Abs(x2 - x1);
                    shapeCurr.Height = Math.Abs(y2 - y1);
                    shapeCurr.Calculate(new Point(x1, y1), e.Location);

                    if (cbShift.Checked)
                    {
                        if (shapeCurr.Width > shapeCurr.Height)
                        {
                            shapeCurr.Width = shapeCurr.Height;
                        }
                        else
                        {
                            shapeCurr.Height = shapeCurr.Width;
                        }
                    }

                    if (x2 < x1 && y2 > y1)
                    {
                        shapeCurr.X1 = x2;
                        shapeCurr.Calculate(x2, y1, shapeCurr.Width, shapeCurr.Height);
                    }
                    if (x2 > x1 && y2 > y1)
                    {
                        shapeCurr.Calculate(x1, y1, shapeCurr.Width, shapeCurr.Height);
                    }
                    if (x2 < x1 && y2 < y1)
                    {
                        shapeCurr.X1 = x2;
                        shapeCurr.Y1 = y2;
                        shapeCurr.Calculate(x2, y2, shapeCurr.Width, shapeCurr.Height);
                    }
                    if (x2 > x1 && y2 < y1)
                    {
                        shapeCurr.Y1 = y2;
                        shapeCurr.Calculate(x1, y2, shapeCurr.Width, shapeCurr.Height);
                    }

                    DrawShapes();
                    shapeCurr.Draw(this, myPen);
                }
            }
        }

        private void Figure_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.Location.X;
            y2 = e.Location.Y;

            {
                if (x2 < x1)
                {
                    shapeCurr.X1 = x2;
                }

                if (y2 < y1)
                {
                    shapeCurr.Y1 = y2;
                }

                shapeCurr.Width = Math.Abs(x2 - x1);
                shapeCurr.Height = Math.Abs(y2 - y1);
                shapeCurr.Color = currColor;
                shapeCurr.PenWidth = currPenWidth;

                DrawShapes();
                shapeCurr.Draw(this, myPen);

                shapeList.Add(shapeCurr);
                RefreshFigureList();
            }
        }

        private void Cursor_MouseDown(object sender, MouseEventArgs e)
        {
             Point point = new Point(e.Location.X, e.Location.Y);
             FloodFill(bmp, point, Color.White, Color.Red);
        }

        private void Cursor_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Cursor_MouseUp(object sender, MouseEventArgs e)
        {

        }

        public void DrawShapes()
        {
            g.Clear(Color.White);
            foreach (Shape shape in shapeList)
            {
                myPen.Color = Color.FromArgb(shape.Color);
                myPen.Width = shape.PenWidth;
                shape.Draw(this, myPen);
            }
            myPen.Width = currPenWidth;
            myPen.Color = Color.FromArgb(currColor);
            GetPictureBox().Image = bmp;
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            try
            {
                shapeListBuf.Add(shapeList[shapeList.Count - 1]);
                shapeList.RemoveAt(shapeList.Count - 1);
                //shapeListBuf.Clear();
                DrawShapes();
                RefreshFigureList();
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
                RefreshFigureList();
            }
            catch { MessageBox.Show("Восстановление невозможно"); }
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                currColor = MyDialog.Color.ToArgb();
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
                currColor = MyDialog.Color.ToArgb();
                btnColor.BackColor = Color.FromArgb(currColor);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName + ".xml";

            Type type = shapeList.GetType();
            XmlSerializer formatter = new XmlSerializer(typeof(List<Shape>), arrList);
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {                
                formatter.Serialize(fs, shapeList);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;

            Type type = shapeList.GetType();
            XmlSerializer formatter = new XmlSerializer(typeof(List<Shape>), arrList);
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                shapeList.Clear();
                shapeList = (List<Shape>)formatter.Deserialize(fs);
            }
            DrawShapes();
            RefreshFigureList();
        }
        

        private void rbEllipse_CheckedChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(gbFigures.TabIndex.ToString());
        }

        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Stack<Point> pixels = new Stack<Point>();
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0)//make sure we stay within bounds
                {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            picture.Refresh(); //refresh our main picture box
            return;
        }

        private void RefreshFigureList()
        {
            lbFigures.Items.Clear();
            foreach(Shape shape in shapeList)
            {
                lbFigures.Items.Add(shape);
            }
        }

        private void lbFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedShape = (Shape)lbFigures.SelectedItem;

            checkedRectangle.X = checkedShape.X1;
            checkedRectangle.Y = checkedShape.Y1;
            checkedRectangle.Width = checkedShape.Width;
            checkedRectangle.Height = checkedShape.Height;
            DrawShapes();
            g.DrawRectangle(checkedPen, checkedRectangle);
            GetPictureBox().Image = bmp;

            tbX.Clear();
            tbY.Clear();
            tbH.Clear();
            tbW.Clear();
           // tbColor.Clear();
            tbPenWidth.Clear();

            tbX.AppendText(checkedShape.X1.ToString());
            tbY.AppendText(checkedShape.Y1.ToString());
            tbW.AppendText(checkedShape.Width.ToString());
            tbH.AppendText(checkedShape.Height.ToString());
            tbColor.BackColor = Color.FromArgb(checkedShape.Color);
           // tbColor.AppendText(checkedShape.Color.ToString());
            tbPenWidth.AppendText(checkedShape.PenWidth.ToString()); 
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            checkedRectangle.X = Convert.ToInt32(tbX.Text);
            checkedRectangle.Y = Convert.ToInt32(tbY.Text);
            checkedRectangle.Width = Convert.ToInt32(tbW.Text);
            checkedRectangle.Height = Convert.ToInt32(tbH.Text);

            shapeList[lbFigures.SelectedIndex].X1 = Convert.ToInt32(tbX.Text);
            shapeList[lbFigures.SelectedIndex].Y1 = Convert.ToInt32(tbY.Text);
            shapeList[lbFigures.SelectedIndex].Width = Convert.ToInt32(tbW.Text);
            shapeList[lbFigures.SelectedIndex].Height = Convert.ToInt32(tbH.Text);
            shapeList[lbFigures.SelectedIndex].Color = tbColor.BackColor.ToArgb();
            shapeList[lbFigures.SelectedIndex].PenWidth = Convert.ToInt32(tbPenWidth.Text);
            shapeList[lbFigures.SelectedIndex].Calculate(shapeList[lbFigures.SelectedIndex].X1, shapeList[lbFigures.SelectedIndex].Y1, shapeList[lbFigures.SelectedIndex].Width, shapeList[lbFigures.SelectedIndex].Height);
            DrawShapes();
            g.DrawRectangle(checkedPen, checkedRectangle);
            GetPictureBox().Image = bmp;
        }

        private void tbColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                tbColor.BackColor = MyDialog.Color;
            checkedShape.Color = MyDialog.Color.ToArgb();
        }
    }
}
