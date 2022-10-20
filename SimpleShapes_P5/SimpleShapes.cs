/*
 *                  Derrik Pollock 
 *                  Program 5 - CMPS 4143
 *                  Due Date: 10/20/2022
 *                  Windows Form App .NET version 4.7.2
 *                  ***********************************
 *                  
 *                  All rights reserved.
 * 
 * This program is meant to generate quadrilaterals based on the users input
 * *********************************************************************
 * The program will have the user input XY coordinates depending on the 
 * shape they wish to generate. 
 * It will output the area and perimeter of the shape as well as a picture
 *  of the shape they generated. 
 *  There will be labels for each point; Some are user input and some are calculated
 *  by the program using arithmetic.
 *  *********************************************
 *  To begin: Select a quadrilateral you would like to generate, and then
 *  enter the XY points as allowed on screen. if the points are not needed manually,
 *  then the box will not allow you to enter. 
 *  You may only enter positive integer values. 
 *  There is no checking for valid xy on certain shapes due to not using the drawing system. 
 *  ****************************************************************************************
 *  
 *                 
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
//using System.Drawing;
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
        // create array list to store shapes in
        private ArrayList ShapeList = new ArrayList();
        int rectCount = 0;
        int sqrCount = 0;
        int parCount = 0;
        int trapCount = 0;
       
        public SimpleShapes()
        {     
        
            InitializeComponent();
            // disable boxes until user chooses a shape
            P1TextBox.Enabled = false;
            P2TextBox.Enabled = false;
            P3TextBox.Enabled = false;
            P4TextBox.Enabled = false;
            rectCountBox.Enabled = false;
            squareCountBox.Enabled = false;
            ParaCountBox.Enabled = false;
            TrapCountBox.Enabled = false;
            AreaTextBox.Enabled = false;
            PerimeterTextBox.Enabled = false;
            countBox.Enabled = false;
          
        }

        

        private void ShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this is where the combobox will use the index of the string
            // to determine which quadrilateral will be getting generated
            if (ShapeComboBox.SelectedIndex == 0)
            {
                Console.WriteLine("Selected Rectangle");
                P1TextBox.Enabled = true;
                P2TextBox.Enabled = true;
                P3TextBox.Enabled = true;
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
                P1TextBox.Enabled = true;
                P2TextBox.Enabled = true;
                P3TextBox.Enabled = true;
                x_P2.Enabled = false;
                P3box.Enabled = false;
                P4box.Enabled = false;
            }
            else if (ShapeComboBox.SelectedIndex == 2)
            {
                Console.WriteLine("Selected Parallelogram");
                // TODO: disable appropriate textboxes
                P1TextBox.Enabled = true;
                P2TextBox.Enabled = true;
                P3TextBox.Enabled = true;
                y_P3.Enabled = false;
                P4box.Enabled = false;
            }
            else if (ShapeComboBox.SelectedIndex == 3)
            {
                Console.WriteLine("Selected Trapezoid");
                // TODO: disable appropriate textboxes
                P1TextBox.Enabled = true;
                P2TextBox.Enabled = true;
                P3TextBox.Enabled = true;
                P4TextBox.Enabled = true;
                y_P4.Enabled = false;
            }
        }


        private void DrawButton_Click(object sender, EventArgs e)
        {
            // int for selection index in the combo box
            int selection = ShapeComboBox.SelectedIndex;

            int x1, y1, x2, y2, x3, y3, x4, y4;

            
            Console.WriteLine(ShapeList.Count);

            rectCountBox.Text = rectCount.ToString();
            squareCountBox.Text = sqrCount.ToString();
            ParaCountBox.Text = parCount.ToString();
            TrapCountBox.Text = trapCount.ToString();

            countBox.Text = ShapeList.Count.ToString();

            // switch case will determine which shape is being generated
            // as well as which points will be sent as necessary
            // switch case to instantiate new objects
            switch (selection)
            {
                case 0:
                    try
                    {
                        x1 = int.Parse(x_P1.Text);
                        y1 = int.Parse(y_P1.Text);
                        y2 = int.Parse(y_P2.Text);
                        x3 = int.Parse(x_P3.Text);
                        Rectangle rectangle = new Rectangle(x1, y1, x3, y2);
                        // output for debugging
                        Console.WriteLine($"{rectangle.Name} has points: {x1}, {y1}, {x3}, {y2}");
                        ShapeNameLabel.Text = rectangle.Name;
                        AreaTextBox.Text = rectangle.Area().ToString();
                        PerimeterTextBox.Text = rectangle.Perimeter().ToString();
                        // change the picture that shows in picture box, using local file that was added to project properties folder
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\derri\OneDrive\Desktop\DevDerrk\dev_projects\c_sharp\CMPS4143\derrk\SimpleShapes_P5\SimpleShapes_P5\Properties\rectangle.jpg");
                        ShapeList.Add(rectangle);
                        P1TextBox.Text = $"{rectangle.x1},{rectangle.y1}";
                        P2TextBox.Text = $"{rectangle.x2},{rectangle.y2}";
                        P3TextBox.Text = $"{rectangle.x3},{rectangle.y3}";
                        P4TextBox.Text = $"{rectangle.x4},{rectangle.y4}";
                        CountShapes();
                    }
                    catch (FormatException)
                    {
                        // show message box if the incorrect values are entered
                        MessageBox.Show("Wrong Format", "Enter an integer greater than 0",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    try
                    {
                        // square
                        x1 = int.Parse(x_P1.Text);
                        y1 = int.Parse(y_P1.Text);
                        y2 = int.Parse(y_P2.Text);
                        Square square = new Square(x1, y1, y2);
                        ShapeNameLabel.Text = square.Name;
                        AreaTextBox.Text = square.Area().ToString();
                        PerimeterTextBox.Text = square.Perimeter().ToString();
                        // change the picture that shows in picture box, using local file that was added to project properties folder
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\derri\OneDrive\Desktop\DevDerrk\dev_projects\c_sharp\CMPS4143\derrk\SimpleShapes_P5\SimpleShapes_P5\Properties\square.jpg");
                        ShapeList.Add(square);
                        P1TextBox.Text = $"{square.x1},{square.y1}";
                        P2TextBox.Text = $"{square.x2},{square.y2}";
                        P3TextBox.Text = $"{square.x3},{square.y3}";
                        P4TextBox.Text = $"{square.x4},{square.y4}";
                        CountShapes();
                    }
                    catch (FormatException)
                    {
                        // show message box if the incorrect values are entered
                        MessageBox.Show("Wrong Format", "Enter an integer greater than 0",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case 2:
                    try
                    {
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
                        // change the picture that shows in picture box, using local file that was added to project properties folder
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\derri\OneDrive\Desktop\DevDerrk\dev_projects\c_sharp\CMPS4143\derrk\SimpleShapes_P5\SimpleShapes_P5\Properties\parallelogram.jpg");
                        ShapeList.Add(parallelogram);
                        P1TextBox.Text = $"{parallelogram.x1},{parallelogram.y1}";
                        P2TextBox.Text = $"{parallelogram.x2},{parallelogram.y2}";
                        P3TextBox.Text = $"{parallelogram.x3},{parallelogram.y3}";
                        P4TextBox.Text = $"{parallelogram.x4},{parallelogram.y4}";
                        CountShapes();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Wrong Format", "Enter an integer greater than 0",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 3:
                    try
                    {
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
                        // change the picture that shows in picture box, using local file that was added to project properties folder
                        pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\derri\OneDrive\Desktop\DevDerrk\dev_projects\c_sharp\CMPS4143\derrk\SimpleShapes_P5\SimpleShapes_P5\Properties\trapezoid.jpg"); //("trapezoid.jpg");
                        ShapeList.Add(trapezoid);
                        P1TextBox.Text = $"{trapezoid.x1},{trapezoid.y1}";
                        P2TextBox.Text = $"{trapezoid.x2},{trapezoid.y2}";
                        P3TextBox.Text = $"{trapezoid.x3},{trapezoid.y3}";
                        P4TextBox.Text = $"{trapezoid.x4},{trapezoid.y4}";
                        CountShapes();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Wrong Format", "Enter an integer greater than 0",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }

        }
        // method to count the shapes in shapelist
        private void CountShapes()
        {
            foreach (Quadrilateral shape in ShapeList)
            {
                
                if (shape.Name == "Rectangle")
                    rectCount++;
                else if (shape.Name == "Square")
                    sqrCount++;
                else if (shape.Name == "Parallelogram")
                    parCount++;
                else if (shape.Name == "Trapezoid")
                    trapCount++;
            }
        }

        private void SimpleShapes_Load(object sender, EventArgs e)
        {
            foreach (Rectangle rectangle in ShapeList)
                rectCount++;
            foreach (Square square in ShapeList)
                sqrCount++;
            foreach (Parallelogram parallelogram in ShapeList)
                parCount++;
            foreach (Trapezoid trapezoid in ShapeList)
                trapCount++;

            rectCountBox.Text = rectCount.ToString();
            squareCountBox.Text = sqrCount.ToString();
            ParaCountBox.Text = parCount.ToString();
            TrapCountBox.Text = trapCount.ToString();

            countBox.Text = ShapeList.Count.ToString();
        }

        private void x_P1_TextChanged(object sender, EventArgs e)
        {

        }
        //
        // only allow numbers and backspace to prevent errors
        //
        private void x_P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void  y_P1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void x_P2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void y_P2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void x_P3_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void y_P3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void x_P4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

        }
        private void y_P4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
