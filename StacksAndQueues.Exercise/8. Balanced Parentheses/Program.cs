using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            string YesOrNo = "YES";

            for (int i = 0; i < sequence.Length; i++)
            {
                char c = sequence[i];
                if (c=='{'||c=='['||c=='(')
                {
                    stack.Push(c);
                }
                else if (c=='}'||c==']'||c==')')
                {
                    if (stack.Count==0)
                    {
                        YesOrNo = "NO";
                        break;
                    }
                    else if (stack.Peek()=='{'&&c!='}')
                    {
                        YesOrNo = "NO";
                        break;
                    }
                    else if (stack.Peek() == '[' && c != ']')
                    {
                        YesOrNo = "NO";
                        break;
                    }
                    else if (stack.Peek()=='(' && c!=')')
                    {
                        YesOrNo = "NO";
                        break;
                    }
                    stack.Pop();
                }
            }
            Console.WriteLine(YesOrNo);
        }
    }
}
