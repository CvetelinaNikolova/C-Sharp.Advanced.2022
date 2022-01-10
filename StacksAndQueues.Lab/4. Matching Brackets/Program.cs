using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().Where(x=>x!=' ').ToArray();
            string expession = string.Join("", input);

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < expession.Length; i++)
            {
                if (expession[i]=='(')
                {
                    stack.Push(i);
                }
                else if (expession[i]==')')
                {
                    int startIndex = stack.Pop();
                    int letters = i - startIndex + 1;
                    Console.WriteLine(expession.Substring(startIndex,letters));
                }
            }
        }
    }
}
