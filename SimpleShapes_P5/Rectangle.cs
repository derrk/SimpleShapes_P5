using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleShapes_P5
{
    internal class Rectangle : Quadrilateral , Points
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int x4 { get; set; }

        public Rectangle(int X1, int Y1, int X3, int Y2)
        {
            Name = "Rectangle";
            Length = X3 - X1;
            Width = Y2 - Y1;
            x1 = X1;
            y1 = Y1;
            x3 = X3;
            y2 = Y2;
          
        }

        public override int Area()
        {
            return Length * Width;
        }

        public override int Perimeter()
        {
            return 2 * (Width + Length);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a length of {Length} and a width of {Width}");
        }
    }
}
