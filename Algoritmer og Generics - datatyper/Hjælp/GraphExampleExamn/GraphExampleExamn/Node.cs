using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExampleExamn
{
    class Node
    {
       public List<Edge> edges;

       public string cityName;

        public Node( )
        {
            edges = new List<Edge>();
           
        }
        public void MakeConnection(Node toNode, int distance)
        {
            edges.Add(new Edge(toNode, this, distance));
                        
        }
        public override string ToString()
        {
            return cityName;
        }

        public void PrintNode()
        {
            foreach (Edge edge in edges)
            {
                edge.ToString();
            }
        }
    }
}
