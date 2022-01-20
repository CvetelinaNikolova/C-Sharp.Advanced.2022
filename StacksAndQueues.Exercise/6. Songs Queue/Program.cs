using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));

            while (songs.Count!=0)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command=="Play")
                {
                    songs.Dequeue();
                }
                else if (command=="Show")
                {
                    for (int i = 0; i < songs.Count; i++)
                    {
                        if (i==songs.Count-1)
                        {
                            string song = songs.Dequeue();
                            Console.Write(song);
                            songs.Enqueue(song);
                            continue;
                        }
                        else
                        {
                            string song = songs.Dequeue();
                            Console.Write($"{song}, ");
                            songs.Enqueue(song);
                        }
                    }
                    Console.WriteLine();
                }
                else if (command=="Add")
                {
                    string[] songName = new string[input.Count() - 1];
                    for (int i = 1; i < input.Length; i++)
                    {
                        songName[i - 1] = input[i];
                    }
                    string song = string.Join(" ", songName);
                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
