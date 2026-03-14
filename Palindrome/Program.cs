using System;
using System.Linq;

Console.WriteLine("=== 회문 판별 테스트 ===");
Console.WriteLine($"\"토마토\" -> {"토마토".IsPalindrome()}");
Console.WriteLine($"\"기러기\" -> {"기러기".IsPalindrome()}");
Console.WriteLine($"\"level\" -> {"level".IsPalindrome()}");
Console.WriteLine($"\"Level\" -> {"Level".IsPalindrome()}");
Console.WriteLine($"\"A man, a plan, a canal: Panama\" -> {"A man, a plan, a canal: Panama".IsPalindrome()}");
Console.WriteLine($"\"race a car\" -> {"race a car".IsPalindrome()}");
Console.WriteLine($"\"hello\" -> {"hello".IsPalindrome()}");
Console.WriteLine($"\"가나다\" -> {"가나다".IsPalindrome()}");
Console.WriteLine($"\"\" -> {"".IsPalindrome()}");

static class PandromeCheck
{
    public static bool IsPalindrome(this string s)
    {
        if (s == null || s == "") return false;

        var cleanChars = s
        .Where(c => char.IsLetterOrDigit(c))
        .Select(c => char.ToUpper(c))
        .ToArray();

        for (int i = 0; i < cleanChars.Length /2; i++)
        {
            if (cleanChars[i] != cleanChars[cleanChars.Length - 1 - i]) return false;
        }

        return true;
    }
}