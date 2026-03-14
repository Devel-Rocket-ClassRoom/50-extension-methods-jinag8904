using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("=== 컬렉션 청킹 테스트 ===");

Console.WriteLine("\n[숫자를 3개씩 그룹화]");
List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

try
{
    var result1 = ints.Chunk(3).Select(c => c.ToList()).ToList();
    foreach (List<int> factors in result1)
    {
        Console.WriteLine($"[{string.Join(", ", factors)}]");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"오류: {ex.Message}");
}

Console.WriteLine("\n[학생들을 2명씩 팀 구성]");
List<string> strings = new List<string> { "김철수", "이영희", "박민수", "최지연", "정우진" };

try
{
    var result2 = strings.Chunk(2).Select(c => c.ToList()).ToList();
    int count = 1;
    foreach (List<string> factors in result2)
    {
        Console.WriteLine($"팀 {count++}: {string.Join(", ", factors)}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"오류: {ex.Message}");
}

Console.WriteLine("\n[페이지별로 5개씩 나누기]");
List<int> ints2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

try
{
    var result3 = ints2.Chunk(5).Select(c => c.ToList()).ToList();
    int count = 1;
    foreach (List<int> factors in result3)
    {
        Console.WriteLine($"페이지 {count++}: {string.Join(", ", factors)}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"오류: {ex.Message}");
}

static class Class
{ 
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> collection, int size)
    {
        if (size < 1) throw new ArgumentException("청크의 크기는 0보다 커야 합니다.");

        List<T> chunk = new List<T>(size);

        foreach (var item in collection)
        {
            chunk.Add(item);

            if (chunk.Count == size)
            {
                yield return chunk;
                chunk = new List<T>(size);
            }
        }

        if (chunk.Any())
        {
            yield return chunk;
        }
    }
}