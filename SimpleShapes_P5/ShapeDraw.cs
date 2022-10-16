using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleShapes_P5
{
    internal class ShapeDraw
    {
        private void DrawEllipse()
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(0, 0, 200, 300));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void DrawRectangle()
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(0, 0, 200, 300));
            myPen.Dispose();
            formGraphics.Dispose();
        }
    }
}
