using System;

namespace TelCo.ColorCoder
{
    public abstract class ColorPairMapperBase
    {
        public abstract ColorPair MapNumberToColorPair(int pairNumber);
        public abstract int MapColorPairToNumber(ColorPair pair);

        protected void EnsureValidPairNumber(int pairNumber)
        {
            int maxPairNumber = ColorMapping.MajorColors.Length * ColorMapping.MinorColors.Length;
            if (pairNumber < 1 || pairNumber > maxPairNumber)
            {
                throw new ArgumentOutOfRangeException($"PairNumber: {pairNumber} is outside the allowed range of 1 to {maxPairNumber}");
            }
        }
    }
}
