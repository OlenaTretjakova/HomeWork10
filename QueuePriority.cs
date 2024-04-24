using System;
using System.Collections.Generic;

namespace HomeWork10
{
    public struct Node<T>
    {
        public int Priority { get; set; }
        public T Name { get; set; }
    }

    internal class QueuePriority<T>
    {
        public Node<T> Item;
        public List<Node<T>> Queue;
        public QueuePriority()
        {
            Queue = new List<Node<T>>();
        }

        public void Show()
        {
            foreach (var item in Queue)
            {
                if (Queue.Count != 0)
                {
                    Console.Write($"{item.Name}[{item.Priority}] ");
                }
                else
                {
                    Console.WriteLine("Queue is empty.");
                }
            }
        }

        public void Enequeue(Node<T> node)
        {
            Queue.Add(node);
        }

        public void Dequeue()
        {
            if (Queue.Count != 0)
            {
                Queue.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }
        }

        public int Count()
        {
            return Queue.Count;
        }
    }
}
