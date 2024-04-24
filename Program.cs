using System;

namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 11;
            int b = 10;

            Console.WriteLine($"a:{a}, b:{b}.");
            Swap<int>.MetodSwap(ref a, ref b);

            Console.WriteLine($"a:{a}, b:{b}.");

            Node<string> node1 = new Node<string> { Priority = 1, Name = "first node" };
            Node<string> node2 = new Node<string> { Priority = 2, Name = "second node" };
            Node<string> node3 = new Node<string> { Priority = 3, Name = "third node" };

            QueuePriority<string> queue = new QueuePriority<string> { };

            queue.Show();
            Console.WriteLine();

            queue.Dequeue();
            queue.Show();
            Console.WriteLine();

            queue.Enequeue(node1);
            queue.Enequeue(node2);
            queue.Enequeue(node3);
            queue.Show();
            Console.WriteLine();

            queue.Dequeue();
            queue.Show();
            Console.WriteLine();

            Console.WriteLine($"To queue are {queue.Count()} of nodes.");

            CirclQueue<string> circlQueue = new CirclQueue<string>(6);

            circlQueue.Show();
            circlQueue.Enqueue("RED");
            circlQueue.Enqueue("YELOY");
            circlQueue.Enqueue("GREEN");
            circlQueue.Enqueue("BLUE");
            circlQueue.Enqueue("MAGENTA");
            circlQueue.Enqueue("BLACK");
            circlQueue.Show();
            circlQueue.Enqueue("ORANG");

            circlQueue.Dequeue();
            circlQueue.Show();




            Console.ReadLine();
        }
    }
}
