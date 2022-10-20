using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadLibrary
{
    public class Trapezoid : Quadrilateral, Points
    {
        public int Base { get; set; }
        public int Roof { get; set; }

        public int Height { get; set; }

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
        public int x4 { get; set; }
        public int y4 { get; set; }

        public Trapezoid(int X1, int Y1, int X2, int Y2, int X3, int Y3, int X4, int Y4)
        {
            Name = "Trapezoid";
            Base = X3 - X1;
            Roof = X4 - X2;
            Height = Y2 - Y1;
            int b1 = X2 - X1;
            int b2 = X3 - X4;
            Side1 = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(b1, 2));
            Side2 = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(b2, 2));


        }

        public override int Area()
        {
            return ((Base + Roof)  / 2 ) * Height;
        }

        public override int Perimeter()
        {
            return Convert.ToInt32(Base + Roof + Side1 + Side2);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"One base is {Base} and the other is {Roof}");
        }
    }
}
