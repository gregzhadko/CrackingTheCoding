namespace Solution.ArraysAndStrings
{
    public sealed class OneWay
    {
        public bool IsOneEdit(string original, string resulted)
        {
            if (original.Length == resulted.Length)
            {
                return IsOneSymbolChanged(original, resulted);
            }

            if (resulted.Length - original.Length == 1)
            {
                return IsOneSymbolAdded(original, resulted);
            }

            if (original.Length - resulted.Length == 1)
            {
                return IsOneSymbolAdded(resulted, original);
            }

            return false;
        }

        private static bool IsOneSymbolChanged(string original, string resulted)
        {
            var wasChanged = false;

            for (var i = 0; i < original.Length; i++)
            {
                if (original[i] == resulted[i])
                {
                    continue;
                }

                if (wasChanged)
                {
                    return false;
                }

                wasChanged = true;
            }

            return wasChanged;
        }

        private bool IsOneSymbolAdded(string smaller, string bigger)
        {
            var wasDifferentFound = false;
            
            var j = 0;
            for (var i = 0; i < bigger.Length; i++, j++)
            {
                if (j == smaller.Length)
                {
                    return !wasDifferentFound;
                }
                
                if (smaller[j] == bigger[i])
                {
                    continue;
                }

                if (wasDifferentFound)
                {
                    return false;
                }

                wasDifferentFound = true;
                j--;
            }

            return true;
        }
    }
}