using System.Text;

namespace _03.MaximumandMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> sequence = new Stack<string>();
            string text = string.Empty;
            string previous = string.Empty;
            for (int i = 0; i < n; i++)
            {
                    string[] commands = Console.ReadLine()
                    .Split();
                int command = int.Parse(commands[0]);

                switch (command)
                {
                    case 1:
                        if (sequence.Count is 0)
                        {
                             previous = string.Empty;

                        }

                        text += commands[1];
                            sequence.Push(previous);
                        previous = text;
                        break;
                    case 2:
                        if (sequence.Count is 0)
                             previous = string.Empty;


                        int count = int.Parse(commands[1]);
                        text = text.Remove(text.Length - count,count);
                        sequence.Push(previous);
                        previous = text;
                        break;  
                    case 3:
                        int index = int.Parse(commands[1]);
                        Console.WriteLine(text[index-1]);
                        break;
                    case 4:
                        text = sequence.Pop();
                        break;
                }
            }
        }
    }
}
