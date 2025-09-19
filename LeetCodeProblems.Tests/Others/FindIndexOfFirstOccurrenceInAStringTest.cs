using System;
using LeetCodeProblems.Others;

namespace LeetCodeProblems.Tests.Others;

public class FindIndexOfFirstOccurrenceInAStringTest
{
    private readonly FindIndexOfFirstOccurrenceInAString _solution = new FindIndexOfFirstOccurrenceInAString();

    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    public void GetLengthOfLastWord_ExampleCases_ReturnsExpectedResult(string input, string find, int expected)
    {
        var result = _solution.FindIndexOfFirstOccurrence(input, find);
        Assert.Equal(expected, result);
    }

    // [Theory]
    // [InlineData(null, 0)]
    // [InlineData("", 0)]
    // [InlineData("   ", 0)]
    // [InlineData("a", 1)]
    // [InlineData(" a ", 1)]
    // public void GetLengthOfLastWord_EdgeCases_ReturnsExpectedResult(string input, int expected)
    // {
    //     // Act
    //     var result = _solution.GetLengthOfLastWord(input);

    //     // Assert
    //     Assert.Equal(expected, result);
    // }
}
