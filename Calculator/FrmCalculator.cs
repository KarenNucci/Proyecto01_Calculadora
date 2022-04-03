using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmCalculator : Form
    {
        string operador, calculi;
        List<string> calculation = new List<string>();
        int num, num2, calc;
        bool click = false;
        public FrmCalculator() { InitializeComponent(); }

        public int Calcular()
        {
            foreach (string S in calculation)
            {
                if (S == Convert.ToString(0) || S == Convert.ToString(1)|| S == Convert.ToString(2))
                {
                    if (num == 0) { num = Convert.ToInt32(S); }
                    else {
                        num2 = Convert.ToInt32(S);
                        if (operador == "+")
                        {
                            calc = num + num2;
                            num = 0;
                            num2 = 0;
                            break;
                        }
                    }
                    //if (num2 == 0)
                    //{ 
                    //    num2 = Convert.ToInt32(S);
                    //    if (operador == "+")
                    //    {
                    //        calc = num + num2;
                    //        num = 0;
                    //        num2 = 0;
                    //        break;
                    //    }
                    //}
                }
                if (S == "+")
                {
                    operador = "+";
                    //calc = num + num2;
                    //num = 0;
                    //num2 = 0;
                    //break;
                }
                else if (S == "-") { }
                else if (S == "*") { }
                else { }
            }
            return calc;
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            calculi = Convert.ToString(Calcular());
            tbCalculation.Text += "=" + calculi;
            click = true;
        }

        public void UsoOperador()
        {
            if (!tbCalculation.Text.EndsWith(operador)) { Calcular(); }
        }

        //Botón Borrar todo
        private void btnC_Click(object sender, EventArgs e)
        {
            tbCalculation.Text = string.Empty;
        }

        //Botón Suma
        private void btnAddition_Click(object sender, EventArgs e)
        {

            if (click == true)
            {
                tbCalculation.Text = calculi;
                click = false;
                operador = "+";
                calculation.Add("+");
                tbCalculation.Text += operador;
            }
            else
            {
                operador = "+";
                calculation.Add("+");
                tbCalculation.Text += operador;
                //UsoOperador();}
            }
        }

        //Botón Resta
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            tbCalculation.Text += "-";
            //calculo += "-";
        }

        //Botón Borrar
        private void btCe_Click(object sender, EventArgs e)
        {
            tbCalculation.Text += tbCalculation.Text.Substring(0, tbCalculation.Text.Count() - 1);
        }

        //Botón Multiplicación
        private void btnMultiplication_Click(object sender, EventArgs e)
        {

        }

        //Botón División
        private void btnDivision_Click(object sender, EventArgs e)
        {

        }

        //Botón Punto
        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        //Botón Cero
        private void btn0_Click(object sender, EventArgs e)
        {

        }

        //Botón Uno
        private void btn1_Click(object sender, EventArgs e)
        {
            calculi = "1";
            calculation.Add("1");
            tbCalculation.Text += calculi;
            //calculo += "1";
        }

        //Botón Dos
        private void btn2_Click(object sender, EventArgs e)
        {
            tbCalculation.Text += "2";
            //calculo += "2";
        }

        //Botón Tres
        private void btn3_Click(object sender, EventArgs e)
        {
            
        }

        //Botón Cuatro
        private void btn4_Click(object sender, EventArgs e)
        {
            
        }

        //Botón Cinco
        private void btn5_Click(object sender, EventArgs e)
        {
            
        }

        //Botón Seis
        private void btn6_Click(object sender, EventArgs e)
        {
            
        }

        //Botón Siete
        private void btn7_Click(object sender, EventArgs e)
        {
            
        }

        //Botón Ocho
        private void btn8_Click(object sender, EventArgs e)
        {
            
        }

        //Botón Nueve
        private void btn9_Click(object sender, EventArgs e)
        {
            
        } 
    }
}
