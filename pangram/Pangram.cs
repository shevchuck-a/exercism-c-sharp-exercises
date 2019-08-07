using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string onlyLetters = Regex.Replace(input, "[^a-zA-Z]", "");
        string noDuplicates = new String(onlyLetters.ToLower().Distinct().ToArray());
        if (noDuplicates.Length == 26)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
