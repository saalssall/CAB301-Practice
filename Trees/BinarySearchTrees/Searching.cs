namespace MyNamespace;

public class Searching
{
    
    //Searching takes O(log N) steps for a balanced tree.
    
    /// <summary>
    /// Searching for a value in the tree
    /// </summary>
    /// <param name="searchValue"></param>
    /// <param name="node"></param>
    /// <returns></returns>
    public TreeNode? Search(int searchValue, TreeNode? node)
    {
        // Base case: If the node is nonexistent
        // or we've found the value we're looking for:
        if (node == null || node.Value == searchValue)
            return node;

        // If the value is less than the current node, perform
        // search on the left child:
        else if (searchValue < node.Value)
            return Search(searchValue, node.Left);

        // If the value is greater than the current node, perform
        // search on the right child:
        else // searchValue > node.Value
            return Search(searchValue, node.Right);
    }

    /// <summary>
    /// Run
    /// </summary>
    public void Run()
    {
        TreeNode node1 = new TreeNode(25);
        TreeNode node2 = new TreeNode(75);
        TreeNode root = new TreeNode(50, node1, node2);
        TreeNode? result = Search(25, root);

        //Check if the value exists
        if (result != null)
            Console.WriteLine($"Found: {result.Value}");
        else 
            Console.WriteLine("Value not found");
    }
}