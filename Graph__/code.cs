using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public static class PROBLEM_CLASS
    {
        public static int RequiredFunction(Dictionary<string, int> vertices, Dictionary<KeyValuePair<string, string>, int> edges, string startVertex)
        {
            Dictionary<string, int> distances = new Dictionary<string, int>();
            foreach (var vertex in vertices)
            {
                distances[vertex.Key] = int.MaxValue;
            }

            distances[startVertex] = 0;

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                var currentVertex = queue.Dequeue();

                foreach (var edge in edges.Where(e => e.Key.Key == currentVertex || e.Key.Value == currentVertex))
                {
                    int newDistance = distances[currentVertex] + edge.Value;
                    if (newDistance < distances[edge.Key.Key == currentVertex ? edge.Key.Value : edge.Key.Key])
                    {
                        distances[edge.Key.Key == currentVertex ? edge.Key.Value : edge.Key.Key] = newDistance;
                        if (!queue.Contains(edge.Key.Key == currentVertex ? edge.Key.Value : edge.Key.Key))
                        {
                            queue.Enqueue(edge.Key.Key == currentVertex ? edge.Key.Value : edge.Key.Key);
                        }
                    }
                }
            }

            return distances["T"];
        }
    }
}
