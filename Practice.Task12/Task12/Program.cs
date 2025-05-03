namespace Task12;

class Program
{
    static void Main(string[] args)
    {
        string[] arr = new string[5];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine();
        }

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}