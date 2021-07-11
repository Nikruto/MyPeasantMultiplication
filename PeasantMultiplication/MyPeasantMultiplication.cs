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
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get
            {
               return PeasantMultiplication(Number1, Number2);
            }
        }

        private int PeasantMultiplication(int number1, int number2)
        {
            int res = 0;
            while (number1 > 0)
            {
                if(number1 % 2 == 1)
                {
                    res += number2;
                }

                number1 /= 2;
                number2 *= 2;
            }
            return res;
        }
    }
}
