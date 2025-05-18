using LeetCodeProblems.Others;

namespace LeetCodeProblems.Tests.Others
{
    public class RomanToIntegerTest
    {

        [Fact]
        public void RomanToInt_InputIII_Returns3()
        {
            var solution = new RomanToInteger();
            var input = "III";
            var expected = 3;

            var result = solution.RomanToInt(input);

            Assert.Equal(expected, result);
        }

        public void RomanToInt_InputLVIII_Returns58()
        {
            var solution = new RomanToInteger();
            var input = "LVIII";
            var expected = 58;

            var result = solution.RomanToInt(input);

            Assert.Equal(expected, result);
        }

        public void RomanToInt_InputMCMXCIV_Returns1994()
        {
            var solution = new RomanToInteger();
            var input = "MCMXCIV";
            var expected = 1994;

            var result = solution.RomanToInt(input);

            Assert.Equal(expected, result);
        }

    }
}
