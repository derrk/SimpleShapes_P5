using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadLibrary
{
    public class Parallelogram : Quadrilateral, Points
    {
        public int Length { get; set; }
        public double Width { get; set; }

        public int Height { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int x4 { get; set; }
        public int y3 { get; set; }
        public int y4 { get; set; }

        public Parallelogram(int X1, int Y1, int X2, int Y2, int X3)
        {

            Length = X3 - X1;
            int b = X2 - X1;
            int a = Y2 - Y1;
            Width = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Height = a;

            // points entered by user
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
            x3 = X3;
            y3 = Y1;
            x4 = X2 + (X3 - X1);
            y4 = Y2;
        }

        public override int Area()
        {
            return Length * Height;
        }

        public override int Perimeter()
        {
            return Convert.ToInt32(2 * (Length + Width));
        }
    }
    }
