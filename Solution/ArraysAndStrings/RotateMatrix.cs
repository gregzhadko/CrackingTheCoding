using System;

namespace Solution.ArraysAndStrings
{
    public sealed class Image
    {
        private bool Equals(Image other)
        {
            return Equals(Pixels, other.Pixels);
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

            return obj is Image other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Pixels != null ? Pixels.GetHashCode() : 0;
        }

        public Image(int[,] pixels)
        {
            Pixels = pixels;
        }

        public int[,] Pixels { get; }

        public void Rotate()
        {
            var size = Pixels.GetUpperBound(0) + 1;
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
                    var temp = Pixels[size - 1 - shift - i, shift];
                    Pixels[size - 1 - shift - i, shift] = Pixels[size - 1 - shift, size - 1 - shift - i];
                    Pixels[size - 1 - shift, size - 1 - shift - i] = Pixels[shift + i, size - 1 - shift];
                    Pixels[shift + i, size - 1 - shift] = Pixels[shift, shift + i];
                    Pixels[shift, shift + i] = temp;
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