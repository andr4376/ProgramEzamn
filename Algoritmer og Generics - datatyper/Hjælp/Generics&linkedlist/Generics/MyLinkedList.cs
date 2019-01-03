using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyLinkedList<T> : IEnumerable<T>
    {

        private Node<T> firstNode; 


        public MyLinkedList()
        {
            firstNode = null;
        }

        public Node<T> Last()
        {
            return firstNode;
        }

        public void AddToEnd(T node)
        {
            
            if (firstNode == null)//list is empty
            {
                firstNode = new Node<T>(node);
            }
            else
            {
                
                firstNode.AddToEnd(node);

            }

        }

        

        public void AddToBeginning(T node)
        {

            if (firstNode == null) //if list is empty
            {
                firstNode = new Node<T>(node);//this is the first node

            }
            else
            {
                //puts this node in the beginning and move the previous "First node" a step down

                Node<T> newNode = new Node<T>(node);

                newNode.Next = firstNode;

                firstNode = newNode;
            }


        }

        public void Print()
        {
            if (firstNode != null)
            {
                firstNode.Print();
            }
        }

        /// <summary>
        /// Returns each of the nodes in the "collection"
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = firstNode;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
