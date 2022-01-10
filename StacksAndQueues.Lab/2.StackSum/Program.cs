using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numStack = new Stack<int>(nums);
            string command = Console.ReadLine();
            while (command.ToLower()!="end")
            {
                string[] commands = command.ToLower().Split(" ");
                if (commands[0]=="add")
                {
                    numStack.Push(Convert.ToInt32(commands[1]));
                    numStack.Push(Convert.ToInt32(commands[2]));
                }
                else if (commands[0]=="remove")
                {
                    int n = Convert.ToInt32(commands[1]);
                    if (numStack.Count>=n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            numStack.Pop();
                        }
                    }
                }
                command = Console.ReadLine();
            }
            int result = 0;
            while (numStack.Count!=0)
            {
                result += numStack.Pop();
            }
            Console.WriteLine($"Sum: {result}");
        }
    }
}
