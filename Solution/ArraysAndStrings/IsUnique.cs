using System.Collections.Generic;
using System.Linq;

namespace Solution.ArraysAndStrings
{
    public static class IsUnique
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

        public static bool SolutionWithoutAdditionalDataStructure(string input)
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