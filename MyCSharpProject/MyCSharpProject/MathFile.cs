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

        public static int GetLCMofNumbers(int[] numbers)
        {
            int lcm = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                lcm = lcm * numbers[i] / GCDofTwoNumbers(lcm, numbers[i]);
            }
            return lcm;
        }

        public static int GetSecondHighestOfAnArray(int[] numbers)
        {
            int highest = numbers[0];
            int secondHighest = numbers[0];
            int num;
            for (int i =0; i < numbers.Length ; i++)
            {
                num = numbers[i];
                if(num > highest)
                {
                    secondHighest = highest;
                    highest = num;
                }
                else if (highest == secondHighest)
                {
                    secondHighest = num;
                }
                else if (num > secondHighest && num != highest)
                {
                    secondHighest = num;
                }
            }
            return secondHighest;
        }
    }
    
}
