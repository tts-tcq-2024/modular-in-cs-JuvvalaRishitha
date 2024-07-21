using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public abstract class ColorPairMapperTests
    {
        protected void VerifyColorPair(ColorPairMapperBase mapper, int pairNumber, Color expectedMajor, Color expectedMinor)
        {
            ColorPair testPair = mapper.GetColorPairFromNumber(pairNumber);
            Console.WriteLine($"[In] Pair Number: {pairNumber}, [Out] Colors: {testPair}");
            Debug.Assert(testPair.MajorColor == expectedMajor);
            Debug.Assert(testPair.MinorColor == expectedMinor);
        }

        protected void VerifyPairNumber(ColorPairMapperBase mapper, Color majorColor, Color minorColor, int expectedPairNumber)
        {
            ColorPair testPair = new ColorPair { MajorColor = majorColor, MinorColor = minorColor };
            int pairNumber = mapper.GetNumberFromColorPair(testPair);
            Console.WriteLine($"[In] Colors: {testPair}, [Out] PairNumber: {pairNumber}");
            Debug.Assert(pairNumber == expectedPairNumber);
        }
    }
}
