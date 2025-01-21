using System;

class Program
{
    static void Main()
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int[] temp = new int[rows * cols];
        int counter = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                temp[counter++] = a[i, j];
            }
        }
        Array.Sort(temp);
        counter = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                a[i, j] = temp[counter++];
            }
        }

        Console.WriteLine("Отсортированный массив:");
        PrintArray(a);
    }
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
