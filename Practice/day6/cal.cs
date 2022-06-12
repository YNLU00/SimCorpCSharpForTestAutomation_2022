using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    public class Cal
    {
        const int numberOfDecimals = 2;
        public double Add(double input1, double input2)
        {
            return Math.Round(input1 + input2, numberOfDecimals);
        }
        public static double Substract(double input1, double input2)
        {
            return Math.Round(input1 - input2, numberOfDecimals);
        }
    }
}
