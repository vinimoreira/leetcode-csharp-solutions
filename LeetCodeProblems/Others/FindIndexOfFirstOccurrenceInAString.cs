using System.Text;

namespace LeetCodeProblems.Others;

public class FindIndexOfFirstOccurrenceInAString
{
    // Problem: https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string
    // Example 1:
    // Input: haystack = "sadbutsad", needle = "sad"
    // Output: 0
    public int FindIndexOfFirstOccurrence(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle))
            return -1;

        for (int i = 0; i <= haystack.Length; i++)
        {
            var subString = haystack.Substring(i, needle.Length);
            if (string.IsNullOrEmpty(subString) || subString != needle)
                continue;

            return i;
        }

        return -1;
    }
}
