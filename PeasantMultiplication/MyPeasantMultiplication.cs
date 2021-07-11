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
        /// <summary>
        /// Çarpılacak ilk sayıyı tutan property
        /// </summary>
        public int Number1 { get; set; }

        /// <summary>
        /// Çarpılacak ikinci sayıyı tutan property
        /// </summary>
        public int Number2 { get; set; }

        /// <summary>
        /// Çarpım sonucunu Peasant Multiplication algoritmasına göre döndüren property
        /// </summary>
        public int Result { get
            {
               return PeasantMultiplication(Number1, Number2);
            }
        }

        /// <summary>
        /// Peasent Multiplication algoritmasına göre verilen iki sayıyı birbiriyle
        /// çarpan ve sonucu geri döndüren method
        /// </summary>
        /// <param name="number1">Çarpılacak ilk sayı</param>
        /// <param name="number2">Çarpılacak ikinci sayı</param>
        /// <returns></returns>
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
