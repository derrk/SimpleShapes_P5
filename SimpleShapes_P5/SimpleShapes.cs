using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuadLibrary;
using static System.Net.Mime.MediaTypeNames;
/*using System.Drawing;*/


namespace SimpleShapes_P5
{
    public partial class SimpleShapes : Form
    {

        private ArrayList ShapeList = new ArrayList();

       
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
                    ShapeNameLabel.Text = rectangle.Name;
                   AreaTextBox.Text = rectangle.Area().ToString();
                    PerimeterTextBox.Text = rectangle.Perimeter().ToString();
                    pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\derri\OneDrive\Desktop\DevDerrk\dev_projects\c_sharp\CMPS4143\derrk\SimpleShapes_P5\SimpleShapes_P5\Properties\rectangle.jpg");
                    ShapeList.Add(rectangle);
                    break;
                case 1:
                    // square
                    x1 = int.Parse(x_P1.Text);
                    y1 = int.Parse(y_P1.Text);
                    y2= int.Parse(y_P2.Text);
                    Square square = new Square(x1, y1, y2);
                    ShapeNameLabel.Text = square.Name;
                    AreaTextBox.Text = square.Area().ToString();
                    PerimeterTextBox.Text = square.Perimeter().ToString();
                    pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\derri\OneDrive\Desktop\DevDerrk\dev_projects\c_sharp\CMPS4143\derrk\SimpleShapes_P5\SimpleShapes_P5\Properties\square.jpg");
                    ShapeList.Add(square);
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
                    ShapeNameLabel.Text = parallelogram.Name;
                    AreaTextBox.Text = parallelogram.Area().ToString();
                    PerimeterTextBox.Text = parallelogram.Perimeter().ToString();
                    pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\derri\OneDrive\Desktop\DevDerrk\dev_projects\c_sharp\CMPS4143\derrk\SimpleShapes_P5\SimpleShapes_P5\Properties\parallelogram.jpg");
                    ShapeList.Add(parallelogram);
                    break;
                case 3:
                    // trapezoid
                    // needs all 4 points from user
                    // Point 1
                    x1 = int.Parse(x_P1.Text);
                    y1 = int.Parse(y_P1.Text);
                    // Point 2
                    x2 = int.Parse(x_P2.Text);
                    y2 = int.Parse(y_P2.Text);
                    // Point 3
                    x3 = int.Parse(x_P3.Text);
                    y3 = y1;
                    // Point 4
                    x4 = int.Parse(x_P4.Text);
                    y4 = y2;

                    Trapezoid trapezoid = new Trapezoid(x1, y1, x2, y2, x3, y3, x4, y4);
                    ShapeNameLabel.Text = trapezoid.Name;
                    AreaTextBox.Text = trapezoid.Area().ToString();
                    PerimeterTextBox.Text = trapezoid.Perimeter().ToString();
                    pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\derri\OneDrive\Desktop\DevDerrk\dev_projects\c_sharp\CMPS4143\derrk\SimpleShapes_P5\SimpleShapes_P5\Properties\trapezoid.jpg"); //("trapezoid.jpg");
                    ShapeList.Add(trapezoid);
                    break;
                default:
                    break;
            }
           
        }
    }
}
