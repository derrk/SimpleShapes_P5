using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuadLibrary;
/*using System.Drawing;*/


namespace SimpleShapes_P5
{
    public partial class SimpleShapes : Form
    {
       // Vector<Quadrilateral> ArrayofShapes;
        public SimpleShapes()
        {
            Console.WriteLine("Brrz");

            
           // Rectangle Rectangle1 = new Rectangle;
            InitializeComponent();
        }

        private void ShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this is where the combobox will use the index of the string
            // to determine which quadrilateral will be getting generated
            if (ShapeComboBox.SelectedIndex == 0)
            {
                Console.WriteLine("Selected Rectangle");
                x_P2.Enabled = false;
                y_P3.Enabled = false;
                P4box.Enabled = false;
                x_P2.Text = x_P1.Text;
                y_P3.Text = y_P1.Text;

            }
            else if (ShapeComboBox.SelectedIndex == 1)
            {
                Console.WriteLine("Selected Square");
                // TODO: disable appropriate textboxes
            }
            else if (ShapeComboBox.SelectedIndex == 2)
            {
                Console.WriteLine("Selected Parallelogram");
                // TODO: disable appropriate textboxes
            }
            else if (ShapeComboBox.SelectedIndex == 3)
            {
                Console.WriteLine("Selected Trapezoid");
                // TODO: disable appropriate textboxes
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            // int for selection index in the combo box
            int selection = ShapeComboBox.SelectedIndex;

            int x1, y1, x2, y2, x3, y3, x4, y4;

            // switch case will determine which shape is being generated
            // as well as which points will be sent as necessary
            switch (selection){
                case 0:
                    x1 = int.Parse(x_P1.Text);
                    y1 = int.Parse(y_P1.Text);
                    y2 = int.Parse(y_P2.Text);
                    x3 = int.Parse(x_P3.Text);
                  Rectangle rectangle = new Rectangle(x1, y1, x3, y2);
                    Console.WriteLine($"{rectangle.Name} has points: {x1}, {y1}, {x3}, {y2}");
                   AreaTextBox.Text = rectangle.Area().ToString();
                    PerimeterTextBox.Text = rectangle.Perimeter().ToString();
                    
                    break;
                case 1:
                    // square
                    x1 = int.Parse(x_P1.Text);
                    y1 = int.Parse(y_P1.Text);
                    y2= int.Parse(y_P2.Text);
                    Square square = new Square(x1, y1, y2);
                    AreaTextBox.Text = square.Area().ToString();
                    PerimeterTextBox.Text = square.Perimeter().ToString();
                    break;
                case 2:
                    // parallelogram
                    // Point 1
                    x1 = int.Parse(x_P1.Text);
                    y1 = int.Parse(y_P1.Text);
                    // Point 2
                    x2 = int.Parse(x_P2.Text);
                    y2 = int.Parse(y_P2.Text);
                    // Point 3 x only
                    x3 = int.Parse(x_P3.Text);
                    Parallelogram parallelogram = new Parallelogram(x1, y1, x2, y2, x3); 

                    AreaTextBox.Text = parallelogram.Area().ToString();
                    PerimeterTextBox.Text = parallelogram.Perimeter().ToString();

                    break;
                case 3:
                    // trapezoid
                    break;
                default:
                    break;
            }
           
        }
    }
}
