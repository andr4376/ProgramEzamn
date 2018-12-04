using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    /// <summary>
    /// Edges fungere som broer imellem to noder, 
    /// </summary>
    class Edge
    {
        public Node forwardNode;
        public Node backNode;
        public bool visited = false;

        public Edge(Node _backNode, Node _forwardNode)
        {
            forwardNode = _forwardNode;
            backNode = _backNode;
        }

        public override string ToString()
        {
            return "Edge From Node " + backNode.ToString() + "  to Node " + forwardNode.ToString();
        }
    }
}
