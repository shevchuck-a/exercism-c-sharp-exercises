using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string editedWord= new String(word.ToLower().Distinct().ToArray());
        if (editedWord.Count(char.IsLetter) == word.Count(char.IsLetter))
        {
            return true;
        }
        return false;
    }
}
