using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapes_P5
{
    internal class Square : Quadrilateral
    {
        public double Width { get; set; }

        public Square(double width)
        {
            Name = "Square";
            Width = width;
        }

        public override int Area()
        {
            return Convert.ToInt32(Math.Pow(Width, 2));
        }

        public override int Perimeter()
        {
            throw new NotImplementedException();
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has an area of {Width}");
        }
    }
}
