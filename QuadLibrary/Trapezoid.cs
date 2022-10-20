using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadLibrary
{// inherit base class and interface
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
        // trapezoid is its own monster,
        // it will receive all 4 points but the y values for corresponding points will be the same
        public Trapezoid(int X1, int Y1, int X2, int Y2, int X3, int Y3, int X4, int Y4)
        {
            Name = "Trapezoid";
            Base = X3 - X1;
            Roof = X4 - X2;
            Height = Y2 - Y1;
            int b1 = X2 - X1;
            int b2 = X3 - X4;
            // calculate the length of the diagonal sides
            Side1 = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(b1, 2));
            Side2 = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(b2, 2));
            // set appropriate points to what they should be, either user input or the same as 
            // and existing 
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
            x3 = X3;
            y3 = Y3;
            x4 = X4;
            y4 = y2;

        }
        // compute area and return area
        public override int Area()
        {
            return ((Base + Roof)  / 2 ) * Height;
        }
        // calculate perimeter and return it
        public override int Perimeter()
        {
            return Convert.ToInt32(Base + Roof + Side1 + Side2);
        }
        // base fx to print to console, for checking for correct use
        // of inheritance 
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"One base is {Base} and the other is {Roof}");
        }
    }
}
