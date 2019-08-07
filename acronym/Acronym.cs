using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] charSeparators = { ' ', ',', '-', '_' };
        var words = phrase.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
        string acronym = new string(words.Select(s => s[0]).ToArray()).ToUpper();
        return acronym;
    }
}