using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// base class for inheritance hiearchy - idk how to spell
namespace QuadLibrary
{
    public abstract class Quadrilateral
    {
        public string Name { get; set; }
 
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
        public abstract int Area();
        public abstract int Perimeter();
    }
}
