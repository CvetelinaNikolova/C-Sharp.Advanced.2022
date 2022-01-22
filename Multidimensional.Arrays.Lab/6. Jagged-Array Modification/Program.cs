using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] info = input.Split(" ");
                string command = info[0];
                int x = int.Parse(info[1]);
                int y = int.Parse(info[2]);
                int num = int.Parse(info[3]);

                if ((x>=0&&x<matrixSize)&&(y>=0&&y<matrixSize))
                {
                    if (command=="Add")
                    {
                        matrix[x, y] += num;
                    }
                    else if (command=="Subtract")
                    {
                        matrix[x, y] -= num;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j==matrixSize-1)
                    {
                        Console.Write($"{matrix[i,j]}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write($"{matrix[i,j]} ");
                    }
                }
            }
        }
    }
}
