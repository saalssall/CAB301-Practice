namespace MyNamespace;

public class Insertion
{
    // Insertion takes O(log N) + 1 steps.
    //if we insert sorted data into a tree, it can become imbalanced and less efficient.
    //if you ever want to convert an ordered array into a binary search tree, you’d better
    //first randomize the order of the data.
    
    //It emerges that in a worst-case scenario, when a tree is completely imbalanced, search is O(N).
    //In a best-case scenario, when it is perfectly balanced, search is O(log N). In the typical scenario,
    //in which data is inserted in random order,
    //a tree will be pretty well balanced and search will take about O(log N).
    
    /// <summary>
    /// Insert a value to the tree
    /// </summary>
    /// <param name="value"></param>
    /// <param name="node"></param>

    public void Insert(int value, TreeNode? node)
    {
        if (value < node.Value)
        {
            // If the left child does not exist, we want to insert
            // the value as the left child:
            if (node.Left == null)
            {
                node.Left = new TreeNode(value);
            }
            else
            {
                Insert(value, node.Left);
            }
        }
        else if (value > node.Value)
        {
            // If the right child does not exist, we want to insert
            // the value as the right child:
            if (node.Right == null)
            {
                node.Right = new TreeNode(value);
            }
            else
            {
                Insert(value, node.Right);
            }
        }
    }
}