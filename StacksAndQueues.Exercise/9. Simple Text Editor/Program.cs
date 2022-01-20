using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<string> commands = new Stack<string>();
            string text = "";
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0]=="1")
                {
                    string textToAdd = string.Join(" ", input).Remove(0, 2);
                    text += textToAdd;
                    commands.Push("1" + textToAdd);
                }
                else if (input[0] == "2")
                {
                    int num = int.Parse(input[1]);
                    int index = text.Length - num;
                    string textToDel = text.Substring(index, num);
                    text = text.Remove(index, num);
                    commands.Push("2" + textToDel);
                }
                else if (input[0] == "3")
                {
                    int index = int.Parse(input[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else if (input[0] == "4")
                {
                    string command = commands.Pop();
                    if (command[0]=='1')
                    {
                        command = command.Remove(0, 1);
                        int index = text.Length - command.Length;
                        text = text.Remove(index, command.Length);
                    }
                    else if (command[0]=='2')
                    {
                        command = command.Remove(0, 1);
                        text += command;
                    }
                }
            }
        }
    }
}
