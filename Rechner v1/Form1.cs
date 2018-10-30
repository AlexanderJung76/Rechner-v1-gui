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
        public double vard1, vard2, ergebnisD, memory;
        public string opperator = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "1";            
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "2";
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "3";
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "4";
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "5";
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "6";
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "7";
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "8";
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "9";
        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += "0";
        }

        private void BTN_Comma_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text += ",";
        }

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
            RTB_Ausgabe_Fenster.Clear();
            opperator = "+";
        }

        private void BTN_Minus_Click(object sender, EventArgs e)
        {
            vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
            RTB_Ausgabe_Fenster.Clear();
            opperator = "-";
        }

        private void BTN_Multiply_Click(object sender, EventArgs e)
        {
            vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
            RTB_Ausgabe_Fenster.Clear();
            opperator = "*";
        }
        
        private void BTN_Division_Click(object sender, EventArgs e)
        {
            vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
            RTB_Ausgabe_Fenster.Clear();
            opperator = "/";
        }

        private void BTN_Sqrt_Click(object sender, EventArgs e)
        {
            vard1 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
            RTB_Ausgabe_Fenster.Clear();
            opperator = "sqrt";
        }

        private void BTN_Ergebnis_Click(object sender, EventArgs e)
        {
            if (opperator == "+")
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Clear();
                ergebnisD = vard1 + vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
            }

            if (opperator == "-")
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Clear();
                ergebnisD = vard1 - vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
            }

            if (opperator == "*")
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Clear();
                ergebnisD = vard1 * vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
            }

            if (opperator == "/")
            {
                vard2 = (Double.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Clear();
                ergebnisD = vard1 / vard2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
            }

            if (opperator == "sqrt")
            {
                RTB_Ausgabe_Fenster.Clear();
                ergebnisD = Math.Sqrt(vard1);
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisD);
            }
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {            
            vard1 = 0; vard2 = 0; ergebnisD = 0;
            RTB_Ausgabe_Fenster.Clear();
        }

        private void BTN_MS_Click(object sender, EventArgs e)
        {
            memory = ergebnisD;
        }

        private void BTN_MR_Click(object sender, EventArgs e)
        {
            RTB_Ausgabe_Fenster.Text = Convert.ToString(memory);
        }

        private void BTN_MC_Click(object sender, EventArgs e)
        {
            memory = 0.0;
        }





    }
}
