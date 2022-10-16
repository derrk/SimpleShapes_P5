using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleShapes_P5
{
    public partial class SimpleShapes : Form
    {
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

            }
            else if (ShapeComboBox.SelectedIndex == 1)
            {
                Console.WriteLine("Selected Square");
            }
            else if (ShapeComboBox.SelectedIndex == 2)
            {
                Console.WriteLine("Selected Parallelogram");
            }
            else if (ShapeComboBox.SelectedIndex == 3)
            {
                Console.WriteLine("Selected Trapezoid");
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            string shape = ShapeComboBox.SelectedText;
            Console.WriteLine(shape);
        }
    }
}
