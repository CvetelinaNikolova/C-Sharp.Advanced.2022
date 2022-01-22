using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];

            for (int i = 0; i < matrixSizes[0]; i++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrixSizes[1]; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int biggestSum = 0;

            int[,] biggestMatrix = new int[2, 2];

            for (int i = 0; i < matrixSizes[0]-1; i++)
            {
                for (int j = 0; j < matrixSizes[1]-1; j++)
                {
                    int first = matrix[i, j];
                    int second = matrix[i, j + 1];
                    int third = matrix[i + 1, j];
                    int fourth = matrix[i + 1, j + 1];
                    int sum = first + second + third + fourth;
                    if (sum>biggestSum)
                    {
                        biggestSum = sum;
                        biggestMatrix[0, 0] = first;
                        biggestMatrix[0, 1] = second;
                        biggestMatrix[1, 0] = third;
                        biggestMatrix[1, 1] = fourth;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j==2-1)
                    {
                        Console.Write($"{biggestMatrix[i,j]}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write($"{biggestMatrix[i,j]} ");
                    }
                }
            }
            Console.WriteLine(biggestSum);
        }
    }
}
