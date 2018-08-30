using System.Text;

namespace Solution.ArraysAndStrings
{
    public sealed class StringCompression
    {
        public string Compress(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            var formatted = input.ToLowerInvariant();

            var stringBuilder = new StringBuilder();

            var currentElement = formatted[0];
            stringBuilder.Append(currentElement);
            var count = 1;
            bool encrypted = false;
            for (int i = 1; i < formatted.Length; i++)
            {
                if (formatted[i] != currentElement)
                {
                    stringBuilder.Append(count);
                    currentElement = formatted[i];
                    stringBuilder.Append(currentElement);
                    count = 1;
                }
                else
                {
                    count++;
                    encrypted = true;
                }
            }

            stringBuilder.Append(count);

            return encrypted ? stringBuilder.ToString() : formatted;
        }
    }
}