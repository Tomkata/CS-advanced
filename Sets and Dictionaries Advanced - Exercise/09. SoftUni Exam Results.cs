using System.Data;

namespace SoftUniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var examStore = new Dictionary<string, int>();
            var participantInfo = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] data = input.Split("-");
                string username = data[0];
                string langueage = data[1];
                if (langueage == "banned")
                {
                    participantInfo.Remove(username);
                    continue;
                }
                int points = int.Parse(data[2]);

                if (!participantInfo.ContainsKey(username))
                {
                    participantInfo.Add(username, points);

                    if (!examStore.ContainsKey(langueage))
                    {
                        examStore.Add(langueage, 1);
                    }

                    else examStore[langueage]++;
                    continue;
                }
                if (participantInfo[username] < points)
                {
                    participantInfo[username] = points;
                }
                examStore[langueage]++;

            }
            var ordered = participantInfo.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            Console.WriteLine("Results:");
            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            var orderedLangueages = examStore.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");
            foreach (var item in orderedLangueages)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
