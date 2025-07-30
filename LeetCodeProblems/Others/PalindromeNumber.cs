namespace LeetCodeProblems.Others
{
    // Problem: https://leetcode.com/problems/palindrome-number/
    // Example 1:
    // Input: x = 121
    // Output: true
    // Explanation: 121 reads as 121 from left to right and from right to left.

    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            string numberString = x.ToString();

            int j = numberString.Length - 1;
            for (int i = 0; i < numberString.Length; i++)
            {
                if (numberString[i] != numberString[j])
                    return false;

                j--;
            }

            return true;
        }
    }
}