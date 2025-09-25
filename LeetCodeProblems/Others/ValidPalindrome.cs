using System.Text.RegularExpressions;

namespace LeetCodeProblems.Others;

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        s = Regex.Replace(s, @"[^a-zA-Z0-9]", "");

        if (string.IsNullOrEmpty(s))
            return true;

        s = s.ToLower();
        int i = 0;
        for (int j = s.Length - 1; j >= 0; j--)
        {
            if (s[i] != s[j])
                return false;

            i++;
        }

        return true;
    }

    //Best performance
    public bool IsPalindromeBestPerformance(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;

            while (left < right && !char.IsLetterOrDigit(s[right]))
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
