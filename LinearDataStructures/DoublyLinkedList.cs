namespace Data_Structures;

public class DoublyLinkedList
{
    public Node Head { get; set; }
    public Node Tail { get; set; }

    public DoublyLinkedList(Node head = null, Node tail = null)
    {
        Head = head;
        Tail = tail;
    }

    public void InsertAtEnd(string value)
    {
        Node newNode = new Node(value);

        if (Head == null) // List is empty
        {
            Head = newNode;
            Tail = newNode;
        }
        else // List has at least one node
        {
            newNode.PreviousNode = Tail;
            Tail.NextNode = newNode;
            Tail = newNode;
        }
    }
}