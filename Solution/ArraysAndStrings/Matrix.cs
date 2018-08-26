using System;

namespace Solution.ArraysAndStrings
{
    public sealed class Matrix
    {
        private bool Equals(Matrix other)
        {
            return Equals(Elements, other.Elements);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj is Matrix other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Elements != null ? Elements.GetHashCode() : 0;
        }

        public Matrix(int[,] elements)
        {
            Elements = elements;
        }

        public int[,] Elements { get; }

        public void Rotate()
        {
            var size = Elements.GetUpperBound(0) + 1;
            if (size == 1)
            {
                return;
            }

            int maxShift = Math.Abs(size / 2);
            var shift = 0;
            do
            {
                for (int i = shift; i < size - 1 - shift; i++)
                {
                    var temp = Elements[size - 1 - shift - i, shift];
                    Elements[size - 1 - shift - i, shift] = Elements[size - 1 - shift, size - 1 - shift - i];
                    Elements[size - 1 - shift, size - 1 - shift - i] = Elements[shift + i, size - 1 - shift];
                    Elements[shift + i, size - 1 - shift] = Elements[shift, shift + i];
                    Elements[shift, shift + i] = temp;
                }

                shift++;
                if (shift >= maxShift)
                {
                    return;
                }
            } while (true);
        }
    }
}