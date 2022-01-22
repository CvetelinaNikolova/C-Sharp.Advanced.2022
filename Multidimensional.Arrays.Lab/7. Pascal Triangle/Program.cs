using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[,] matrix = new long[n, n];


                for (int i = 0; i < n; i++)
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        if (j == n - 1 || (j == 0 && matrix[i, j] != 0))
                        {
                            matrix[i, j] = 1;
                        }
                        else if (i > 0)
                        {
                            matrix[i, j] = matrix[i - 1, j] + matrix[i - 1, j + 1];
                        }
                    }
                }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        if (j == n - 1)
                        {
                            Console.Write($"{matrix[i, j]}");
                            if (i != n - 1)
                            {
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                    }
                }
            }
        }
    }
}

