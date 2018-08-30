using System;
using System.Collections.Generic;

namespace Solution.ArraysAndStrings
{
    public class PalindromePermutation
    {
        public static bool IsPalindromePermutation(string input)
        {
            var dict = new Dictionary<char, int>();

            var realSize = 0;
            
            for (var i = 0; i < input.Length; i++)
            {
                var c = Char.ToLower(input[i]);

                if (c == ' ')
                {
                    continue;
                }

                realSize++;
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }
            }

            var odd = realSize % 2 == 1;

            var usedMiddle = false;
            foreach (var key in dict.Keys)
            {
                if (dict[key] % 2 != 1)
                {
                    continue;
                }

                if (!odd)
                {
                    return false;
                }

                if (usedMiddle)
                {
                    return false;
                }

                usedMiddle = true;
            }
            
            return true;
        }
    }
}