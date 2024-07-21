namespace TelCo.ColorCoder
{
    public class SpecificColorPairMapperTests : ColorPairMapperTests
    {
        private readonly ColorPairMapperBase _mapper;

        public SpecificColorPairMapperTests()
        {
            _mapper = new ColorPairMapper();
        }

        public void RunAllTests()
        {
            VerifyColorPair(_mapper, 1, System.Drawing.Color.White, System.Drawing.Color.Blue);
            VerifyColorPair(_mapper, 5, System.Drawing.Color.White, System.Drawing.Color.SlateGray);
            VerifyColorPair(_mapper, 23, System.Drawing.Color.Violet, System.Drawing.Color.Green);
            VerifyPairNumber(_mapper, System.Drawing.Color.Yellow, System.Drawing.Color.Green, 18);
            VerifyPairNumber(_mapper, System.Drawing.Color.Red, System.Drawing.Color.Blue, 6);
            VerifyColorPair(_mapper, 4, System.Drawing.Color.White, System.Drawing.Color.Brown);
            VerifyColorPair(_mapper, 25, System.Drawing.Color.Violet, System.Drawing.Color.SlateGray);
            VerifyPairNumber(_mapper, System.Drawing.Color.White, System.Drawing.Color.Blue, 1);
            VerifyPairNumber(_mapper, System.Drawing.Color.Violet, System.Drawing.Color.SlateGray, 25);
        }
    }
}
