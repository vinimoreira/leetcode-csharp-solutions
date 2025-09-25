using LeetCodeProblems.Others;

namespace LeetCodeProblems.Tests.Others;

public class FindIndexOfFirstOccurrenceInAStringTest
{
    private readonly FindIndexOfFirstOccurrenceInAString _solution = new FindIndexOfFirstOccurrenceInAString();

    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    public void FindIndexOfFirstOccurrenceInAString_ExampleCases_ReturnsExpectedResult(string input, string find, int expected)
    {
        var result = _solution.FindIndexOfFirstOccurrence(input, find);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(null, "a", -1)]
    [InlineData("a", null, -1)]
    [InlineData("", "", -1)]
    [InlineData("abc", "", -1)]
    [InlineData("", "a", -1)]
    [InlineData("a", "aa", -1)]
    [InlineData("aaaaa", "bba", -1)]
    [InlineData("mississippi", "issi", 1)]
    [InlineData("aaa", "aa", 0)]
    [InlineData("ababa", "aba", 0)]
    [InlineData("needle", "needle", 0)]
    [InlineData("endswith", "with", 4)]
    [InlineData("CaseSensitive", "casesensitive", -1)]
    public void FindIndexOfFirstOccurrenceInAString_EdgeCases_ReturnsExpectedResult(string input, string find, int expected)
    {
        // Act
        var result = _solution.FindIndexOfFirstOccurrence(input, find);

        // Assert
        Assert.Equal(expected, result);
    }
}
