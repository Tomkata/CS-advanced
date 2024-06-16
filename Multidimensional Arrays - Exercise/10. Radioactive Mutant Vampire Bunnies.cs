using System;
using System.Linq;
using System.Collections.Generic;
namespace RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read the input
            int[] sizeOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = sizeOfMatrix[0];
            int col = sizeOfMatrix[1];
            char[,] matrix = new char[row, col];
            int playerRow = 0;
            int playerCol = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                    if (matrix[i, j] == 'P')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }
            string directions = Console.ReadLine();

            foreach (var direaction in directions)
            {
                int nextRow = 0;
                int nextCol = 0;
                bool hasWon = false;
                bool isDead = false;
                switch (direaction)
                {
                    case 'L':
                        nextCol = -1;
                        break;
                    case 'R':
                        nextCol = 1;
                        break;
                    case 'U':
                        nextRow = -1;
                        break;
                    case 'D':
                        nextRow = 1;
                        break;
                    default:
                        break;
                }
                matrix[playerRow, playerCol] = '.'; //Set the old position in the player
               
                if (!IsInside(matrix, playerRow+nextRow, playerCol+nextCol))
                {
                    hasWon = true;
                }
                else
                {
                    playerCol += nextCol;
                    playerRow += nextRow;
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = 'P';
                    }
                }
               

                List<int[]> bunnyCoordinates = new List<int[]>();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'B')
                        {
                            bunnyCoordinates.Add(new int[] { i, j });
                        }
                    }
                }

                foreach (var item in bunnyCoordinates)
                {
                    int bunnyRow = item[0];
                    int bunnyCol = item[1];

                    if (IsInside(matrix, bunnyRow + 1, bunnyCol))
                    {
                        if (matrix[bunnyRow + 1, bunnyCol] == 'P')
                        {
                            isDead = true;
                        }
                        matrix[bunnyRow + 1, bunnyCol] = 'B';
                    }
                    if (IsInside(matrix, bunnyRow - 1, bunnyCol))
                    {
                        if (matrix[bunnyRow - 1, bunnyCol] == 'P')
                        {
                            isDead = true;
                        }
                        matrix[bunnyRow - 1, bunnyCol] = 'B';
                    }
                    if (IsInside(matrix, bunnyRow, bunnyCol - 1))
                    {
                        if (matrix[bunnyRow, bunnyCol - 1] == 'P')
                        {
                            isDead = true;

                        }
                        matrix[bunnyRow, bunnyCol - 1] = 'B';
                    }
                    if (IsInside(matrix, bunnyRow, bunnyCol + 1))
                    {
                        if (matrix[bunnyRow, bunnyCol + 1] == 'P')
                        {
                            isDead = true;
                        }
                        matrix[bunnyRow, bunnyCol + 1] = 'B';
                    }
                }
                if (hasWon)
                {
                    Print(matrix);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    return;
                }
                 else if (isDead)
                {
                    Print(matrix);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    return;

                }
            }
        }
        private static bool IsInside(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1);
        }
        private static void Print(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
