using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleShapes_P5
{
    internal class Rectangle : Quadrilateral
    {
        public int Width { get; set; }
        public int Length { get; set; }
       

        public Rectangle(int length, int width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
          
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
