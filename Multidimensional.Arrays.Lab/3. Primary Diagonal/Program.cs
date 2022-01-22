using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    if (i==j)
                    {
                        sum += numbers[j];
                    }
                    matrix[i, j] = numbers[j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
