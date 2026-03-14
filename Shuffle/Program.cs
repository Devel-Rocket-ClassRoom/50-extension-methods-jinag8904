using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("=== 컬렉션 셔플 테스트 ===");

Console.WriteLine("\n[숫자 리스트 셔플]");
List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine($"원본: {string.Join(", ", ints)}");
ints.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", ints)}");

Console.WriteLine("\n[카드 덱 셔플]");
List<string> strings = new List<string> { "♠A", "♥K", "♦Q", "♣J" };
Console.WriteLine($"원본: {string.Join(", ", strings)}");
strings.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", strings)}");

Console.WriteLine("\n[학생 순서 무작위 배치]");
List<string> strings2 = new List<string> { "김철수", "이영희", "박민수", "최지연", "정우진" };
Console.WriteLine($"원본: {string.Join(", ", strings2)}");
strings2.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", strings2)}");

static class ShuffleClass
{
    public static void Shuffle<T>(this IList<T> list)
    {
        if (list == null) throw new ArgumentNullException("빈 리스트");

        Random rand = new();
        for (int i = list.Count -1; i > 0; i--)
        {
            int r = rand.Next(0, i +1);
            T temp = list[r];
            list[r] = list[i];
            list[i] = temp;
        }
    }
}