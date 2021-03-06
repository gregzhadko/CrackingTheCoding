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

            var width = Elements.Length / size;
            if (width != size)
            {
                return;
            }

            var maxShift = Math.Abs(size / 2);
            var shift = 0;
            do
            {
                for (var i = shift; i < size - 1 - shift; i++)
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

        public void Zero()
        {
            var width = Elements.GetUpperBound(0) + 1;
            var height = Elements.Length / width;

            var widthZeroIndexes = new bool[width];
            var heightZeroIndexes = new bool[height];

            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    if (Elements[i, j] == 0)
                    {
                        widthZeroIndexes[i] = true;
                        heightZeroIndexes[j] = true;
                    }
                }
            }

            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    var isZero = widthZeroIndexes[i] || heightZeroIndexes[j];
                    Elements[i, j] = isZero ? 0 : Elements[i, j];
                }
            }
        }
    }
}