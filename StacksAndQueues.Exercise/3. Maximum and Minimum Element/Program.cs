using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int command = input.Split().Select(int.Parse).First();

                if (command==1)
                {
                    int num = input.Split().Select(int.Parse).Last();
                    stack.Push(num);
                }
                else if (command==2)
                {
                    stack.Pop();
                }
                else if (command==3)
                {
                    if (stack.Count>0)
                    {
                        int max = int.MinValue;
                        foreach (var item in stack)
                        {
                            if (item > max)
                            {
                                max = item;
                            }
                        }
                        Console.WriteLine(max);
                    }
                }
                else if (command==4)
                {
                    if (stack.Count>0)
                    {
                        int min = int.MaxValue;
                        foreach (var item in stack)
                        {
                            if (item<min)
                            {
                                min = item;
                            }
                        }
                        Console.WriteLine(min);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
