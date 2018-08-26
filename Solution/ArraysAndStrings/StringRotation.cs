using System;

namespace Solution.ArraysAndStrings
{
    public class StringRotation
    {
        public bool IsRotation(string original, string rotation)
        {
            return IsSubString(original + original, rotation);
        }

        private bool IsSubString(string original, string substring)
        {
            return original.IndexOf(substring, StringComparison.Ordinal) >= 0;
        }
    }
}