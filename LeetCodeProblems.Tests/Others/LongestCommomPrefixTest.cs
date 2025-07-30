using LeetCodeProblems.Others;

namespace LeetCodeProblems.Tests.Others
{
    public class LongestCommomPrefixTest
    {

        [Fact]
        public void Return_LongestCommonPrefix_Example1()
        {
            var solution = new LongestCommomPrefix();
            var input = new string[] { "flower", "flow", "flight" };
            var expected = "fl";

            var result = solution.LongestCommonPrefix(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Return_LongestCommonPrefix_Example2()
        {
            var solution = new LongestCommomPrefix();
            var input = new string[] { "dog", "racecar", "car" };
            var expected = string.Empty;

            var result = solution.LongestCommonPrefix(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Return_LongestCommonPrefix_Example3()
        {
            var solution = new LongestCommomPrefix();
            var input = new string[] { "ab", "a"};
            var expected = "a";

            var result = solution.LongestCommonPrefix(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Return_EmptyString_WhenOneStringIsEmpty()
        {
            var solution = new LongestCommomPrefix();
            var input = new string[] { "hello", "", "help" };
            var expected = string.Empty;

            var result = solution.LongestCommonPrefix(input);

            Assert.Equal(expected, result);
        }

    }
}
