using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceContract
{
    public class MyCalculator : ICalculator
    {
        double sum = 0;

        public double Add(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("Add of {0} and {1} is {2}", n1, n2, result);
            return result;
        }

        public double Subt(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("Subt of {0} and {1} is {2}", n1, n2, result);
            return result;
        }

        public double Multiply(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("Multiply of {0} and {1} is {2}", n1, n2, result);
            return n1 * n2;
        }

        public double Sum(double n1)
        {
            double result = sum + n1;
            Console.WriteLine("Sum of {0} is {1}", n1, result);
            return result;
        }
    }
}
