using System;
using System.Collections.Generic;

// 1.
{
    Console.WriteLine($"'hello' 대문자로 시작? {"hello".IsCapitalized()}");
    Console.WriteLine($"첫 글자 대문자: {"hello".Capitalize()}");
    Console.WriteLine($"뒤집기: {"hello".Reverse()}");
}
Console.WriteLine();

// 2.
{
    Console.WriteLine("안녕하세요 반갑습니다 좋은 하루 되세요".Take(10).AddEllipsis().AddPrefix("[메시지] ").AddSuffix(" (더보기)"));
}
Console.WriteLine();

// 3.
{
    string[] names = { "철수", "영희", "민수" };
    List<int> emptyList = new List<int> {};

    Console.WriteLine($"names 비어있음? {names.IsEmpty()}");
    Console.WriteLine($"emptyList 비어있음? {emptyList.IsEmpty()}");
    Console.WriteLine($"names에 요소 있음? {names.HasItems()}");

    Console.WriteLine("\n이름 목록: ");
    names.ForEach(x => Console.WriteLine($" - {x}"));
}
Console.WriteLine();

// 3.
static class CollectionExtensions
{
    public static bool IsEmpty<T>(this ICollection<T> collection)
    {
        return collection.Count == 0 || collection == null;
    }

    public static bool HasItems<T>(this ICollection<T> collection)
    {
        return collection.Count > 0;
    }

    public static void ForEach<T>(this IList<T> list, Action<T> action)
    {
        foreach (T factor in list)
        {
            action(factor);
        }
    }
}

// 2.
static class StringChainExtensions
{
    public static string AddPrefix(this string text, string prefix)
    {
        return prefix + text;
    }

    public static string AddSuffix(this string text, string suffix)
    {
        return text + suffix;
    }

    public static string Take(this string text, int count)
    {
        return text.Substring(0, count);
    }

    public static string AddEllipsis(this string text)
    {
        return text + "...";
    }
}

// 1.
static class StringExtensions
{
    public static bool IsCapitalized(this string text)
    {
        return char.IsUpper(text[0]);
    }

    public static string Capitalize(this string text)
    {
        return char.ToUpper(text[0]) + text.Substring(1);
    }

    public static string Reverse(this string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}