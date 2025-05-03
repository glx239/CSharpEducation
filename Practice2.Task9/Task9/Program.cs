namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        static int[] CreateArray(int size)
        {
            return new int[size];
        }

        void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
        int[] array = CreateArray(10); 
        PrintArray(array);
    }
}