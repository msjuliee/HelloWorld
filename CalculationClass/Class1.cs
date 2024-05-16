using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationClass
{
    public class Calculation
    {
        public string calculate(float a, float b)
        {
            string plus = (a + b).ToString();
            string minus = (a - b).ToString();
            string multiply = (a * b).ToString();
            string divide = (Math.Round((a / b), 2)).ToString();

            return "Result: \n Plus = " + plus + "\n Minus = " + minus + "\n Multiply = " + multiply + "\n Divide = " + divide;
        }
    }
}
