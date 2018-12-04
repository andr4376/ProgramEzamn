using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    /// <summary>
    /// En node eller en "knude" er et punkt på en graf som via "edges" har kenskab til andre noder (også kaldet Vertix / vertices)
    /// </summary>
    class Node
    {
        public int Value { get; set; }

        public List<Edge> edges = new List<Edge>();


        public Node(int value)
        {
            Value = value;
        }

        public void MakeConnection(Node node, bool canGoBack)
        {
            edges.Add(new Edge(this, node));

            if (canGoBack)
            {
                node.edges.Add(new Edge(node, this));
            }
        }
        public void WriteEdges()
        {
            foreach (Edge edge in edges)
            {
                Console.WriteLine(edge);
            }
        }
        public override string ToString()
        {
            return "Node #" + Value.ToString();
        }
    }
}
