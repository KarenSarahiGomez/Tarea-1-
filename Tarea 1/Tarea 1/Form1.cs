using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Tarea_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(NumerotextBox.Text);
            bool resultado = numeroParImpar(numero);

            if (resultado == true)
            {
                resultadolabel.Text = "Su número es par";
            }
            else if (resultado == false)
            { 
                resultadolabel.Text = "Su número es impar";
            }
            if (resultado == true) 
            {
                PosNeglabel.Text = "Positivo";
            }
            else if (resultado == false)
            {
                PosNeglabel.Text = "Negativo";
            }
        }
        bool numeroParImpar(int valor)  
        {
            if (valor % 2 == 0)
            {
                return true;
            }
            return false;
        }
        private string PosNeg(decimal num1)
        {
            string resultadoPosNeg = "";
            decimal numeroPosNeg = Convert.ToDecimal(PosNeglabel.Text);

            if (numeroPosNeg > 1)
                resultadoPosNeg = "Positivo";

            else if (numeroPosNeg != 0)
                resultadoPosNeg = "Negativo";

            return resultadoPosNeg;
        }
    }
}

    

