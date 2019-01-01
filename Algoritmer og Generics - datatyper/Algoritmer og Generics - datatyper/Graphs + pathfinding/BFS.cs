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
            Queue<Edge> edgeQueue = new Queue<Edge>(); //first in first out

            List<Node> visitedNodes = new List<Node>();

            
            edgeQueue.Enqueue(new Edge(Program.graph.nodes["Node #1"], Program.graph.nodes["Node #1"]));

            while (edgeQueue.Count > 0)
            {
                Edge currentEdge = edgeQueue.Dequeue();
                Console.WriteLine(currentEdge);


                if (currentEdge.visited == false) //If we have not been up this path
                {
                    currentEdge.visited = true; //then we have now
                    
                    visitedNodes.Add(currentEdge.backNode); //save the node we came from

                    //add all the egdes the node ahead has
                    foreach (Edge edge in currentEdge.forwardNode.edges)
                    {
                        edgeQueue.Enqueue(edge);
                    }

                    if (currentEdge.forwardNode.Value == target) //if it's the goal
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
