using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Node<T>
    {
        private T value;
        private Node<T> previous;

        private Node<T> next; // the next node in the "list"

        /// <summary>
        /// When instanciating a new node, the next one is null by default
        /// </summary>
        /// <param name="_value"></param>
        public Node(T _value)
        {
            value = _value;
            next = null;
        }

        public T Value
        {
            get { return value; } //The value of the node (int, string, class, struct)
        }


        public Node<T> Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }


        }

        //public Node AddToNext(object _node)
        //{
        //    next = new Node(_node);

        //    return next;
        //}

        public void Print()
        {
            Console.Write("[" + value + "] ->");

            if (next != null)
            {
                next.Print();
            }
        }

        /// <summary>
        /// Adds a new node to the end of the list
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public void AddToEnd(T node)
        {
            if (next == null) //if this is the last one
            {
                next = new Node<T>(node);
            }
            else
            {
                next.AddToEnd(node);

            }

        }

      
    }
}
