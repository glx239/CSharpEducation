namespace Task8;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        if (a == b || b == c || a == c)
        {
            a += 5;
            b += 5;
            c += 5;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
        else
        {
            Console.WriteLine("равных нет");
        }
    }
}