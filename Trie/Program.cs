namespace Trie;

class Program
{
    static void Main(string[] args)
    {
        Trie trie = new Trie();

        trie.Insert("apple");
        trie.Insert("app");
        trie.Insert("banana");

        Console.WriteLine(trie.ExactMatch("app"));    // true
        Console.WriteLine(trie.ExactMatch("appl"));   // false
        Console.WriteLine(trie.StartsWith("appl"));   // true
        Console.WriteLine(trie.StartsWith("xyz"));    // false
    }
}