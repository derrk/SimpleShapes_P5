using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadLibrary
{
    internal class Parallelogram : Quadrilateral, Points
    {
        public int Length { get; set; }
        public int Width { get; set; }
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
            return Length * Width;
        }

        public override int Perimeter()
        {
            return 2 * (Length + Width);
        }
    }
    }
