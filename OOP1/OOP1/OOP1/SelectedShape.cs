using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class SelectedShape
    {
        private static SelectedShape instance;
        private static bool Selected = false;

        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }


        public SelectedShape()
        {
            Selected = true;
        }

        public static void SetSel(int X1, int Y1, int X2, int Y2, Pen P)
        {
            if (instance == null)
            {
                instance = new SelectedShape();
            }
            else
            {
                instance.X = Math.Min(X1, X2);
                instance.Y = Math.Min(Y1, Y2);
                instance.H = Math.Abs(Y1 - Y2);
                instance.W = Math.Abs(X1 - X2);
            }
            Selected = true;
        }

        public static bool IsSelected()
        {
            return Selected;
        }

        public static int GetX()
        {
            return instance.X;
        }

        public static int GetY()
        {
            return instance.Y;
        }

        public static int GetW()
        {
            return instance.W;
        }

        public static int GetH()
        {
            return instance.H;
        }
    }
}