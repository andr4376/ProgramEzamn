using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExampleExamn
{
    class Graph
    {
        public static Dictionary<string, Node> nodes = new Dictionary<string, Node>();

        public static void AddNode(string name, Node node)
        {
            node.cityName = name;
            nodes.Add(name, node);

        }

        public static void PrintGraph()
        {
            foreach (var tmp in nodes.Values)
            {
                foreach (Edge edge in tmp.edges)
                {
                    Console.WriteLine(edge.ToString());

                }
            }
        }
    }
}
