using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    internal class CirclQueue <T>
    {
        public int FirstIndex  { get; set; }
        public int LastIndex { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }

        public List<T> List;
        public CirclQueue(int capacity)
        {
            FirstIndex = 0;
            LastIndex = -1;
            Count = 0;
            Capacity = capacity;
            List = new List<T>(Capacity);
        }

        public void Show()
        {
            if (Count != 0)
            {
                Console.WriteLine($"CirclQueue: first index:{FirstIndex}, last index:{LastIndex}, capasity:{Capacity}, size:{Count}");
                foreach (var item in List)
                {
                        Console.Write(item + "\t");

                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("CirclQueue is empty.");
            }
        }

        public void Enqueue (T value)
        { 
            if (Count<Capacity )
            {
                List.Add(value);
                Count++;
                LastIndex++;
                
            }
            else
            {
                Console.WriteLine("CirclQueue is full.");
            }
        }

        public void Dequeue()
        {
            if(Count>0)
            {
                List.RemoveAt(FirstIndex);
            }
            else
            {
                Console.WriteLine("CirclQueue is empty.");
            }
        }
    }
}
