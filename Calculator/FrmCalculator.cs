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
        //Lista que guarda todos los nums y operaciones
        List<string> calculation = new List<string>();
        //Variables que guarda nums ingresados
        int num1, num2;
        //Variable que avisa que ya hay un cálculo realizado
        bool click = false;
        //Variable que guarda el operador(+,-,*,/)
        string _operator;

        bool opT = false;
        int calc;
        string number;

        public FrmCalculator() { InitializeComponent(); }

        public bool OperatorType(string op)
        {
            if (op == "+" || op == "-" || op == "=") { opT = true; }

            return opT;
        }

        #region Métodos
        public int Calcular()
        {
            foreach (string S in calculation)
            {
                //Pregunta primero si es operador, y sino se va para número (evito escribir un largo if)
                if (OperatorType(S) == true) { opT = false; }
                else
                {
                    if (num1 == 0) { num1 = Convert.ToInt32(S); }
                    else
                    {
                        num2 = Convert.ToInt32(S);
                        if (_operator == "+")
                        {
                            calc = num1 + num2;
                            num1 = 0;
                            num2 = 0;
                            break;
                        }
                    }
                }
            }
            return calc;
            
        }
        
        public void UsoOperador()
        {
            if (!tbCalculation.Text.EndsWith(_operator)) { Calcular(); }
        }
        #endregion

        #region Botones
        #region Botones de signos
        private void btnEquals_Click(object sender, EventArgs e)
        {
            number = Convert.ToString(Calcular());
            tbCalculation.Text += "=" + number;
            click = true;

            //Obtiene el largo original de la lista, que luega se irá borrando
            int quantity = calculation.Count;

            foreach (string S in calculation)
            {
                int i = 0; //Variable que indica índice de la lista
                for (int j = 0; j < quantity; j++)
                {
                    calculation.RemoveAt(i);
                }
                break;
            }
            //Agrego el último número a la lista "nueva"
            calculation.Add(number);
        }

        //Botón Borrar todo
        private void btnC_Click(object sender, EventArgs e)
        {
            tbCalculation.Text = string.Empty;
        }

        //Botón Suma
        private void btnAddition_Click(object sender, EventArgs e)
        {
            _operator = "+";

            if (click == true)
            {
                tbCalculation.Text = number;
                click = false;
                calculation.Add(_operator);
                tbCalculation.Text += _operator;
            }
            else
            {
                calculation.Add(_operator);
                tbCalculation.Text += _operator;
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
        #endregion

        #region Botones de Números
        //Botón Cero
        private void btn0_Click(object sender, EventArgs e)
        {

        }

        //Botón Uno
        private void btn1_Click(object sender, EventArgs e)
        {
            number = "1";
            calculation.Add(number);
            tbCalculation.Text += number;
        }

        //Botón Dos
        private void btn2_Click(object sender, EventArgs e)
        {
            number = "2";
            calculation.Add(number);
            tbCalculation.Text += number;
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
        #endregion
        #endregion
    }
}
