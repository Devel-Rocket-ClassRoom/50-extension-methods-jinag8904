using System;
using System.Linq;

// 1.
{
    string message = "안녕하세요 반갑습니다";
    Console.WriteLine($"단어 개수: {StringHelper.CountWords(message)}");
}
Console.WriteLine();

// 2.
{
    string message = "안녕하세요 반갑습니다";
    Console.WriteLine($"단어 개수: {message.CountWords2()}");
}
Console.WriteLine();

// 3.
{
    Console.WriteLine($"10(은)는 짝수인가?: {10.IsEven()}");
    Console.WriteLine($"7(은)는 홀수인가?: {7.IsOdd()}");
    Console.WriteLine($"3을 5번 반복: {3.Repeat(5)}");
}
Console.WriteLine();

// 3.
public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(this int number)
    {
        return number % 2 == 1;
    }

    public static string Repeat(this int number, int times)
    {
        return string.Concat(Enumerable.Repeat(number, times));
    }
}

// 2.
public static class StringExtensions
{
    public static int CountWords2(this string text)
    {
        return text.Split(" ").Length;
    }
}

// 1.
public static class StringHelper
{
    public static int CountWords(string text)
    {
        return text.Split(" ").Length;
    }
}