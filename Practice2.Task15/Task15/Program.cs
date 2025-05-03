namespace Task15;

class Program
{
    static void InvertArray(int[] arr)
    {
        int temp = 0;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = temp;
        }
    }
    static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        InvertArray(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}