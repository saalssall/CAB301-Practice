using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(25);
            TreeNode node2 = new TreeNode(75);
            TreeNode root = new TreeNode(50, node1, node2);

            Console.WriteLine("--- Initial Tree ---");
            Console.WriteLine($"Root: {root.Value}");
            Console.WriteLine($"Left: {root.Left?.Value}");
            Console.WriteLine($"Right: {root.Right?.Value}");
            Console.WriteLine("---------------");
            
            Console.WriteLine("--- Searching the tree ---");
            Searching search = new Searching();
            search.Run();
            Console.WriteLine("---------------");
            
            Console.WriteLine("--- Inserting in the tree ---");
            Insertion insertion = new Insertion();
            insertion.Run();
            Console.WriteLine("---------------");
            
            Console.WriteLine("--- Deleting from the Tree ---");
            Deletion deletion = new Deletion();
            // pass root not node1, and capture return value
            root = deletion.Delete(25, root);

            Console.WriteLine("--- After Deleting 25 ---");
            Console.WriteLine($"Root: {root?.Value}");
            Console.WriteLine($"Left: {root?.Left?.Value}");
            Console.WriteLine($"Right: {root?.Right?.Value}");
        }
    }
}