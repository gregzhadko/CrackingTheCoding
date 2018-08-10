using System.Collections.Generic;

namespace Solution.ArraysAndStrings
{
    public static class CheckPermutation
    {
        public static bool IsPermutation(string original, string permutation)
        {
            if (original.Length != permutation.Length)
            {
                return false;
            }
            
            var dictionary = new Dictionary<char, int>();
            foreach (var key in original)
            {
                if (!dictionary.ContainsKey(key))
                {
                    dictionary.Add(key, 1);
                }
                else
                {
                    dictionary[key]++;
                }
            }

            foreach (var key in permutation)
            {
                if (!dictionary.ContainsKey(key))
                {
                    return false;
                }

                dictionary[key]--;

                if (dictionary[key] < 0)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}