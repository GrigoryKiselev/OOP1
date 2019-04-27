using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace OOP1
{
    [Serializable]
    //[XmlInclude(typeof(Rect))]
    //[XmlInclude(typeof(Triangle))]
    //[XmlInclude(typeof(Star))]
    //[XmlInclude(typeof(Ellipse))]
    //[XmlInclude(typeof(Pentagon))]
    //[XmlInclude(typeof(Rhombus))]
    //[XmlInclude(typeof(Pencil))]
    //[XmlInclude(typeof(Line))]
    public abstract class Shape
    {

        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int PenWidth { get; set; }
        public int Color { get; set; }
        public List<float[]> pointList= new List<float[]>();

        public virtual void Calculate(int x1, int y1, int width, int height) { }
        public virtual void Calculate(Point from, Point to) { }
        
        public virtual void Draw(int x1, int y1, int width, int height, Form1 form, Pen pen) { }
    }
}
