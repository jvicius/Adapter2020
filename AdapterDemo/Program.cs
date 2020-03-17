using System;
using AdapterDemo.Models;
using Calculator;

namespace AdapterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorAdapter calculator = new CalculatorAdapter();
            Console.WriteLine(calculator.Add(12,35));
            Console.WriteLine(calculator.Substract(80, 40));
            Console.WriteLine(calculator.Multiply(12, 35));
            Console.WriteLine(calculator.Divide(70, 35));
            Console.ReadKey();
        }
    }
}
