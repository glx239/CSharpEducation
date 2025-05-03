namespace Task11;

class Program
{
    static void Main(string[] args)
    {
        int size = Convert.ToInt32(args[0]);
        int number = Convert.ToInt32(args[1]);
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = number;
        }
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}