using System;
using System.Diagnostics;

public static class StringExtensions
{
    //Extension method for string//
    public static bool IsPalindrome(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;
        
        string reversed = string.Empty;

        for (int i = value.Length - 1; i >= 0; i--)
        {
            reversed += value[i];
        }

        return value.Equals(reversed, StringComparison.OrdinalIgnoreCase);

    }
}    