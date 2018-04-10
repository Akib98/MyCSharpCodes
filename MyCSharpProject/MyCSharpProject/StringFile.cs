using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpProject
{
    public class StringFile
    {
        public static bool isAnagram(String firstString, String secondString)
        {
            bool isAnagram = false;
            if (firstString != null && secondString != null && firstString.Length == secondString.Length)
            {
                string sortedFirst = String.Concat(firstString.OrderBy(c => c));
                string sortedSecond = String.Concat(secondString.OrderBy(c => c));

                if (sortedFirst == sortedSecond)
                {
                    isAnagram = true;
                }
                else
                {
                    isAnagram = false;
                }
            }
            return isAnagram;
        }

        public static string RemoveDuplicateCharacter(string key)
        {
            string result = "";
            string table = "";
            foreach(char value in key)
            {
                if(table.IndexOf(value) == -1)
                {
                    table += value;
                    result += value;
                }
            }
            return result;
        }

        public static int CountingWords(string key)
        {
            int totalString = 0;
            key = key.Trim();
            if (key == "")
                return 0;
            while (key.Contains("  "))
            {
                key = key.Replace("  ", " ");
            }

            foreach (string x in key.Split(' '))
                totalString++;

            return totalString;
        }

        public static bool IsPalindrome(string key)
        {
            int min = 0;
            int max = key.Length - 1;
            while(true)
            {
                if(min> max)
                {
                    return true;
                }
                char a = key[min];
                char b = key[max];
                if (char.ToLower(a) != char.ToLower(b))
                    return false;
                min++;
                max--;
            }
        }
    }
}
