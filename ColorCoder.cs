using System;

namespace TelCo.ColorCoder
{
    public static class ColorCoder
    {
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = ColorMap.MinorColors.Length;
            if (pairNumber < 1 || pairNumber > minorSize * ColorMap.MajorColors.Length)
                throw new ArgumentOutOfRangeException($"PairNumber:{pairNumber} is outside the allowed range");

            int majorIndex = (pairNumber - 1) / minorSize;
            int minorIndex = (pairNumber - 1) % minorSize;
            return new ColorPair { MajorColor = ColorMap.MajorColors[majorIndex], MinorColor = ColorMap.MinorColors[minorIndex] };
        }

        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = ColorMap.GetIndexOfColor(pair.MajorColor, ColorMap.MajorColors);
            int minorIndex = ColorMap.GetIndexOfColor(pair.MinorColor, ColorMap.MinorColors);
            if (majorIndex == -1 || minorIndex == -1)
                throw new ArgumentException($"Unknown Colors: {pair}");

            return (majorIndex * ColorMap.MinorColors.Length) + (minorIndex + 1);
        }
    }
}

