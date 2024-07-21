namespace TelCo.ColorCoder
{
    public static class TestRunner
    {
        public static void Run()
        {
            ColorCoderTests.TestColorPair(4, System.Drawing.Color.White, System.Drawing.Color.Brown);
            ColorCoderTests.TestColorPair(5, System.Drawing.Color.White, System.Drawing.Color.SlateGray);
            ColorCoderTests.TestColorPair(23, System.Drawing.Color.Violet, System.Drawing.Color.Green);
            ColorCoderTests.TestPairNumber(System.Drawing.Color.Yellow, System.Drawing.Color.Green, 18);
            ColorCoderTests.TestPairNumber(System.Drawing.Color.Red, System.Drawing.Color.Blue, 6);
            ColorCoderTests.TestColorPair(1, System.Drawing.Color.White, System.Drawing.Color.Blue);
            ColorCoderTests.TestColorPair(25, System.Drawing.Color.Violet, System.Drawing.Color.SlateGray);
            ColorCoderTests.TestPairNumber(System.Drawing.Color.White, System.Drawing.Color.Blue, 1);
            ColorCoderTests.TestPairNumber(System.Drawing.Color.Violet, System.Drawing.Color.SlateGray, 25);
        }
    }
}
