using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2= 0;
        string Operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            txtResult.Text = "";
            Operacao = "SUBTRACAO";
            lblResult.Text = "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            txtResult.Text = "";
            Operacao = "SOMA";
            lblResult.Text = "+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

      
        private void button13_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);

            switch (Operacao)
            {
                case "SOMA":

                    txtResult.Text = Convert.ToString(valor1 + valor2);

                    Operacao = "";

                break;
            }
            switch (Operacao)
            {
                case "SUBTRACAO":

                    txtResult.Text = Convert.ToString(valor1 - valor2);

                    Operacao = "";
                    break;
            }
            switch (Operacao)
            {
                case "MULTIPLICACAO":

                    txtResult.Text = Convert.ToString(valor1 * valor2);

                    Operacao = "";
                    break;
            }
            switch (Operacao)
            {
                case "DIVISAO":
                    if (valor1 != 0 ) {

                        txtResult.Text = Convert.ToString(valor1 / valor2);

                        Operacao = "";
                    }
                    else
                    {
                        MessageBox.Show("Não existe divisão por Zero!");
                        txtResult.Text = "";
                    }
                    break;
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            Operacao = "DIVISAO";
            txtResult.Text = "";
            lblResult.Text = "/";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblResult.Text = "";
        }

        private void buttonVezes_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            Operacao = "MULTIPLICACAO";
            txtResult.Text = "";
            lblResult.Text = "*";
        }
    }
}
