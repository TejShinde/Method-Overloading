using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOverloading
{
    internal class Addition
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b;
        }
        public double Add(int a, double b)
        {
            return a + b;
        }

        public double Add(double b, int a)
        {
            return a + b;
        }
    }
}
