using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    class BFS
    {
        //DFS = STACK ALGORITME BFS = QUEUE

        //bfs "BREDDE FØRST SØGNING" tjekker hver mulighed for hver node, og dermed finder den hurtigste vej

        public static void FindPath(int target)
        {
            Queue<Edge> queue = new Queue<Edge>();

            List<Node> visitedNodes = new List<Node>();

            queue.Enqueue(new Edge(Program.graph.nodes["Node #1"], Program.graph.nodes["Node #1"]));

            while (queue.Count > 0)
            {
                Edge currentEdge = queue.Dequeue();
                Console.WriteLine(currentEdge);


                if (currentEdge.visited == false)
                {
                    currentEdge.visited = true;


                    visitedNodes.Add(currentEdge.backNode);



                    foreach (Edge edge in currentEdge.forwardNode.edges)
                    {
                        queue.Enqueue(edge);
                    }

                    if (currentEdge.forwardNode.Value == target)
                    {
                        Console.WriteLine("target found");

                        foreach (Node _node in visitedNodes)
                        {
                            Console.WriteLine(_node.ToString());
                        }
                        Console.WriteLine("Node #" + target);

                        break;
                    }
                }



            }
        }

    }

}
