namespace MyNamespace;

public class Traversal
{
    
    /* The process of visiting every node in a data structure is
    known as traversing the data structure.*/
    
    public void TraverseAndPrint(TreeNode? node)
    {
        // Base case: if node is null, return
        if (node == null)
            return;

        // Traverse left subtree
        TraverseAndPrint(node.Left);

        // Print current node value
        Console.WriteLine(node.Value);

        // Traverse right subtree
        TraverseAndPrint(node.Right);
    }
}