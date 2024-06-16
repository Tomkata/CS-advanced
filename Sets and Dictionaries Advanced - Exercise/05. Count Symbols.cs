namespace _5.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var letter in text)
            {
                if (!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 0);
                }
                letters[letter]++;
            }

            letters = letters.OrderBy(x => x.Key).ToDictionary(x=>x.Key, c=>c.Value);
            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
