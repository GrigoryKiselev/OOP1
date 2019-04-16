using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Rect : Shape
    {
        public new int x1;// { get { return x1; } set { Calculate(x1, y1, width, height); } }
        public new int y1;// { get { return y1; } set { Calculate(x1, y1, width, height); } }
        public new int width;// { get { return width; } set { Calculate(x1, y1, width, height); } }
        public new int height;// { get { return height; } set { Calculate(x1, y1, width, height); } }

        public Rect(int x1 , int y1, int width, int height) : base(x1, y1, width, height)
        {
            
            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;

            Calculate(this.x1, this.y1, this.width, this.height);
        }

        public void Calculate(int x1, int y1, int width, int height)
        {
            pointList.Clear();
            pointList.Add(new int[4] { (x1 + width) / 2, y1, x1, y1 + height });
            pointList.Add(new int[4] { x1, y1 + height, x1 + width, y1 + height });
            pointList.Add(new int[4] { (x1 + width) / 2, y1, x1 + width, y1 + height });
            //pointList.Add(new int[4] { x1, y1, x1, y1 + height });
            //pointList.Add(new int[4] { x1, y1, x1 + width, y1 });
            //pointList.Add(new int[4] { x1 + width, y1, x1 + width, y1 + height });
            //pointList.Add(new int[4] { x1, y1 + height, x1 + width, y1 + height });
        }
        //public void Draw(Shape shape)
        //{
        //    foreach (int[] pointList in shape.pointList)
        //    {
        //        g.DrawLine(myPen, pointList[0], pointList[1], pointList[2], pointList[3]);
        //    }
        //}
    }
}
