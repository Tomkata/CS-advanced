using System.Diagnostics.CodeAnalysis;
using System.Net.WebSockets;

namespace _8.BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                {
                    stack.Push(input[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    var last = stack.Pop();
                    if (last == '(' && input[i] != ')' || last == '{' && input[i] != '}' &&
                        last == '[' && input[i] != ']')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}


