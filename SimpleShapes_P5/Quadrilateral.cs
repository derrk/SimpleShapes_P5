using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapes_P5
{
    abstract internal class Quadrilateral
    {

        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        //public abstract int x1 { get; set; }
        //public abstract int y1 { get; set; }

        //public abstract int x2 { get; set; }
        //public abstract int y2 { get; set; }

        public abstract int Area();
        public abstract int Perimeter();

    

    }
}
