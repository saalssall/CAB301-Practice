namespace Graphs;

public class Depth_First_SearchV
{
    public string? Dfs(string vertex, string searchValue, Dictionary<string, List<string>> graph, HashSet<string> visitedVertices = null)
    {
        // Return the original vertex if it happens to
        // be the one we're searching for:
        if (vertex == searchValue)
            return vertex;

        visitedVertices ??= new HashSet<string>();
        visitedVertices.Add(vertex);

        foreach (string adjacentVertex in graph[vertex])
        {
            if (visitedVertices.Contains(adjacentVertex))
                continue;

            // If the adjacent vertex is the vertex we're searching for, just return
            // that vertex:
            if (adjacentVertex == searchValue)
                return adjacentVertex;

            // Attempt to find the vertex we're searching for by recursively calling
            // this method on the adjacent vertex:
            string? vertexWereSearchingFor =
                Dfs(adjacentVertex, searchValue, graph, visitedVertices);

            // If we were able to find the correct vertex using the above recursion,
            // return the correct vertex:
            if (vertexWereSearchingFor != null)
                return vertexWereSearchingFor;
        }

        // If we haven't found the vertex we're searching for:
        return null;
    }
}