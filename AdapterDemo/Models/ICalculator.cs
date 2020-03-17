using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.Models
{
    public interface ICalculator
    {
        int Add(int number1, int number2);
        int Substract(int number1, int number2);
        int Divide(int number1, int number2);
        int Multiply(int number1, int number2);
    }
}
