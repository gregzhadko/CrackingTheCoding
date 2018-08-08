using System.Collections.Generic;
using System.Linq;

namespace IsUnique
{
    public class Solution
    {
        public static bool SolutionWithDictionary(string input)
        {
            var dict = new Dictionary<char, bool>();

            foreach (var c in input)
            {
                if (dict.ContainsKey(c))
                {
                    return false;
                }
                
                dict.Add(c, true);
            }
            
            return true;
        }

        public static bool SolutionWithoutSdditionalDataStructure(string input)
        {
            var sorted = input.OrderBy(c => c).ToList();
            for (int i = 0; i < sorted.Count - 1; i++)
            {
                if (sorted[i] == sorted[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}