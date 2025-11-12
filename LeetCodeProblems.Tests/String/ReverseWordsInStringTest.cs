using LeetCodeProblems.Others;
using LeetCodeProblems.String;

namespace LeetCodeProblems.Tests.String;

public class ReverseWordsInStringTest
{
    private readonly ReverseWordsInString _solution = new ReverseWordsInString();

    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void ReverseWordsInString_ExampleCases_ReturnsExpectedResult(string input, string expected)
    {
        var result = _solution.ReverseWords(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(null, "")]
    [InlineData("", "")]
    [InlineData("     ", "")]
    [InlineData("a   b", "b a")]
    [InlineData("hello, world!", "world! hello,")]
    public void ReverseWordsInString_EdgesCases_ReturnsExpectedResult(string input, string expected)
    {
        var result = _solution.ReverseWords(input);
        Assert.Equal(expected, result);
    }
}
