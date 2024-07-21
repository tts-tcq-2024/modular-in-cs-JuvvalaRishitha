namespace TelCo.ColorCoder
{
    public class ColorPairMapper : BaseColorPairMapper
    {
        public override ColorPair GetColorPairFromNumber(int pairNumber)
        {
            ValidatePairNumber(pairNumber);
            int minorIndex = (pairNumber - 1) % ColorMapping.MinorColors.Length;
            int majorIndex = (pairNumber - 1) / ColorMapping.MinorColors.Length;
            return new ColorPair 
            { 
                MajorColor = ColorMapping.MajorColors[majorIndex], 
                MinorColor = ColorMapping.MinorColors[minorIndex] 
            };
        }

        public override int GetNumberFromColorPair(ColorPair pair)
        {
            int majorIndex = ColorMapping.GetColorIndex(pair.MajorColor, ColorMapping.MajorColors);
            int minorIndex = ColorMapping.GetColorIndex(pair.MinorColor, ColorMapping.MinorColors);
            return (majorIndex * ColorMapping.MinorColors.Length) + (minorIndex + 1);
        }
    }
}
