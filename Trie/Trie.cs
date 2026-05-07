namespace Trie;

public class Trie
{
    private readonly TrieNode _root;

    public Trie()
    {
        _root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode currentNode = _root;

        foreach (char c in word)
        {
            if (!currentNode.Children.TryGetValue(c, out TrieNode? next))
            {
                next = new TrieNode();
                currentNode.Children[c] = next;
            }
            currentNode = next;
        }

        currentNode.IsEnd = true;
    }

    public TrieNode? Search(string word)
    {
        TrieNode currentNode = _root;

        foreach (char c in word)
        {
            if (!currentNode.Children.TryGetValue(c, out TrieNode? next))
                return null;

            currentNode = next;
        }

        return currentNode;
    }

    public bool ExactMatch(string word) => Search(word)?.IsEnd == true;
    public bool StartsWith(string prefix) => Search(prefix) != null;
}