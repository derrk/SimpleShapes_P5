using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapes_P5
{
    internal class Parallelogram : Quadrilateral
    {
        public int Length { get; set; }
        public int Width { get; set; }
        

        public Parallelogram(int length, int width)
        {
            
            Length = length;
            Width = width;
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
