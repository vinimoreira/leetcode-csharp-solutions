using System.Text;

namespace LeetCodeProblems.Others;

public class LongestCommomPrefix
{
    // Problem: https://leetcode.com/problems/longest-common-prefix/
    // Example 1:
    // Input: x = { "flower", "flow", "flight" };
    // Output: fl
    public string LongestCommonPrefix(string[] strs)
    {

        if (strs == null || strs.Length == 0)
            return string.Empty;

        if (strs.Length == 1)
            return strs[0];

        var longestCommomPrefix = new StringBuilder();
        for (int i = 0; i < strs[0].Length; i++)
        {
            char currentChar = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                //If we reached the end of word or chard doesn't match
                if (i >= strs[j].Length || strs[j][i] != currentChar)
                    return longestCommomPrefix.ToString();
            }

            longestCommomPrefix.Append(currentChar);
        }

        return longestCommomPrefix.ToString();
    }
}
