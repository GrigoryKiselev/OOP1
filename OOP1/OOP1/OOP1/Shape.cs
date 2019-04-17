using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP1
{
    [Serializable]
    class Shape
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int penWidth { get; set; }
        public Color color { get; set; }
        public List<float[]> pointList= new List<float[]>();

        public virtual void Calculate(int x1, int y1, int width, int height) { }
        public virtual void Calculate(Point from, Point to) { }
        
        public virtual void Draw(int x1, int y1, int width, int height, Color color, int penWidth, Form1 form, Pen pen) { }
    }
}
