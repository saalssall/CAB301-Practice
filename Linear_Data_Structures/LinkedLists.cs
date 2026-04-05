namespace Data_Structures;

public class LinkedList
{
    public Node Head { get; set; }
    public Node Tail { get; set; }

    public LinkedList(Node head)
    {
        Head = head;
        Tail = head;
    }
    public string Read(int index)
    {
        // Start at the head of the list
        Node currentNode = Head;
        int currentIndex = 0;

        while (currentIndex < index)
        {
            // Move to next node
            currentNode = currentNode.NextNode;
            currentIndex++;

            // If end of list reached
            if (currentNode == null)
                return null;
        }

        return currentNode.Data;
    }
    
    public int? IndexOf(string value)
    {
        // Start at the head
        Node currentNode = Head;
        int currentIndex = 0;

        while (currentNode != null)
        {
            // If value found
            if (currentNode.Data == value)
            {
                return currentIndex;
            }

            // Move to next node
            currentNode = currentNode.NextNode;
            currentIndex++;
        }

        // Not found
        return null;
    }
    public void InsertAtIndex(int index, string value)
    {
        Node newNode = new Node(value);

        // Inserting at the beginning
        if (index == 0)
        {
            newNode.NextNode = Head;
            Head = newNode;

            // If the list was empty, update Tail too
            if (Tail == null)
                Tail = newNode;

            return;
        }

        Node currentNode = Head;
        int currentIndex = 0;

        // Traverse to the node immediately before the insertion point
        while (currentIndex < index - 1)
        {
            if (currentNode == null)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            currentNode = currentNode.NextNode;
            currentIndex++;
        }

        // Insert the new node
        newNode.NextNode = currentNode.NextNode;
        currentNode.NextNode = newNode;

        // Update tail if inserted at the end
        if (newNode.NextNode == null)
            Tail = newNode;
    }
    
    public void DeleteAtIndex(int index)
    {
        if (Head == null)
            throw new InvalidOperationException("List is empty.");

        // Deleting the first node
        if (index == 0)
        {
            Head = Head.NextNode;

            // If list becomes empty, update Tail
            if (Head == null)
                Tail = null;

            return;
        }

        Node currentNode = Head;
        int currentIndex = 0;

        // Find the node immediately before the one we want to delete
        while (currentIndex < index - 1)
        {
            if (currentNode.NextNode == null)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            currentNode = currentNode.NextNode;
            currentIndex++;
        }

        // Node to delete
        Node nodeToDelete = currentNode.NextNode;

        if (nodeToDelete == null)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

        // Update the link to skip the deleted node
        currentNode.NextNode = nodeToDelete.NextNode;

        // If deleting the tail, update Tail
        if (currentNode.NextNode == null)
            Tail = currentNode;
    }
}