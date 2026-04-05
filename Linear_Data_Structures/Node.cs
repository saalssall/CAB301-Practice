namespace Data_Structures;

public class Node
{
    public string Data { get; set; }
    public Node NextNode { get; set; }

    public Node(string data)
    {
        Data = data;
        NextNode = null;
    }

    //Overriding the ToString method to check the nodes and what comes after them
    public override string ToString()
    {
        return $"{Data} -> {(NextNode != null ? NextNode.Data : "null")}";
    }
    
    
}
