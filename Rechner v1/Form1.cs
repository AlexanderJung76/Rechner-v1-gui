using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechner_v1
{
    public partial class Form1 : Form
    {        
        private double vard1, vard2, ergebnisD = 0, memory;
        private string opperator = " ";
        private Color temp_bgColor;
        private bool reclick = false;
        

        public Form1()
        {
            InitializeComponent();
            RTB_Ausgabe_Fenster.Text = "0";
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false)
            {
                RTB_Ausgabe_Fenster.Text += "1";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "1";
            reclick = false;
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false)
            {
                RTB_Ausgabe_Fenster.Text += "2";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "2";
            reclick = false;
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false) 
            {
                RTB_Ausgabe_Fenster.Text += "3";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "3";
            reclick = false;
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false)
            {
                RTB_Ausgabe_Fenster.Text += "4";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "4";
            reclick = false;
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false)
            {
                RTB_Ausgabe_Fenster.Text += "5";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "5";
            reclick = false;
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false)
            {
                RTB_Ausgabe_Fenster.Text += "6";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "6";
            reclick = false;
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false)
            {
                RTB_Ausgabe_Fenster.Text += "7";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "7";
            reclick = false;
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false)
            {
                RTB_Ausgabe_Fenster.Text += "8";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "8";
            reclick = false;
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false)
            {
                RTB_Ausgabe_Fenster.Text += "9";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "9";
            reclick = false;
        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text != "0" && reclick == false)
            {
                RTB_Ausgabe_Fenster.Text += "0";
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "0";
            reclick = false;
        }

        private void BTN_Comma_Click(object sender, EventArgs e)
        {
            if (!RTB_Ausgabe_Fenster.Text.Contains(","))
            {
                RTB_Ausgabe_Fenster.Text += ",";
                reclick = false;
            }
        }

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            if (vard1 == 0)
            {
                vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Text = "0";
                opperator = "+";
                reclick = false;
            }
            else
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                if (ergebnisD == 0)
                {
                    ergebnisD = vard1 + vard2;
                }
                else ergebnisD += vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
                vard1 = ergebnisD;
                opperator = "+";
                reclick = true;
            }
        }

        private void BTN_Minus_Click(object sender, EventArgs e)
        {
            if (vard1 == 0)
            {
                vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Text = "0";
                opperator = "-";
                reclick = false;
            }
            else
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                if (ergebnisD == 0)
                {
                    ergebnisD = vard1 - vard2;
                }
                else ergebnisD -= vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
                vard1 = ergebnisD;
                opperator = "-";
                reclick = true;
            }
        }

        private void BTN_Multiply_Click(object sender, EventArgs e)
        {
            if (vard1 == 0)
            {
                vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Text = "0";
                opperator = "*";
                reclick = false;
            }
            else
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                if (ergebnisD == 0)
                {
                    ergebnisD = vard1 * vard2;
                }
                else ergebnisD *= vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
                vard1 = ergebnisD;
                opperator = "*";
                reclick = true;
            }
        }
        
        private void BTN_Division_Click(object sender, EventArgs e)
        {
            if (vard1 == 0)
            {
                vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Text = "0";
                opperator = "/";
                reclick = false;
            }
            else
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                if (ergebnisD == 0)
                {
                    ergebnisD = vard1 / vard2;
                }
                else ergebnisD /= vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
                vard1 = ergebnisD;
                opperator = "/";
                reclick = true;
            }
        }

        private void BTN_Sqrt_Click(object sender, EventArgs e)
        {
            vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
            ergebnisD = Math.Sqrt(vard1);
            RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
            reclick = false;
        }

        private void BTN_Prozent_Click(object sender, EventArgs e)
        {
            vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));           // Not Working
            RTB_Ausgabe_Fenster.Text = "0";
            opperator = "%";
            reclick = false;
        }

        private void BTN_X2_Click(object sender, EventArgs e)
        {
            vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
            ergebnisD = vard1 + (vard1 * vard1);
            RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
            reclick = false;
        }

        private void BTN_Ergebnis_Click(object sender, EventArgs e)
        {
            if (opperator == "+")
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text)); // Error Catch Methode benötigt >> Fixed
                RTB_Ausgabe_Fenster.Text = "0";
                ergebnisD = vard1 + vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
                reclick = false;
            }

            if (opperator == "-")
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Text = "0";
                ergebnisD = vard1 - vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
                reclick = false;
            }

            if (opperator == "*")
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Text = "0";
                ergebnisD = vard1 * vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
                reclick = false;
            }

            if (opperator == "/")
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Text = "0";
                ergebnisD = vard1 / vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
                reclick = false;
            }            

            if (opperator == "%")
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));       // Not Working
                RTB_Ausgabe_Fenster.Text = "0";
                ergebnisD = vard1 + (vard2/100*vard2);
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
                reclick = false;
            }
            vard1 = 0;
            vard2 = 0;            
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {            
            vard1 = 0; vard2 = 0; ergebnisD = 0;
            RTB_Ausgabe_Fenster.Text = "0";
            reclick = false;
        }
        
        private void BTN_CE_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text = "0";
        }

        private void BTN_MS_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(RTB_Ausgabe_Fenster.Text);
            reclick = false;
        }
        
        private void BTN_MR_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text = Convert.ToString(memory);
            reclick = false;
        }

        private void BTN_MC_Click(object sender, EventArgs e)
        {
            memory = 0.0;
            reclick = false;
        }

        private void BTN_Backspace_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text.Length > 1)
            {
                RTB_Ausgabe_Fenster.Text = RTB_Ausgabe_Fenster.Text.Remove(RTB_Ausgabe_Fenster.Text.Length - 1);
                reclick = false;
            }
            else RTB_Ausgabe_Fenster.Text = "0";
            reclick = false;
        }

        private void RB_Defalt_Color_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = temp_bgColor;
        }

        private void RB_First_Color_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void BTN_Negative_Click(object sender, EventArgs e)
        {
            if (RTB_Ausgabe_Fenster.Text.Contains("-"))
            {

                RTB_Ausgabe_Fenster.Text =  RTB_Ausgabe_Fenster.Text.Remove(RTB_Ausgabe_Fenster.Text.Length -1);
                reclick = false;
            }
            else
            {
                RTB_Ausgabe_Fenster.Text += "-";
                reclick = false;
            }
        }
    }
}
