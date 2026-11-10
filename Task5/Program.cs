
using System;

class Program
{
        static void PrintMatrix(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write($"{m[i, j],5}");
            }
            Console.WriteLine();
        }
    }

    static int[] FindNegativeRows(int[,] m)
    {
        int[] b = new int[m.GetLength(0)];

        for (int i = 0; i < m.GetLength(0); i++)
        {
            b[i] = 0;

            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (m[i, j] < 0)
                {
                    b[i] = 1;
                    break;
                }
            }
        }

        return b;
    }

    static void Main()
    {
        int nomer = 13;
        int n = 5;
        int[,] matrix = new int[n, n];

Random rnd = new Random(nomer);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rnd.Next(-10, 11);
    }
}

        Console.WriteLine("Матрица:");
        PrintMatrix(matrix);

        int[] b = FindNegativeRows(matrix);

        Console.WriteLine("\nB массиві:");

        for (int i = 0; i < b.Length; i++)
        {
            Console.Write(b[i] + " ");
        }

        Console.WriteLine();
    }
}
