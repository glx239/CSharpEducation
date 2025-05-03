namespace Task10;

class Program
{
    static void Main(string[] args)
    {
        int size = Convert.ToInt32(args[0]);
        int[] arr = new int[size];
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}