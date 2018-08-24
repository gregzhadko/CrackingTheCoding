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
            var width = Pixels.GetUpperBound(0) + 1;
            if (width == 1)
            {
                return;
            }

            int maxShift = Math.Abs(width / 2);
            var shift = 0;
            do
            {
                for (int i = shift; i < width - 1 - shift; i++)
                {
                    var temp = Pixels[width - shift - i - 1, shift];
                    Pixels[width - shift - i - 1, shift] = Pixels[width - shift - i - 1, width - shift - 1];
                    Pixels[width - shift - i - 1, width - shift - 1] = Pixels[shift + i, width - shift - 1];
                    Pixels[shift, width - shift - i - 1] = Pixels[shift, shift + i];
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