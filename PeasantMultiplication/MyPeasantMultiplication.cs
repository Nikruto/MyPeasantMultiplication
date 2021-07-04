using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeasantMultiplication
{
    public class MyPeasantMultiplication : Component
    {
        private int PeasantMultiplication(int number1, int number2)
        {
            int result = 0;
            while (number1 > 0)
            {
                if(number1 % 2 == 1)
                {
                    result += number2;
                }

                number1 /= 2;
                number2 *= 2;
            }
            //
            return result;
        }

        public int Calculate(int number1, int number2)
        {
            return PeasantMultiplication(number1, number2);
        }
    }
}
