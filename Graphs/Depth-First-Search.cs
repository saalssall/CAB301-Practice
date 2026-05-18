namespace Graphs;

public class Depth_First_Search
{ 
    public void Traverse(string vertex, Dictionary<string, List<string>> graph, HashSet<string> visitedVertices = null)
        {
            visitedVertices ??= new HashSet<string>();

            visitedVertices.Add(vertex);
            Console.WriteLine(vertex);

            foreach (string adjacentVertex in graph[vertex])
            {
                if (visitedVertices.Contains(adjacentVertex))
                    continue;

                Traverse(adjacentVertex, graph, visitedVertices);
            }
        }
}