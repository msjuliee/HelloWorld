using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationClass;
using RandomClass;


namespace DeploymentPorfolio1Distinction
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if ((num1.Text == "") || (num2.Text == ""))
            {
                MessageBox.Show("Please enter numbers.");
            }
            else
            {
                float number1 = float.Parse(num1.Text);
                float number2 = float.Parse(num2.Text);
                Calculation result = new Calculation();
                string msg = result.calculate(number1, number2);
                MessageBox.Show(msg);
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            RandomNumber rand = new RandomNumber();

            num1.Text = rand.randomNumber().ToString();
            num2.Text = rand.randomNumber().ToString();
            
        }
    }
}
