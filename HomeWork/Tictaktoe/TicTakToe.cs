using System;

namespace tictaktoe;

public class TicTakToe
{
    public bool CurrentPlayer = true; // true - крестики, false - нолики.
    public int[] board = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    public void DrawBoard(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if ((i + 1) % 3 == 0)
            {
                if (array[i] == -1)
                {
                    Console.WriteLine('X');
                }
                else if (array[i] == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(array[i]);
                }

            }
            else
            {
                if (array[i] == -1)
                {
                    Console.Write('X' + "|");
                }
                else if (array[i] == 0)
                {
                    Console.Write(0 + "|");
                }
                else
                {
                    Console.Write(array[i] + "|");

                }
            }

        }
    }
    public bool Check(int[] array, int num, bool turn){
            
        if (array[num - 1] == 0 ||  array[num - 1] == -1){
            Console.WriteLine("Данная клетка занята, введите другую");
            return turn;
        }
        if (turn){
            array[num - 1] = -1;
                
            return false;
        }
        else{
            array[num - 1] = 0;
            return true;
        }
    }

    public bool CheckTie(int[] array)
    { 
        int count = 0;
        foreach (int i in array)
        {

            if (i == -1  || i == 0)
            {
                count++;
            }
        }

        if (count == 9)
        {
            Console.WriteLine("Ничья");
            DrawBoard(board);
            return false;
        }
        return true;
    }

    public bool CheckWin(int[] array)
    {
        return (array[0] == array[1] && array[1] == array[2]) ||
               (array[3] == array[4] && array[4] == array[5]) ||
               (array[6] == array[7] && array[7] == array[8]) ||
               (array[0] == array[3] && array[3] == array[6]) ||
               (array[1] == array[4] && array[4] == array[7]) ||
               (array[2] == array[5] && array[5] == array[8]) ||
               (array[0] == array[4] && array[4] == array[8]) ||
               (array[2] == array[4] && array[4] == array[6]);
    }
}