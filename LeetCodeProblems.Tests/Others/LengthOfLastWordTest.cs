using System;
using LeetCodeProblems.Others;

namespace LeetCodeProblems.Tests.Others;

public class LengthOfLastWordTest
{
    private readonly LengthOfLastWord _solution = new LengthOfLastWord();

    [Theory]
    [InlineData("World", 5)]
    [InlineData("luffy is still joyboy", 6)]
    [InlineData("   fly me   to   the moon  ", 4)]
    public void GetLengthOfLastWord_ExampleCases_ReturnsExpectedResult(string input, int expected)
    {
        var result = _solution.GetLengthOfLastWord(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("   ", 0)]
    [InlineData("a", 1)]
    [InlineData(" a ", 1)]
    public void GetLengthOfLastWord_EdgeCases_ReturnsExpectedResult(string input, int expected)
    {
        // Act
        var result = _solution.GetLengthOfLastWord(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
