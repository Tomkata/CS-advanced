using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace _7._TheVLogger
{
    internal class Program
    {

        public class Vlogger
        {
            public Vlogger()
            {
                Followers = new HashSet<string>();
                Following = new HashSet<string>();
            }
            public HashSet<string> Followers { get; set; }
            public HashSet<string> Following { get; set; }
        }
        static void Main(string[] args)
            {
           var vloggers = new Dictionary<string, Vlogger>();
            string input;
            while ((input=Console.ReadLine())!= "Statistics")
            {
                string[] data = input.Split();
                string firstVlogger = data[0];
                string secondVlogger = data[2];
                string action = data[1];

                if (action is "joined" && !vloggers.ContainsKey(firstVlogger))
                {
                    vloggers.Add(firstVlogger, new Vlogger());
                }
                else if (action is "followed" && vloggers.ContainsKey(firstVlogger) &&
                    vloggers.ContainsKey(secondVlogger) && firstVlogger != secondVlogger
                    && !vloggers[secondVlogger].Followers.Contains(firstVlogger))
                {
                    vloggers[firstVlogger].Following.Add(secondVlogger);
                    vloggers[secondVlogger].Followers.Add(firstVlogger);
                }
            }

            var maxVlogger = vloggers.OrderByDescending(x => x.Value.Followers.Count)
                .ThenBy(x => x.Value.Following.Count);
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int count = 1;
            foreach (var item in maxVlogger)
            {

                Console.WriteLine($"{count}. {item.Key} : {item.Value.Followers.Count} followers, {item.Value.Following.Count} following");
                if (count==1)
                {
                    foreach (var vloger in item.Value.Followers.OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {vloger}");
                    }
                }
                count++;
            }
            
            
        }
    }
}
