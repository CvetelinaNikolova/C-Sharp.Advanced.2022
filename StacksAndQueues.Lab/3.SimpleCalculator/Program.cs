using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputt = Console.ReadLine().Where(x=>x!=' ').ToArray();
            string input = string.Join("", inputt);
            Stack<int> stack = new Stack<int>();
            int result = 0;
            char symbol = ' ';
            for (int i = 0; i <= input.Length; i++)
            {
                if (i == 0)
                {
                    for (int j = i; j < input.Length; j++)
                    {
                        if (input[j] == '+' || input[j] == '-')
                        {
                            i = j;
                            break;
                        }
                    }
                    int num = Convert.ToInt32(input.Substring(0, i));
                    result += num;
                }
                else if (stack.Count == 0)
                {
                    stack.Push(i);
                    symbol = input[i - 1];
                }
                else if (stack.Count>0)
                {
                    int startIndex = stack.Pop();
                    int count = 0;
                    int Iis = 0;
                    if (i + 1 > input.Length)
                    {
                        count = 1;
                    }
                    else
                    {
                        for (int j = i; j <= input.Length; j++)
                        {
                            count++;
                            if (j < input.Length)
                            {

                                if (input[j] == '+' || input[j] == '-')
                                {
                                    Iis = j;
                                    break;
                                }
                            }
                            Iis = j;
                        }

                        i = Iis;
                    }
                    int num = Convert.ToInt32(input.Substring(startIndex, count));
                    if (symbol=='+')
                    {
                        result += num;
                    }
                    else
                    {
                        result -= num;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
