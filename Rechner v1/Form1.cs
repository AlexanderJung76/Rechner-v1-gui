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
        public int vari1, vari2,ergebnisI;
        public double vard1, vard2,ergebnisD;
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
            RTB_Ausgabe_Fenster.Text += ".";
        }

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            vari1 = (Int32.Parse(RTB_Ausgabe_Fenster.Text));
            RTB_Ausgabe_Fenster.Clear();
            opperator = "+";
        }

        private void BTN_Minus_Click(object sender, EventArgs e)
        {
            vari1 = (Int32.Parse(RTB_Ausgabe_Fenster.Text));
            RTB_Ausgabe_Fenster.Clear();
            opperator = "-";
        }

        private void BTN_Multiply_Click(object sender, EventArgs e)
        {
            vari1 = (Int32.Parse(RTB_Ausgabe_Fenster.Text));
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
                vari2 = (Int32.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Clear();
                ergebnisI = vari1 + vari2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisI);
            }

            if (opperator == "-")
            {
                vari2 = (Int32.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Clear();
                ergebnisI = vari1 - vari2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisI);
            }

            if (opperator == "*")
            {
                vari2 = (Int32.Parse(RTB_Ausgabe_Fenster.Text));
                RTB_Ausgabe_Fenster.Clear();
                ergebnisI = vari1 * vari2;
                RTB_Ausgabe_Fenster.Text = Convert.ToString(ergebnisI);
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
            vard1 = 0.0; vard2 = 0.0; ergebnisD = 0.0;
            vari1 = 0; vari2 = 0; ergebnisI = 0;
            RTB_Ausgabe_Fenster.Clear();
        }
    }
}
