using LeetCodeProblems.Others;

namespace LeetCodeProblems.Tests.Others
{
    public class PalindromeNumberTest
    {

        [Fact]
        public void Validate_IsPalindomer_Example1()
        {
            var solution = new PalindromeNumber();
            var input = 121;
            var expected = true;

            var result = solution.IsPalindrome(input);

            Assert.Equal(expected, result);
        }

        public void Validate_IsPalindomer_Example2()
        {
            var solution = new PalindromeNumber();
            var input = -121;
            var expected = false;

            var result = solution.IsPalindrome(input);

            Assert.Equal(expected, result);
        }

        public void Validate_IsPalindomer_Exampl32()
        {
            var solution = new PalindromeNumber();
            var input = 10;
            var expected = false;

            var result = solution.IsPalindrome(input);

            Assert.Equal(expected, result);
        }

    }
}
