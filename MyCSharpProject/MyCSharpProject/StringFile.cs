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
    }
}
