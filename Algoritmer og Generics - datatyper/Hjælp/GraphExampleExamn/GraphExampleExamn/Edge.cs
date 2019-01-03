using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExampleExamn
{
    class Edge
    {
        public bool visited;
       public Node forwardNode;
       public Node backNode;

        int distance;

        public Edge(Node forward, Node back, int _distance)
        {
            forwardNode = forward;
            backNode = back;
            distance = _distance;
        }


        public override string ToString()
        {
            return "Road from " + backNode.ToString() + " to " + forwardNode.ToString() + "  Distance: " + distance;
        }
    }
}
