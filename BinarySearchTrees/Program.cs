using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // build tree correctly using Insert from the start
            TreeNode root = new TreeNode(50);
            Insertion insertion = new Insertion();

            insertion.Insert(25, root);
            insertion.Insert(75, root);
            insertion.Insert(10, root);
            insertion.Insert(30, root);

            Console.WriteLine("--- Initial Tree ---");
            Console.WriteLine($"Root: {root.Value}");
            Console.WriteLine($"Left: {root.Left?.Value}");
            Console.WriteLine($"Right: {root.Right?.Value}");

            Console.WriteLine("--- In-Order Traversal (before deletion) ---");
            Traversal traversal = new Traversal();
            traversal.TraverseAndPrint(root);

            Console.WriteLine("--- Searching the tree ---");
            Searching search = new Searching();
            search.Run();
           
            Console.WriteLine("--- Inserting 60 into the tree ---");
            insertion.Insert(60, root);
          
            Console.WriteLine("--- Deleting 25 from the tree ---");
            Deletion deletion = new Deletion();
            root = deletion.Delete(25, root);

            Console.WriteLine($"Root: {root?.Value}");
            Console.WriteLine($"Left: {root?.Left?.Value}");
            Console.WriteLine($"Right: {root?.Right?.Value}");
            Console.WriteLine("---------------");

            Console.WriteLine("--- In-Order Traversal (after deletion) ---");
            traversal.TraverseAndPrint(root);
        }
    }
}