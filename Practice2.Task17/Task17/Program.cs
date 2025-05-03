namespace Task17;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
        
    }
    static void Main(string[] args)
    {
        int a = 5;
        int b = 26;
        Console.WriteLine($"a: {a}, b: {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}");
    }
}