
namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new Dictionary<string, List<string>>
            {
                { "Alice",   new List<string> { "Bob", "Diana", "Fred" } },
                { "Bob",     new List<string> { "Alice", "Cynthia", "Diana" } },
                { "Cynthia", new List<string> { "Bob" } },
                { "Diana",   new List<string> { "Alice", "Bob", "Fred" } },
                { "Elise",   new List<string> { "Fred" } },
                { "Fred",    new List<string> { "Alice", "Diana", "Elise" } }
            };
            
            foreach (string friend in friends["Alice"])
            {
                Console.WriteLine(friend);
            }
        }
    }
}