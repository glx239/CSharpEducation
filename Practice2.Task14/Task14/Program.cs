namespace Task14;

class Program
{
    static int[] CreateArray(int n)
    {
        return new int[n];
    }
    static void Main(string[] args)
    {
        int[] arr = CreateArray(10);
        Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next();
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}