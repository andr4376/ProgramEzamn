using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExampleExamn
{
    class Program
    {
        static void Main(string[] args)
        {
            //En graph er en abstract data structure
            //Ligesom list stack, hashset, queue
            //Et netværk af noder 

            Graph.AddNode("FrederiksHavn", new Node());
            Graph.AddNode("Aalborg", new Node());
            Graph.AddNode("Aarhus", new Node());
            Graph.AddNode("sj. Odde", new Node());
            Graph.AddNode("Fredericia", new Node());
            Graph.AddNode("Odense", new Node());
            Graph.AddNode("København", new Node());
            Graph.AddNode("Rønne", new Node());


            Graph.nodes["FrederiksHavn"].MakeConnection(Graph.nodes["Aalborg"], 64);
            Graph.nodes["Aalborg"].MakeConnection(Graph.nodes["København"], 222);
            Graph.nodes["Aalborg"].MakeConnection(Graph.nodes["Aarhus"], 118);
            Graph.nodes["Aarhus"].MakeConnection(Graph.nodes["sj. Odde"], 72);
            Graph.nodes["Aarhus"].MakeConnection(Graph.nodes["Fredericia"], 93);
            Graph.nodes["Fredericia"].MakeConnection(Graph.nodes["Odense"], 54);
            Graph.nodes["Odense"].MakeConnection(Graph.nodes["København"], 162);
            Graph.nodes["sj. Odde"].MakeConnection(Graph.nodes["København"], 72);
            Graph.nodes["København"].MakeConnection(Graph.nodes["Rønne"], 150);

            Graph.PrintGraph();

            BFS.FindPath(Graph.nodes["Rønne"]);
           // DFS.FindPath(Graph.nodes["Rønne"]); //pick one because Graph is static :))



           
            Console.ReadKey();


        }
    }
}
