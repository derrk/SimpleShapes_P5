using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadLibrary
{
    public abstract class Quadrilateral
    {
        public string Name { get; set; }
        //  public int x1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //  public int y1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //   public int x2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //   public int y2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //   public int x3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //  public int x4 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
