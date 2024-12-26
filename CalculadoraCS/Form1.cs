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
        private double valor2;
        private double resultado;

        private int operacion;

        private bool Pressed = false;

        //List<double> valores = new List<double> {};
        public Form1()
        {
            InitializeComponent();
            
        }

        private void b0_Click(object sender, EventArgs e)
        {
            //0
            if (tbdisplay.Text == "0")
            {
                tbdisplay.Text = "0";
                
            }
            else if (Pressed){
                tbdisplay.Text = "0";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "0";
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            //1
            if (tbdisplay.Text == "0")
            {
                tbdisplay.Text = "1";   
            }
            else if (Pressed)
            {
                tbdisplay.Text = "1";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "1";
            }
            
        }

        private void b2_Click(object sender, EventArgs e)
        {
            //2
            if (tbdisplay.Text == "0" )
            {
                tbdisplay.Text = "2";
            }
            else if (Pressed)
            {
                tbdisplay.Text = "2";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            //3
            if (tbdisplay.Text == "0" )
            {
                tbdisplay.Text = "3";
            }
            else if (Pressed)
            {
                tbdisplay.Text = "3";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            //4
            if (tbdisplay.Text == "0")
            {
                tbdisplay.Text = "4";
            }
            else if (Pressed)
            {
                tbdisplay.Text = "4";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            //5
            if (tbdisplay.Text == "0")
            {
                tbdisplay.Text = "5";
            }
            else if (Pressed)
            {
                tbdisplay.Text = "5";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            //6
            if (tbdisplay.Text == "0")
            {
                tbdisplay.Text = "6";
            }
            else if (Pressed)
            {
                tbdisplay.Text = "6";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            //7
            if (tbdisplay.Text == "0")
            {
                tbdisplay.Text = "7";
            }
            else if (Pressed)
            {
                tbdisplay.Text = "7";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            //8
            if (tbdisplay.Text == "0")
            {
                tbdisplay.Text = "8";
                Pressed = false;
            }
            else if (Pressed)
            {
                tbdisplay.Text = "8";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            //9
            if (tbdisplay.Text == "0")
            {
                tbdisplay.Text = "9";
            }
            else if (Pressed)
            {
                tbdisplay.Text = "9";
                Pressed = false;
                tbg.Text = "";
            }
            else
            {
                tbdisplay.Text = tbdisplay.Text + "9";
            }
        }

        private void bC_Click(object sender, EventArgs e)
        {
            // C
            tbdisplay.Text = "0";
            tbg.Text = "";
            valor1 = 0;
            //valores.Clear();
        }

        private void bcoma_Click(object sender, EventArgs e)
        {
            tbdisplay.Text = tbdisplay.Text + ".";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            // =
            valor2 = Convert.ToDouble(tbdisplay.Text);
            
            //valores.Add(valor1);
            //resultado = valores.Sum();
            //tbdisplay.Text = resultado.ToString();

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    tbg.Text = $"{valor1} + {valor2} =";
                    
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    tbg.Text = $"{valor1} - {valor2} =";
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    tbg.Text = $"{valor1} x {valor2} =";
                    break;
                case 4:
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                        tbg.Text = $"{valor1} ÷ {valor2} =";
                    }
                    else
                    {
                        tbdisplay.Text = " ";
                    }      
                    break;
            }

            tbdisplay.Text = resultado.ToString();
            Pressed = true;
        }

        private void suma_Click(object sender, EventArgs e)
        {
            operacion = 1;          
            valor1 = Convert.ToDouble(tbdisplay.Text);
            tbg.Text = $"{valor1} +";
            tbdisplay.Text = "0";  
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(tbdisplay.Text);
            tbg.Text = $"{valor1} -";
            tbdisplay.Text = "0";
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(tbdisplay.Text);
            tbg.Text = $"{valor1} x";
            tbdisplay.Text = "0";
        }

        private void divicion_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(tbdisplay.Text);
            tbg.Text = $"{valor1} ÷";
            tbdisplay.Text = "0";
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            // borrar
            if (tbdisplay.Text.Length > 1)
            {
                tbdisplay.Text = tbdisplay.Text.Substring(0, tbdisplay.Text.Length - 1);
            }
            else
            {
                tbdisplay.Text = "0";
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            // -/+
            valor1 = Convert.ToDouble(tbdisplay.Text);
            valor1 *= -1;
            tbdisplay.Text = valor1.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // display
            this.ActiveControl = igual;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //%
            double res = 0;
            valor2 = Convert.ToDouble(tbdisplay.Text);
            res = (valor1 * valor2) / 100;
            tbg.Text = tbg.Text + res;
            tbdisplay.Text = res.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // sqr(x)
            double res = 0;
            valor1 = Convert.ToDouble(tbdisplay.Text);
            res = valor1 * valor1;
            tbg.Text = $"sqr({valor1})";
            tbdisplay.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 1/x
            double res = 0;
            valor1 = Convert.ToDouble(tbdisplay.Text);
            res = 1 / valor1;
            tbg.Text = $"1/({valor1})";
            tbdisplay.Text = res.ToString();
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            // CE
            tbdisplay.Text = "0";
        }
    }
}
