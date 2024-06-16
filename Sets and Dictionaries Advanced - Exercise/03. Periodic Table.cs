namespace _3.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            HashSet<string> words = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] compounds = Console.ReadLine().Split();
                for (int j = 0; j < compounds.Length; j++)
                    words.Add(compounds[j]);
            }

            foreach (var item in words.OrderBy(x=>x))
            {
                Console.Write(item + " ");
            }
        }
    }
}
