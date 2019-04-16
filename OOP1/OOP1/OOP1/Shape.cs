using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Shape
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public List<int[]> pointList= new List<int[]>();

        public Shape(int x1, int y1, int width, int height)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;
        }
    }
}
