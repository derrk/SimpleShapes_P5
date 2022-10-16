using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapes_P5
{
    internal class Trapezoid : Quadrilateral
    {
        public int Base { get; set; }
        public int Roof { get; set; }

        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public Trapezoid(int _base, int roof, int side1, int side2)
        {
            Name = "Trapezoid";
            Base = _base;
            Roof = roof;
            Side1 = side1;
            Side2 = side2;
        }

        public override int Area()
        {
           return (Base + Roof) /* height*/ / 2;
        }

        public override int Perimeter()
        {
            return Base + Roof + Side1 + Side2;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"One base is {Base} and the other is {Roof}");
        }
    }
}
