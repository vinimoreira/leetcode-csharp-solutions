namespace LeetCodeProblems.Others
{
    // Problem: https://leetcode.com/problems/valid-parentheses/
    // Example 2:
    // Input: s = "([{}])"
    //Output: true

    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Peek();

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
