namespace Graphs;

public class WeightedGraphVertex 
{
    // The value (name) of the vertex
    public string Value { get; set; }

    // A dictionary of adjacent vertices and their weights
    // Key: the adjacent vertex, Value: the weight of the edge
    public Dictionary<WeightedGraphVertex, int> AdjacentVertices { get; set; }

    // Constructor: initializes the vertex with a value
    // and an empty dictionary of adjacent vertices
    public WeightedGraphVertex(string value)  
    {
        Value = value;
        AdjacentVertices = new Dictionary<WeightedGraphVertex, int>();
    }

    // Adds an adjacent vertex with a weight to the dictionary
    public void AddAdjacentVertex(WeightedGraphVertex vertex, int weight)
    {
        AdjacentVertices[vertex] = weight;
    }
}