using System;
using LeetCodeProblems.Others;

namespace LeetCodeProblems.Tests.Others;

public class ValidPalindromeTest
{
    private readonly ValidPalindrome _solution = new ValidPalindrome();

    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    public void ValidatePalindrome_ExampleCases_ReturnsExpectedResult(string input, bool expected)
    {
        var result = _solution.IsPalindrome(input);
        Assert.Equal(result, expected);
    }
}
