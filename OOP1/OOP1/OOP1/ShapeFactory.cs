using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ShapeFactory
    {
        public static Shape GetShape(int index)
        {
            switch (index)
            {
                case 0:
                    return new Rect();
                case 1:
                    return new Pentagon();
                case 2:
                    return new Rhombus();
                case 3:
                    return new Star();
                case 4:
                    return new Ellipse();
                case 5:
                    return new Triangle();
                case 6:
                    return new Line();
                case 7:
                    return new Pencil();
                default :
                    return null;
            }     
            
        }
    }
}
