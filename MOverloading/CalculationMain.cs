using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOverloading
{
    internal class CalculationMain
    {
        static void Main(string[] args)
        {
            
            CalculationMOverloading calc = new CalculationMOverloading();

            // Test addition
            Console.WriteLine("Addition:");
            Console.WriteLine(calc.Add(5, 3));           // int addition
            Console.WriteLine(calc.Add(5.5, 3.3));       // double addition

            // Test subtraction
            Console.WriteLine("\nSubtraction:");
            Console.WriteLine(calc.Subtract(10, 3));     // int subtraction
            Console.WriteLine(calc.Subtract(10.5, 3.2)); // double subtraction

            // Test multiplication
            Console.WriteLine("\nMultiplication:");
            Console.WriteLine(calc.Multiply(4, 3));      // int multiplication
            Console.WriteLine(calc.Multiply(4.5, 2.1));  // double multiplication

            // Test division
            Console.WriteLine("\nDivision:");
            Console.WriteLine(calc.Divide(9, 3));        // int division
            Console.WriteLine(calc.Divide(9.9, 3.3));    // double division
            Console.WriteLine(calc.Divide(9, 0));        // division by zero for int
            Console.WriteLine(calc.Divide(9.9, 0.0));    // division by zero for double
        }
    }
}
