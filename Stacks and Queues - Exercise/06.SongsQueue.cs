namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songQueue = new Queue<string>();

            foreach (var song in songs)
                songQueue.Enqueue(song);

            while (songQueue.Count>0)
            {
                string[] commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "Play":
                        songQueue.Dequeue();
                        break;
                    case "Add":
                        string song = string.Empty;
                        for (int i = 1; i < commands.Length; i++)
                            song = song + " " + commands[i];

                        song = song.Trim();
                        if(songQueue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                            continue;
                        }
                        songQueue.Enqueue(song);
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",songQueue));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
