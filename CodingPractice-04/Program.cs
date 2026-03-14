using System;

// 1.
{
    string input = "  hello world  ";

    string result1 = 
        StringExtensions.Replace(
            StringExtensions.Upper(
                StringExtensions.Trim(input)), ' ', '_');

    string result2 = input.Trim().Upper().Replace(' ', '_');

    Console.WriteLine($"결과1: {result1}");
    Console.WriteLine($"결과2: {result2}");
}
Console.WriteLine();

// 2.
{
    SecretBox box = new SecretBox();
    box.Access();
}
Console.WriteLine();

// 3.
{
    Greeter g = new Greeter();
    g.SayHello();    
    g.SayGoodbye(); 

    GreeterExtensions.SayHello(g);
}
Console.WriteLine();

// 3.
class Greeter
{
    public void SayHello() => Console.WriteLine("인스턴스: 안녕하세요!");
}

static class GreeterExtensions
{
    public static void SayHello(this Greeter greeter) => Console.WriteLine("확장: 안녕하세요!");
    public static void SayGoodbye(this Greeter greter) => Console.WriteLine("확장: 안녕히 가세요!");
}

// 2.
class SecretBox
{
    private string _secret;
    public string PublicData = "공개";
}

static class SecretBoxExtensions
{
    public static void Access(this SecretBox box)
    {
        Console.WriteLine($"공개 데이터: {box.PublicData}");
    }
}

// 1.
static class StringExtensions
{
    public static string Upper(this string text)
    {
        return text.ToUpper();
    }

    public static string Trim(this string text)
    {
        return text.Trim();
    }

    public static string Replace(this string text, char oldChar, char newChar)
    {
        return text.Replace(oldChar, newChar);
    }
}