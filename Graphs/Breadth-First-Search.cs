namespace Graphs;

public class Breadth_First_Search
{
    public void BfsTraverse(string startingVertex, Dictionary<string, List<string>> graph)
    {
        Queue<string> queue = new Queue<string>();

        HashSet<string> visitedVertices = new HashSet<string>();
        visitedVertices.Add(startingVertex);
        queue.Enqueue(startingVertex);

        // While the queue is not empty:
        while (queue.Count > 0)
        {
            // Remove the first vertex off the queue and make it the current vertex:
            string currentVertex = queue.Dequeue();

            // Print the current vertex's value:
            Console.WriteLine(currentVertex);

            // Iterate over current vertex's adjacent vertices:
            foreach (string adjacentVertex in graph[currentVertex])
            {
                // If we have not yet visited the adjacent vertex:
                if (!visitedVertices.Contains(adjacentVertex))
                {
                    // Mark the adjacent vertex as visited:
                    visitedVertices.Add(adjacentVertex);

                    // Add the adjacent vertex to the queue:
                    queue.Enqueue(adjacentVertex);
                }
            }
        }
    }
}