using System;
using System.Collections.Generic;

namespace Algoritmer_og_Generics___datatyper
{
    class Program
    {
        public static Graph graph = new Graph();

       

        static void Main(string[] args)
        {
            #region Generic Class

            //Samme koncept som dictionary
            KeyValuePair<string, int> price = new KeyValuePair<string, int>("mcNuggies", 30);
            price.Print();

            Console.WriteLine();

            Console.WriteLine(Utility.CompareValues("hej", 101));

            Console.WriteLine(Utility.CompareDataTypes("hej", "lmao"));

            #endregion;

            #region Highscore

            List<HighScore> highscores = new List<HighScore>();

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                highscores.Add(new HighScore("Jeff " + i, rnd.Next(100)));
            }
            //sorts the highscore, using the generic CompareTo method
            highscores.Sort();

            #endregion;

            #region SortinAlgorithms;
            //Creates a new list of random numbers and sorts them
            Console.Clear();

            while (true)
            {

                Console.ReadKey();
                Console.Clear();

                QuickSort.Test();
            }

            Console.ReadKey();
            BubbleSort.Test();

            Console.ReadKey();
            InsertionSort.Test();








            Console.ReadKey();
            //

            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                randomNumbers.Add(rnd.Next(100000));
            }
            FindBiggestNumber.FindBiggestNumberInList(randomNumbers).ToString();
            #endregion;

            #region Graph and pathfinding;

            //add some nodes to the network
            for (int i = 1; i <= 10; i++)
            {
                graph.AddNode("Node #" + i, new Node(i));

            }

            //make connections
            //see image for depiction
            graph.nodes["Node #1"].MakeConnection(graph.nodes["Node #2"], false);
            graph.nodes["Node #1"].MakeConnection(graph.nodes["Node #3"], false);
            graph.nodes["Node #1"].MakeConnection(graph.nodes["Node #4"], false);
            graph.nodes["Node #2"].MakeConnection(graph.nodes["Node #5"], false);
            graph.nodes["Node #5"].MakeConnection(graph.nodes["Node #9"], false);
            graph.nodes["Node #3"].MakeConnection(graph.nodes["Node #6"], false);
            graph.nodes["Node #4"].MakeConnection(graph.nodes["Node #6"], false);
            graph.nodes["Node #4"].MakeConnection(graph.nodes["Node #7"], false);
            graph.nodes["Node #7"].MakeConnection(graph.nodes["Node #8"], false);



            BFS.FindPath(9); //find vej til node nr9

            //reset edges
            foreach (Node node in graph.nodes.Values)
            {
                foreach (Edge edge in node.edges)
                {
                    edge.visited = false;
                }
            }

            DFS.FindPath(9);

            var tmp = graph;
            #endregion;

            Console.ReadKey();
        }


    }





}
