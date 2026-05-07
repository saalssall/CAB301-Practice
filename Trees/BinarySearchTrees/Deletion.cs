namespace MyNamespace;

public class Deletion
{
  public TreeNode? Delete(int valueToDelete, TreeNode? node)
{
    // The base case is when we've hit the bottom of the tree,
    // and the parent node has no children:
    if (node == null)
        return null;

    // If the value we're deleting is less or greater than the current node,
    // we set the left or right child respectively to be
    // the return value of a recursive call of this
    // very method on the current
    // node's left or right subtree.
    else if (valueToDelete < node.Value)
    {
        node.Left = Delete(valueToDelete, node.Left);

        // We return the current node (and its subtree if existent) to
        // be used as the new value of its parent's left or right child:
        return node;
    }
    else if (valueToDelete > node.Value)
    {
        node.Right = Delete(valueToDelete, node.Right);
        return node;
    }

    // If the current node is the one we want to delete:
    else // valueToDelete == node.Value
    {
        // If the current node has no left child, we delete it by
        // returning its right child (and its subtree if existent)
        // to be its parent's new subtree:
        if (node.Left == null)
            return node.Right;

            // (If the current node has no left OR right child, this ends up
            // being null as per the first line of code in this function.)

        else if (node.Right == null)
            return node.Left;

        // If the current node has two children, we delete the current node
        // by calling the lift function (below),
        // which changes the current node's
        // value to the value of its successor node:
        else
        {
            node.Right = Lift(node.Right, node);
            return node;
        }
    }
}

public TreeNode? Lift(TreeNode node, TreeNode nodeToDelete)
{
    // If the current node of this function has a left child,
    // we recursively call this function to continue down
    // the left subtree to find the successor node.
    if (node.Left != null)
    {
        node.Left = Lift(node.Left, nodeToDelete);
        return node;
    }
    // If the current node has no left child, that means the current node
    // of this function is the successor node, and we take its value
    // and make it the new value of the node that we're deleting:
    else
    {
        nodeToDelete.Value = node.Value;
        // We return the successor node's right child to be now used
        // as its parent's left child:
        return node.Right;
    }
}
    
    
}