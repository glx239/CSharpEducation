using System.Globalization;

namespace Practice2.Task7;

class Program
{
    static void Main(string[] args)
    {
        string? c = Console.ReadLine();
        string s = "привет";
        if (c == c.ToUpper())
        {
            Console.WriteLine(c.ToLower());
        }
        else
        {
            Console.WriteLine(c.ToUpper());
        }
        
        Console.WriteLine(Char.ToUpper(s[0]) + s.Substring(1));
    }
}