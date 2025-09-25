using System.Text;

namespace LeetCodeProblems.Others;

public class FindIndexOfFirstOccurrenceInAString
{
    // Problem: https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string
    // Example 1:
    // Input: haystack = "sadbutsad", needle = "sad"
    // Output: 0
    // I oppted to not use the String IndexOf
    public int FindIndexOfFirstOccurrence(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle))
            return -1;

        if(needle.Length > haystack.Length)
            return -1;

        for (int i = 0; i <= haystack.Length; i++)
        {
            //Prevent ArgumentOutOfRangeException
            if (haystack.Length - i < needle.Length)
                return -1;

            var subString = haystack.Substring(i, needle.Length);
            if (string.IsNullOrEmpty(subString) || subString != needle)
                continue;

            return i;
        }

        return -1;
    }
}
