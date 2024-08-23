using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCS
{
    public partial class Form1 : Form    
    {
        private double valor1;
        //private double valor2;
        private double resultado;

        List<double> valores = new List<double> {};
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //display
            
        }

        private void b0_Click(object sender, EventArgs e)
        {
            //0
            tbdisplay.Text = tbdisplay.Text + "0";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            //1
            tbdisplay.Text = tbdisplay.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            //2
            tbdisplay.Text = tbdisplay.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            //3
            tbdisplay.Text = tbdisplay.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            //4
            tbdisplay.Text = tbdisplay.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            //5
            tbdisplay.Text = tbdisplay.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            //6
            tbdisplay.Text = tbdisplay.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            //7
            tbdisplay.Text = tbdisplay.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            //8
            tbdisplay.Text = tbdisplay.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            //9
            tbdisplay.Text = tbdisplay.Text + "9";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            // C
            tbdisplay.Text = " ";
            valores.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            // =
            //valor2 = Convert.ToDouble(tbdisplay.Text);
            //resultado = valor2 + valor1;
            //tbdisplay.Text = resultado.ToString();
            valores.Add(valor1);
            resultado = valores.Sum();
            tbdisplay.Text = resultado.ToString();
            valores.Remove(valor1);
            
        }

        private void suma_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(tbdisplay.Text);
            valores.Add(valor1);
            tbdisplay.Text = " ";

           
            
        }
    }
}
