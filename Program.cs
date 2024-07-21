namespace TelCo.ColorCoder
{
    public static class TestExecutor
    {
        public static void ExecuteAllTests()
        {
            var tests = new SpecificColorPairMapperTests();
            tests.RunAllTests();
        }
    }
}
