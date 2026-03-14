using System;

// 1.
{
    Console.WriteLine("안녕하세요".First(3));
}
Console.WriteLine();

// 2.
{
    Player player = new Player() { Name = "용사", Level = 5, Experience = 150 };
    Console.WriteLine(player.GetInfo());
    Console.WriteLine($"레벨업 가능? {player.CanLevelUp()}");
    player.LevelUp();
    Console.WriteLine(player.GetInfo());
}

// 2.
class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
}

static class PlayerExtensions
{
    public static string GetInfo(this Player player)
    {
        return $"[{player.Name}] 레벨: {player.Level}, 경험치: {player.Experience}";
    }

    public static bool CanLevelUp(this Player player)
    {
        return player.Experience >= 100;
    }

    public static void LevelUp(this Player player)
    {
        player.Experience -= 100;
        player.Level += 1;
        Console.WriteLine($"{player.Name}(이)가 레벨업! 현재 레벨: {player.Level}");
    }
}

// 1.
public static class StringExtensions
{
    public static string First(this string text, int count)
    {
        if (text == "") return text;
        if (text.Length < count) return text;
        return text.Substring(0, count);
    }
}