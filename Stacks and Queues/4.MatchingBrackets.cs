namespace _4.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indexPharenses = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexPharenses.Push(i);
                }
                else if (expression[i]==')')
                {
                    if (indexPharenses.Count == 0) return;
                    var end = i;
                    var start = indexPharenses.Pop();
                    Console.WriteLine(expression.Substring(start,end-start+1));
                }
            }
        }
    }
}
