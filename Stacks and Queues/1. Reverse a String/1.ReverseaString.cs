namespace LabStacksandQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var c in input)
                stack.Push(c);

            while (stack.Count != 0)
                Console.Write(stack.Pop());

        }
    }
}
