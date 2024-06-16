namespace Ranking
{
    internal class Program
    {
        public class Participant
        {
            public Dictionary<string, int> ContestStatistic { get; set; } = new Dictionary<string, int>();
        }
        static void Main(string[] args)
        {
            var contestInfo = new Dictionary<string, string>();
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] data = input.Split(":");
                string contest = data[0];
                string password = data[1];
                contestInfo.Add(contest, password);
            }

            //C# Fundamentals=>fundPass=>Tanya=>350
            var participant = new Dictionary<string, Participant>();
            string input2;
            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] data = input2.Split("=>");
                string givenContest = data[0];
                string givenPassword = data[1];
                string username = data[2];
                int points = int.Parse(data[3]);

                if (contestInfo.ContainsKey(givenContest) && contestInfo.ContainsValue(givenPassword))
                {
                    if (!participant.ContainsKey(username))
                    {
                        participant.Add(username, new Participant());
                    }
                    if (!participant[username].ContestStatistic.ContainsKey(givenContest))
                    {
                        participant[username].ContestStatistic.Add(givenContest, points);
                        continue;
                    }
                    if (participant[username].ContestStatistic[givenContest] < points)
                    {
                        participant[username].ContestStatistic[givenContest] = points;
                    }
                }
            }
            var bestUser = participant.OrderByDescending(x => x.Value.ContestStatistic.Values.Sum()).FirstOrDefault();
            Console.WriteLine($"Best candidate is {bestUser.Key} with total {bestUser.Value.ContestStatistic.Sum(x=>x.Value)} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in participant.OrderBy(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var contestInfoForPlayer in item.Value.ContestStatistic.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contestInfoForPlayer.Key} -> {contestInfoForPlayer.Value}");
                }
            }

        }
    }
}

