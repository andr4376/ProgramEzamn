using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmer_og_Generics___datatyper
{
    /// <summary>
    /// En graph er et netværk a knuder / noder
    /// </summary>
    class Graph
    { 

        public Dictionary<string, Node> nodes = new Dictionary<string, Node>();

        public void AddNode(string name, Node node)
        {
            nodes.Add(name, node);

        }
    }
}
