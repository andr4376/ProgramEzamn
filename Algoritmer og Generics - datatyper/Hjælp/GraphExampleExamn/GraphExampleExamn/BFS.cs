using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExampleExamn
{

    //DFS = STACK ALGORITME BFS = QUEUE
    class BFS
    {

        public static void FindPath(Node target)
        {
            Queue<Edge> queue = new Queue<Edge>();

            List<Node> visitedNodes = new List<Node>();

            queue.Enqueue(new Edge(Graph.nodes["FrederiksHavn"], Graph.nodes["FrederiksHavn"], 1));

            while (queue.Count > 0)
            {
                Edge currentEdge = queue.Dequeue();


                if (currentEdge.visited == false)
                {
                    currentEdge.visited = true;


                    if (!visitedNodes.Contains(currentEdge.backNode))
                    {
                        visitedNodes.Add(currentEdge.backNode);

                    }



                    foreach (Edge edge in currentEdge.forwardNode.edges)
                    {
                        queue.Enqueue(edge);
                    }

                    if (currentEdge.forwardNode == target)
                    {
                        Console.WriteLine("target found");

                        foreach (Node _node in visitedNodes)
                        {
                            Console.WriteLine(_node.ToString());

                        }
                        Console.WriteLine(target);

                        break;
                    }
                }



            }
        }

    }
}

