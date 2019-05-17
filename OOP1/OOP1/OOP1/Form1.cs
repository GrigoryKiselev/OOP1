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
using System.Reflection;

namespace OOP1
{
    public partial class Form_Kiselev_Paint : Form
    {
        List<Shape> Factory = new List<Shape>();
        private List<IPlugin> plugins = new List<IPlugin>();

        List<Shape> shapeList = new List<Shape>();
        List<Shape> shapeListBuf = new List<Shape>();
        List<Type> typeList = new List<Type>();
        Type[] arrList;

        Shape shapeCurr;
        SelectedShape checkedShape = new SelectedShape();
        int currColor = Color.Black.ToArgb();
        int currPenWidth = 1;

        public static Rectangle checkedRectangle = new Rectangle();

        ISelectable iSelectedShape;
        IEditable iEditableShape;

        public PictureBox GetPictureBox()
        {
            return picture;
        }

        bool isMouseDown;
        bool isPluginsNull;

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
            //обновляем список плагинов
            RefreshPlugins();
            Init();
            Form1_Paint();            
        }

        //путь к папке с плагинами
        private readonly string pluginPath = System.IO.Path.Combine(
                                                        Directory.GetCurrentDirectory(),
                                                        "Plugins");
        
        private void RefreshPlugins()
        {
            isPluginsNull = true;
            arrList = null;
            typeList.Clear();
            plugins.Clear();
            cmbbShapes.Items.Clear();

            DirectoryInfo pluginDirectory = new DirectoryInfo(pluginPath);
            if (!pluginDirectory.Exists)
                pluginDirectory.Create();

            //берем из директории все файлы с расширением .dll      
            var pluginFiles = Directory.GetFiles(pluginPath, "*.dll");
            foreach (var file in pluginFiles)
            {
                //загружаем сборку
                Assembly asm = Assembly.Load(File.ReadAllBytes(file));
                //ищем типы, имплементирующие наш интерфейс IPlugin,
                //чтобы не захватить лишнего
                var types = asm.GetTypes().
                                Where(t => t.GetInterfaces().
                                Where(i => i.FullName == typeof(IPlugin).FullName).Any());

                //заполняем экземплярами полученных типов коллекцию плагинов
                foreach (var type in types)
                {
                    var plugin = asm.CreateInstance(type.FullName) as IPlugin;
                    plugins.Add(plugin);
                }                
            }

            foreach (var plugin in plugins)
            {
                cmbbShapes.Items.Add(plugin.Load(this).GetType());
                typeList.Add(plugin.Load(this).GetType());
            }
            arrList = typeList.ToArray<Type>();

            if (plugins.Count > 0)
            {
                isPluginsNull = false;
                cmbbShapes.SelectedItem = cmbbShapes.Items[0];
            }
        }

        private void Init()
        {
            List<Type> types = new List<Type>();
            foreach (Type t in typeof(Shape).Assembly.GetExportedTypes())
            {
                types.Add(t);
            }
            
            bmp = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(bmp);
            myBrush = new SolidBrush(Color.Red);
            myPen = new Pen(Color.Black);
            checkedPen = new Pen(Color.Red, 3); 
            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            arrList = typeList.ToArray<Type>();

            RefreshFigureList();
        }

        private void Form1_Paint()
        {
            DrawShapes();
            picture.Image = bmp;
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isPluginsNull)
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
            if (!isPluginsNull)
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
        }

        private void Figure_MouseDown(object sender, MouseEventArgs e)
        {
            shapeListBuf.Clear();
            myPen.Color = Color.FromArgb(currColor);
            myPen.Width = tbWidth.Value;
            currPenWidth = tbWidth.Value;
            
            x1 = e.Location.X;
            y1 = e.Location.Y;
                        
            shapeCurr = plugins[cmbbShapes.SelectedIndex].Load(this);
            
            shapeCurr.X1 = x1;
            shapeCurr.Y1 = y1;
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
                    shapeCurr.Draw(this, myPen, g);
                    GetPictureBox().Image = bmp;

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
                shapeCurr.Draw(this, myPen, g);
                GetPictureBox().Image = bmp;

                shapeList.Add(shapeCurr);
                RefreshFigureList();
                shapeListBuf.Clear();
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
                shape.Draw(this, myPen, g);
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
                                    
            try
            {
                iSelectedShape = (ISelectable)lbFigures.SelectedItem;
                checkedRectangle.X = iSelectedShape.GetX1();
                checkedRectangle.Y = iSelectedShape.GetY1();
                checkedRectangle.Width = iSelectedShape.GetWidth();
                checkedRectangle.Height = iSelectedShape.GetHeight();
                DrawShapes();
                g.DrawRectangle(checkedPen, checkedRectangle);
                GetPictureBox().Image = bmp;

                tbX.Clear();
                tbY.Clear();
                tbH.Clear();
                tbW.Clear();
                tbPenWidth.Clear();

                tbX.AppendText(iSelectedShape.GetX1().ToString());
                tbY.AppendText(iSelectedShape.GetY1().ToString());
                tbW.AppendText(iSelectedShape.GetWidth().ToString());
                tbH.AppendText(iSelectedShape.GetHeight().ToString());
                tbColor.BackColor = Color.FromArgb(iSelectedShape.GetColor());
                tbPenWidth.AppendText(iSelectedShape.GetPenWidth().ToString());
            }
            catch
            {
                MessageBox.Show("Figure doesn't support selectable interface");
                tbX.Clear();
                tbY.Clear();
                tbH.Clear();
                tbW.Clear();
                tbPenWidth.Clear();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            { 
                iEditableShape = (IEditable)lbFigures.SelectedItem;            
                try
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
                catch { MessageBox.Show("Проверьте введенные данные"); }
            }
            catch
            {
                MessageBox.Show("Figure doesn't support editable interface");
            }
        }

        private void tbColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                tbColor.BackColor = MyDialog.Color;
        }      

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            shapeList.Clear();

            string textFromFile;
            XmlSerializer formatter = new XmlSerializer(typeof(Shape), arrList);

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fs.Length];
                // считываем данные
                fs.Read(array, 0, array.Length);
                // декодируем байты в строку
                textFromFile = Encoding.Default.GetString(array);
            }

            while (textFromFile != "")
            {
                
                int startIndex = textFromFile.IndexOf("<?xml");
                textFromFile = textFromFile.Remove(0, 5+startIndex);
                int endIndex = textFromFile.IndexOf("/Shape");
                endIndex += 7;
                string newstr = "<?xml" + textFromFile.Substring(startIndex, endIndex);
                textFromFile = textFromFile.Remove(0, endIndex);

                string bufFile = @"D:\4курс\ООП\Lab1\OOP1\OOP1\OOP1\bin\Debug\bufFile.xml";
                File.WriteAllText(bufFile, newstr);


                using (FileStream fs1 = new FileStream(bufFile, FileMode.OpenOrCreate))
                {
                    try
                    {
                        Shape shape;
                        shape = (Shape)formatter.Deserialize(fs1);
                        shapeList.Add(shape);
                    }
                    catch (Exception dsException)
                    {
                        string exMsg;
                        exMsg = $"Исключение: {dsException.Source}";
                       // MessageBox.Show(exMsg);
                    } 
                }
            }
                    
            DrawShapes();
            RefreshFigureList();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName + ".xml";
            
            XmlSerializer formatter = new XmlSerializer(typeof(Shape), arrList);
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                foreach (var shape in shapeList)
                {
                    formatter.Serialize(fs, shape);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshPlugins();
            RefreshFigureList();
        }

        private void cmbbShapes_Click(object sender, EventArgs e)
        {
           // RefreshPlugins();
        }
    }
}
