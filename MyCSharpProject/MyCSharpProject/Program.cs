using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject
{
    class Program
    {
        static void Main()
        {
            #region GCD of five numbers
            Console.WriteLine("Input five numbers and get the GCD: ");
            int[] newArray = new int[5];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int result = MathFile.GetGCDofNumbers(newArray);

            Console.Write("The GCD of these numbers is: ");
            Console.WriteLine(result);
            #endregion

            #region Anagram Check

            //Console.WriteLine("Check two Strings are anagram or not!!");
            //Console.WriteLine("Enter first String: ");
            //string firstString = Console.ReadLine();
            //Console.WriteLine("Enter second string: ");
            //string secondString = Console.ReadLine();

            //bool IsAnagram = StringFile.isAnagram(firstString, secondString);

            //if(IsAnagram)
            //    Console.WriteLine("Two strings are Anagram");
            //else
            //    Console.WriteLine("Two strings are not Anagram!");

            #endregion

            Console.ReadKey();
        }   
    }
}
