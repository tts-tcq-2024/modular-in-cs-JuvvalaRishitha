using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class ColorCoderTests
    {
        public static void TestColorPair(int pairNumber, Color expectedMajor, Color expectedMinor)
        {
            ColorPair testPair = ColorCoder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0}, [Out] Colors: {1}\n", pairNumber, testPair);
            Debug.Assert(testPair.MajorColor == expectedMajor);
            Debug.Assert(testPair.MinorColor == expectedMinor);
        }

        public static void TestPairNumber(Color majorColor, Color minorColor, int expectedPairNumber)
        {
            ColorPair testPair = new ColorPair { MajorColor = majorColor, MinorColor = minorColor };
            int pairNumber = ColorCoder.GetPairNumberFromColor(testPair);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair, pairNumber);
            Debug.Assert(pairNumber == expectedPairNumber);
        }
    }
}
