using System;

namespace tictaktoe;

class Program
{
    static void Main(string[] args)
    {
        TicTakToe tictaktoe = new TicTakToe();
        
        Start(tictaktoe);
    }

    static void Start(TicTakToe tictaktoe)
    {
        while (tictaktoe.CheckTie(tictaktoe.board))
        {
            tictaktoe.DrawBoard(tictaktoe.board);
            
            if (tictaktoe.CurrentPlayer){
                Console.Write("Ходит первый игрок\nВведите цифру: ");
            }
            else{
                Console.Write("Ходит второй игрок\nВведите цифру: ");

            }

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                tictaktoe.CurrentPlayer = tictaktoe.Check(tictaktoe.board, num, tictaktoe.CurrentPlayer);
            }
            catch (Exception)
            {
                Console.WriteLine("введите корректное значение");
                continue;
            }

            if (tictaktoe.CheckWin(tictaktoe.board))
            {
                if (tictaktoe.CurrentPlayer)
                {
                    Console.WriteLine("Победил второй игрок");
                }
                else
                {
                    Console.WriteLine("Победил первый игрок");
                }
                break;
            }

        }
    }

}
    