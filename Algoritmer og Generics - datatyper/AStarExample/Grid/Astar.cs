using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    class Astar
    {
        public static void FindPath(Cell statingCell, Cell goalCell)
        {

            List<Cell> openList = new List<Cell>();// list of nodes to examine  

            List<Cell> ClosedList = new List<Cell>(); //nodes that have been examined

            openList.Add(statingCell); //starting point


            while (openList.Count > 0) //recursively adds neihbouring cells / nodes.
                                       //  Only runs out if there's no possible path
            {

                //Finds the best candidate node (the cheapest and most efficient one)
                Cell currentCell = FindLowestFCost(openList);


                openList.Remove(currentCell); // walkable squares

                ClosedList.Add(currentCell); // has been walked on



                if (currentCell.myType == CellType.GOAL)
                {
                    //found target
                    ReturnPath(statingCell, goalCell); //extracts the found path
                    return;
                }
                //all walkable neighbouring tiles, that are not out of bound
                foreach (Cell neighbour in FindNeighbours(currentCell))
                {
                    if ((neighbour.myType != CellType.EMPTY && neighbour.myType != CellType.GOAL) || ClosedList.Contains(neighbour))
                    {
                        //ignore if obsticle or tile has already been walked on
                        continue;
                    }

                    //calculates the new move cost for this neighbour
                    int newMoveCost = currentCell.gCost + GetDistance(currentCell, neighbour);

                    //if this neighbour is the best route to take
                    if (newMoveCost < neighbour.gCost || !openList.Contains(neighbour))
                    {
                        neighbour.gCost = newMoveCost;

                        neighbour.hCost = GetDistance(neighbour, goalCell);

                        //saves reference for returning path
                        neighbour.parent = currentCell;

                        if (!openList.Contains(neighbour))
                        {
                            openList.Add(neighbour);
                        }
                    }

                }
            }




        }

        static void ReturnPath(Cell start, Cell end)
        {

            Stack<Cell> path = new Stack<Cell>();

            Cell currentNode = end;

            while (currentNode != start)
            {

                path.Push(currentNode);

                currentNode = currentNode.parent;

            }

            // path.Reverse();

            GridManager.pathToEnd = path;


        }

        private static Cell FindLowestFCost(List<Cell> openList)
        {
            Cell currentCell = openList[0];

            for (int i = 0; i < openList.Count; i++)
            {
                if (openList[i].FCost < currentCell.FCost
                    || openList[i].FCost == currentCell.FCost
                    && openList[i].hCost < currentCell.hCost)
                {
                    currentCell = openList[i];
                }
            }
            return currentCell;
        }

        public static List<Cell> FindNeighbours(Cell cell)
        {
            List<Cell> neighbours = new List<Cell>();

            //look at all neighboures in a 3x3 square
        
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        continue;
                    }


                    int XCheck = cell.position.X + x;
                    int YCheck = cell.position.Y + y;

                    if (XCheck >= 0 && XCheck < GridManager.cellRowCount) // x is not out of bounds
                    {
                        if (YCheck >= 0 && YCheck < GridManager.cellRowCount) // same for why
                        {

                            foreach (Cell _cell in GridManager.grid)
                            {
                                //find the cell in the grid list
                                if (_cell.position.X == XCheck && _cell.position.Y == YCheck) 
                                {
                                    neighbours.Add(_cell);
                                    break;

                                }

                            }


                        }
                    }

                }
            }
            return neighbours;


        }

        private static int GetDistance(Cell a, Cell b)
        {
            int xDistance = Math.Abs(a.position.X - b.position.X);
            int yDistance = Math.Abs(a.position.Y - b.position.Y);

            if (xDistance > yDistance)
            {
                return 14 * yDistance + 10 * (xDistance - yDistance);
            }
            return 14 * xDistance + 10 * (yDistance - xDistance);

        }

    }
}
