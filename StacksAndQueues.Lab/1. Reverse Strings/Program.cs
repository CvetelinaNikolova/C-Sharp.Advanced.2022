using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> word = new Stack<char>();
            foreach (char c in input)
            {
                word.Push(c);
            }
            while (word.Count!=0)
            {
                Console.Write(word.Pop());
            }
        }
    }
}
