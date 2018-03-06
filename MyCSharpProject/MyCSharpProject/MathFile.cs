using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject
{
    public class MathFile
    {
        public static int GetGCDofNumbers(int[] numbers)
        {
            int gcd = 1;
            int index = 2;
            if(numbers.Length == 1)
            {
                gcd = numbers[1];
            }

            if(numbers.Length > 1)
            {
                gcd = GCDofTwoNumbers(numbers[1], numbers[2]);
            }

            while(index < numbers.Length)
            {
                gcd = GCDofTwoNumbers(gcd, numbers[index]);
                index++;
            }

            return gcd;
        }

        private static int GCDofTwoNumbers(int number1, int number2)
        {
            if (number2 != 0)
                return GCDofTwoNumbers(number2, number1 % number2);
            else
                return number1;
        }
    }
    
}
