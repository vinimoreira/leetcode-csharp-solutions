namespace LeetCodeProblems.String;

public class ReverseWordsInString
{
    // Problem: https://leetcode.com/problems/reverse-words-in-a-string 
    // Example 1:
    // Input: Input: s = "the sky is blue"
    //Output: "blue is sky the"
    public string ReverseWords(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return string.Empty;

        var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
    
}
