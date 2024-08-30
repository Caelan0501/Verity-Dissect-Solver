using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verity_Dissect_Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Sphere")
            {
                pictureBox2.Image = Properties.Resources.sphere;
            }
            else if (comboBox2.Text == "Prism")
            {
                pictureBox2.Image = Properties.Resources.prism;
            }
            else if (comboBox2.Text == "Cube")
            {
                pictureBox2.Image = Properties.Resources.cube;
            }
            else if ((comboBox2.Text == "Cone"))
            {
                pictureBox2.Image = Properties.Resources.cone;
            }
            else if ((comboBox2.Text == "Cylinder"))
            {
                pictureBox2.Image = Properties.Resources.cylinder;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.tetra;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sphere")
            {
                pictureBox1.Image = Properties.Resources.sphere;
            }
            else if (comboBox1.Text == "Prism")
            {
                pictureBox1.Image = Properties.Resources.prism;
            }
            else if(comboBox1.Text == "Cube")
            {
                pictureBox1.Image = Properties.Resources.cube;
            }
            else if ((comboBox1.Text == "Cone"))
            {
                pictureBox1.Image = Properties.Resources.cone;
            }
            else if ((comboBox1.Text == "Cylinder"))
            {
                pictureBox1.Image = Properties.Resources.cylinder;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.tetra;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Sphere")
            {
                pictureBox3.Image = Properties.Resources.sphere;
            }
            else if (comboBox1.Text == "Prism")
            {
                pictureBox3.Image = Properties.Resources.prism;
            }
            else if (comboBox3.Text == "Cube")
            {
                pictureBox3.Image = Properties.Resources.cube;
            }
            else if ((comboBox3.Text == "Cone"))
            {
                pictureBox3.Image = Properties.Resources.cone;
            }
            else if ((comboBox3.Text == "Cylinder"))
            {
                pictureBox3.Image = Properties.Resources.cylinder;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.tetra;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length == 3))
            {
                if (textBox1.Text[0] == 'S' || textBox1.Text[0] == 's')
                {
                    pictureBox4.Image = Properties.Resources.cone;
                }
                else if (textBox1.Text[0] == 'C' || textBox1.Text[0] == 'c')
                {
                    pictureBox4.Image = Properties.Resources.prism;
                }
                else if (textBox1.Text[0] == 'T' || textBox1.Text[0] == 't')
                {
                    pictureBox4.Image = Properties.Resources.cylinder ;
                }

                if (textBox1.Text[1] == 'S' || textBox1.Text[1] == 's')
                {
                    pictureBox5.Image = Properties.Resources.cone;
                }
                else if (textBox1.Text[1] == 'C' || textBox1.Text[1] == 'c')
                {
                    pictureBox5.Image = Properties.Resources.prism;
                }
                else if (textBox1.Text[1] == 'T' || textBox1.Text[1] == 't')
                {
                    pictureBox5.Image = Properties.Resources.cylinder;
                }

                if (textBox1.Text[2] == 'S' || textBox1.Text[2] == 's')
                {
                    pictureBox6.Image = Properties.Resources.cone;
                }
                else if (textBox1.Text[2] == 'C' || textBox1.Text[2] == 'c')
                {
                    pictureBox6.Image = Properties.Resources.prism;
                }
                else if (textBox1.Text[2] == 'T' || textBox1.Text[2] == 't')
                {
                    pictureBox6.Image = Properties.Resources.cylinder;
                }
            }
        }

        private void Solve()
        {
            if (textBox1.Text.Length != 3)
            {
                return;
            }
            char AntiShape1 = textBox1.Text[0];
            char AntiShape2 = textBox1.Text[1];
            char AntiShape3 = textBox1.Text[2];

            string one = comboBox1.Text;
            string two = comboBox2.Text;
            string three = comboBox3.Text;

            char[] Shape1 = new char[2];
            char[] Shape2 = new char[2];
            char[] Shape3 = new char[2];
            switch (one)
            {
                case "Cone":
                {
                    Shape1[0] = 'T';
                    Shape1[1] = 'C';
                    break;
                }
                case "Cube":
                {
                    Shape1[0] = 'S';
                    Shape1[1] = 'S';
                    break;
                }
                case "Sphere":
                {
                    Shape1[0] = 'C';
                    Shape1[1] = 'C';
                    break;
                }
                case "Prism":
                {
                    Shape1[0] = 'S';
                    Shape1[1] = 'T';
                    break;
                }
                case "Cylinder":
                {
                    Shape1[0] = 'C';
                    Shape1[1] = 'S';
                    break;
                }
                case "Pyramid":
                {
                    Shape1[0] = 'T';
                    Shape1[1] = 'T';
                    break;
                }
            }
            switch (two)
            {
                case "Cone":
                    {
                        Shape2[0] = 'T';
                        Shape2[1] = 'C';
                        break;
                    }
                case "Cube":
                    {
                        Shape2[0] = 'S';
                        Shape2[1] = 'S';
                        break;
                    }
                case "Sphere":
                    {
                        Shape2[0] = 'C';
                        Shape2[1] = 'C';
                        break;
                    }
                case "Prism":
                    {
                        Shape2[0] = 'S';
                        Shape2[1] = 'T';
                        break;
                    }
                case "Cylinder":
                    {
                        Shape2[0] = 'C';
                        Shape2[1] = 'S';
                        break;
                    }
                case "Pyramid":
                    {
                        Shape2[0] = 'T';
                        Shape2[1] = 'T';
                        break;
                    }
            }
            switch (three)
            {
                case "Cone":
                    {
                        Shape3[0] = 'T';
                        Shape3[1] = 'C';
                        break;
                    }
                case "Cube":
                    {
                        Shape3[0] = 'S';
                        Shape3[1] = 'S';
                        break;
                    }
                case "Sphere":
                    {
                        Shape3[0] = 'C';
                        Shape3[1] = 'C';
                        break;
                    }
                case "Prism":
                    {
                        Shape3[0] = 'S';
                        Shape3[1] = 'T';
                        break;
                    }
                case "Cylinder":
                    {
                        Shape3[0] = 'C';
                        Shape3[1] = 'S';
                        break;
                    }
                case "Pyramid":
                    {
                        Shape3[0] = 'T';
                        Shape3[1] = 'T';
                        break;
                    }
            }

            string result = "";

            //Check for Double Shapes
            bool double1 = Shape1[0] == Shape1[1];
            bool double2 = Shape2[0] == Shape2[1];
            bool double3 = Shape3[0] == Shape3[1];
            bool antiColumn1 = double1 && (AntiShape1 == Shape1[0]);
            bool antiColumn2 = double2 && (AntiShape2 == Shape2[0]);
            bool antiColumn3 = double3 && (AntiShape3 == Shape3[0]);
            if (double1 && double2)
            {
                if (antiColumn1 && antiColumn2) //All Full anticolumns
                {
                    //Distrubute 1
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";

                    //Quick Swap
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                }
                else if (antiColumn1)
                {
                    //Distribute 1
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                }
                else if (antiColumn2)
                {
                    //Distribute 2
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                }
                else if (antiColumn3)
                {
                    //Distribute 3
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT";
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                }
                else //No Anti columns
                {
                    //Rotate
                    result += "Dissect " + charToString(Shape1[0]) + " into LEFT\n";
                    result += "Dissect " + charToString(Shape2[0]) + " into MIDDLE\n";
                    result += "Dissect " + charToString(Shape2[0]) + " into MIDDLE\n";
                    result += "Dissect " + charToString(Shape3[0]) + " into RIGHT\n";
                }
            }
            else if(double1 || double2 || double3)//One double
            {
                if(antiColumn1)
                {
                    //Complex swap
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                }
                else if (antiColumn2)
                {
                    //Complex Swap
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                }
                else if (antiColumn3)
                {
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                }
                else
                {
                    //Quick Swap
                    if(double1)
                    {
                        result += "Dissect " + charToString(Shape1[0]) + " into LEFT\n";
                        if (Shape1[0] == AntiShape2)
                            result += "Dissect " + charToString(Shape3[0]) + " into RIGHT\n";
                        else
                            result += "Dissect " + charToString(Shape2[0]) + " into MIDDLE\n";
                    }
                    if (double2)
                    {
                        result += "Dissect " + charToString(Shape2[0]) + " into MIDDLE\n";
                        if (Shape1[0] == AntiShape1)
                            result += "Dissect " + charToString(Shape3[0]) + " into RIGHT\n";
                        else
                            result += "Dissect " + charToString(Shape1[0]) + " into LEFT\n";
                    }
                    if (double3)
                    {
                        result += "Dissect " + charToString(Shape3[0]) + " into RIGHT\n";
                        if (Shape1[0] == AntiShape2)
                            result += "Dissect " + charToString(Shape1[0]) + " into LEFT\n";
                        else
                            result += "Dissect " + charToString(Shape2[0]) + " into MIDDLE\n";
                    }
                }
            }
            else//No Doubles
            {
                bool swapCol1 = (AntiShape1 == Shape1[0] || AntiShape1 == Shape1[1]);
                bool swapCol2 = (AntiShape2 == Shape2[0] || AntiShape2 == Shape2[1]);
                bool swapCol3 = (AntiShape3 == Shape3[0] || AntiShape3 == Shape3[1]);
                if (swapCol1 && swapCol2)
                {
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                }
                else if (swapCol2 && swapCol3)
                {
                    result += "Dissect " + charToString(AntiShape2) + " into MIDDLE\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                }
                else if (swapCol1 && swapCol3)
                {
                    result += "Dissect " + charToString(AntiShape1) + " into LEFT\n";
                    result += "Dissect " + charToString(AntiShape3) + " into RIGHT\n";
                }
                else
                {
                    result += "Imagine Swapping this round\n";
                }
            }

            ResultLabel.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Solve();
        }

        private string charToString(char c)
        {
            if (c == 'C')
            {
                return "CIRCLE";
            }
            else if (c == 'T')
            {
                return "TRIANGLE";
            }
            else
            {
                return "SQUARE";
            }
        }
    }
}
