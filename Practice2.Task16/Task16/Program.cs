namespace Task16;

class Program
{
    static void Main(string[] args)
    {
        void Invert(ref int x)
        {
            x = -x;
        }

        int n = 3;
        int k = -5;
        Invert(ref n);
        Invert(ref k);
        Console.WriteLine(n);
        Console.WriteLine(k);
    }
}