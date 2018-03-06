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
            #region Anagram Check
            
            Console.WriteLine("Check two Strings are anagram or not!!");
            Console.WriteLine("Enter first String: ");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            string secondString = Console.ReadLine();

            bool IsAnagram = StringFile.isAnagram(firstString, secondString);

            if(IsAnagram)
                Console.WriteLine("Two strings are Anagram");
            else
                Console.WriteLine("Two strings are not Anagram!");

            #endregion
            Console.ReadKey();
        }
        
    }
}
