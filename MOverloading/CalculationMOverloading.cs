using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOverloading
{
    internal class CalculationMOverloading
    {
        // Addition overloads
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtraction overloads
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplication overloads
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Division overloads
        public int Divide(int a, int b)
        {
            // Handle division by zero for integers
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return 0;
                //throw new DivideByZeroException("Error: Division by zero is not allowed for integers.");

            }
            return a / b;
        }

        public double Divide(double a, double b)
        {
            // Handle division by zero for doubles
            if (b == 0.0)
            {
                Console.WriteLine("Error: Division by zero.");
                return 0.0;
                //throw new DivideByZeroException("Error: Division by zero is not allowed for doubles.");

            }
            return a / b;
        }
    }
}
