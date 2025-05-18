namespace LeetCodeProblems.Others
{
    // Problem: https://leetcode.com/problems/palindrome-number/
    //Example 1:
    //Input: s = "III"
    //Output: 3
    //Explanation: III = 3.

    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            s = s.ToUpper();
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int current = GetIntValue(s[i]);
                int next = i + 1 < s.Length ? GetIntValue(s[i + 1]) : 0;

                if (current < next)
                {
                    result += next - current;
                    i++; // Skip next
                }
                else
                {
                    result += current;
                }
            }

            return result;
        }

        private static int GetIntValue(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default:
                    throw new ArgumentException($"Invalid Roman numeral character: {c}", nameof(c));
            }
        }
    }
}