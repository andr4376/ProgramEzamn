using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExampleExamn
{
    //DFS = STACK ALGORITME BFS = QUEUE
    class DFS
    {

        public static void FindPath(Node target)
        {
            Stack<Edge> stack = new Stack<Edge>();

            List<Node> visitedNodes = new List<Node>();

            stack.Push(new Edge(Graph.nodes["FrederiksHavn"], Graph.nodes["FrederiksHavn"], 1));

            while (stack.Count > 0)
            {
                Edge currentEdge = stack.Pop();


                if (currentEdge.visited == false)
                {
                    currentEdge.visited = true;


                    if (!visitedNodes.Contains(currentEdge.backNode))
                    {
                        visitedNodes.Add(currentEdge.backNode);

                    }



                    foreach (Edge edge in currentEdge.forwardNode.edges)
                    {
                        stack.Push(edge);
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
