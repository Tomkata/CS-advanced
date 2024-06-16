using System.Reflection;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            else if (n == 0)
                return;

            long[][] pascal = new long[n][];
            pascal[0] = new long[1];
            pascal[1] = new long[2];
            pascal[0][0] = 1;
            pascal[1][0] = 1;
            pascal[1][1] = 1;
            for (int i = 2; i < n; i++)
            {
                pascal[i] = new long[i + 1];
                for (int j = 0; j < pascal[i].Length; j++)
                {
                    if(j==0)
                    pascal[i][0] = 1;

                    else if (j == pascal[i].Length-1)
                        pascal[i][^1] = 1;

                    else
                    pascal[i][j] = pascal[i - 1][j-1] + pascal[i - 1][j ];
                }
            }

            for (int i = 0; i < pascal.Length; i++)
                Console.WriteLine(string.Join(" ", pascal[i]));
        }
    }
}
