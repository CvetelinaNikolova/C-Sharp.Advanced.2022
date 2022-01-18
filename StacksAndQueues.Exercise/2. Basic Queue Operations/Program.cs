using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            int numbersToEnqueue = elements[0];
            int numbersToDequeue = elements[1];
            int element = elements[2];

            for (int i = 0; i < numbersToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }


            for (int i = 0; i < numbersToDequeue; i++)
            {
                queue.Dequeue();
            }

            int smallestNum = int.MaxValue;
            foreach (var item in queue)
            {
                if (item<smallestNum)
                {
                    smallestNum = item;
                }
            }


            if (queue.Contains(element))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count>0)
            {
                Console.WriteLine(smallestNum);
            }
            else if (queue.Count==0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
