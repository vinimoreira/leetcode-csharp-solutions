using System;

namespace LeetCodeProblems.Others;

public class LengthOfLastWord
{
    public int GetLengthOfLastWord(string phrase)
    {
        if (string.IsNullOrWhiteSpace(phrase))
            return 0;

        phrase = phrase.TrimEnd();

        var arrayWords = phrase.Split(' ');

        if (arrayWords.Length == 0)
            return 0;

        var indexLastString = arrayWords.Length - 1;

        return arrayWords[indexLastString].Length;
    }  
}
