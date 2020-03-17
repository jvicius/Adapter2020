using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace AdapterDemo.Models
{
    public class CalculatorAdapter : ICalculator
    {
        private BinaryCalculator _binaryCalculator;

        public CalculatorAdapter()
        {
            _binaryCalculator = new BinaryCalculator();
        }

        public int Add(int number1, int number2)
        {
            return _binaryCalculator.Add(number1.ToBinary(), number2.ToBinary()).ToInt();
        }

        public int Substract(int number1, int number2)
        {
            string n1 = Convert.ToString(number1, 2);
            string n2 = Convert.ToString(number2, 2);
            string res = _binaryCalculator.Subtract(n1, n2);
            return Convert.ToInt32(res, 2);
        }

        public int Divide(int number1, int number2)
        {
            string n1 = Convert.ToString(number1, 2);
            string n2 = Convert.ToString(number2, 2);
            string res = _binaryCalculator.Divide(n1, n2);
            return Convert.ToInt32(res, 2);
        }

        public int Multiply(int number1, int number2)
        {
            string n1 = Convert.ToString(number1, 2);
            string n2 = Convert.ToString(number2, 2);
            string res = _binaryCalculator.Multiply(n1, n2);
            return Convert.ToInt32(res, 2);
        }
    }
}
