using System;
using System.Collections.Generic;

namespace _6.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> list = new Queue<string>
                ();
            string input = Console.ReadLine();
            while (input.ToLower()!="end")
            {
                if (input.ToLower()=="paid")
                {
                    while (list.Count!=0)
                    {
                        Console.WriteLine(list.Dequeue());
                    }
                }
                else
                {
                    list.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{list.Count} people remaining.");
        }
    }
}
