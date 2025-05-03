namespace Task13;

class Program
{
    static void Main(string[] args)
    {
        static int[,] CreateMatrix(int rows, int columns)
        {
            return new int[rows, columns];
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength((0)); i++)
            {
                for (int j = 0; j < matrix.GetLength((1)); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        int[,] arr = CreateMatrix(3, 2);
        Random r = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = r.Next();
            }
        }
        PrintMatrix(arr);
    }
}