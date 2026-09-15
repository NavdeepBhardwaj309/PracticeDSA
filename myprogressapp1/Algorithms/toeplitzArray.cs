using System;

public static class ToeplitzArray
{
    public static void isToeplitz()
    {
        int rows = 3;
        int cols = 4;
        int[,] matrix = new int[rows, cols];

        Console.WriteLine($"Enter {rows} rows, each with {cols} numbers separated by spaces:");

        // Read matrix from console
        for (int i = 0; i < rows; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(parts[j]);
            }
        }

        // Check Toeplitz
        bool isToeplitz = CheckToeplitz(matrix);
        Console.WriteLine(isToeplitz ? "Matrix is Toeplitz" : "Matrix is NOT Toeplitz");
    }

    static bool CheckToeplitz(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                Console.WriteLine(matrix[i, j]);
                Console.WriteLine(matrix[i + 1, j + 1]);
                if (matrix[i, j] != matrix[i + 1, j + 1])
                    return false;
            }
        }

        return true;
    }
}
