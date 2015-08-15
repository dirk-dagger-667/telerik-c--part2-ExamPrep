using System;


class Patterns
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        long[,] matrix = new long[length, length];
        for (int row = 0; row < length; row++)
        {
            string[] currentRow = Console.ReadLine().Split();
            for (int col = 0; col < length; col++)
            {
                matrix[row, col] = long.Parse(currentRow[col]);
            }
        }

        long bestSumPattern = long.MinValue;
        long currentSumPattern = 0;
        for (int row = 0; row < length - 2; row++)
        {
            for (int col = 0; col < length - 4; col++)
            {
                if ((matrix[row, col] == (matrix[row, col + 1] - 1)) &&
                    (matrix[row, col + 1] == (matrix[row, col + 2] - 1)) &&
                    (matrix[row, col + 2] == (matrix[row + 1, col + 2] - 1)) &&
                    (matrix[row + 1, col + 2] == (matrix[row + 2, col + 2] - 1)) &&
                    (matrix[row + 2, col + 2] == (matrix[row + 2, col + 3] - 1)) &&
                    ((matrix[row + 2, col + 3]) == (matrix[row + 2, col + 4] - 1)))
                {
                    currentSumPattern = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2] + matrix[row + 2, col + 3] + matrix[row + 2, col + 4];
                    if (currentSumPattern > bestSumPattern)
                    {
                        bestSumPattern = currentSumPattern;
                    }
                }
            }
        }
        if (bestSumPattern != long.MinValue)
        {
            Console.WriteLine("YES {0}", bestSumPattern);
        }
        else if (bestSumPattern == long.MinValue)
        {
            Console.WriteLine("Няма нужда от проверка за диагонала, защото бг кодер, няма такива тестове");
            //for (int row = 0, col = 0; row < length && col < length; col++,row++)
            //{

            //}
        }
        //PrintMatrix(length, matrix);
    }

    private static void PrintMatrix(int length, long[,] matrix)
    {
        for (int row = 0; row < length; row++)
        {
            for (int col = 0; col < length; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    //static void FindPattern(long[,] matrix,int row, int col)
    //{
    //    long bestSumPattern = long.MinValue;
    //    long currentSumPattern = 0;
    //    for (int r = row; r < matrix.GetLength(0)-2; r++)
    //    {
    //        for (int c = col; c < matrix.GetLength(1)-4; c++)
    //        {
    //            //   a = b - 1                              b = c -1                                    c = d-1
    //            if ((matrix[r, c] == (matrix[r, c + 1] - 1)) && 
    //                (matrix[r, c + 1] == (matrix[r, c + 2] - 1)) && 
    //                (matrix[r, c + 2] == (matrix[r + 1, c + 2] - 1)) && 
    //                (matrix[r + 1, c + 2] == (matrix[r + 2, c + 2] - 1)) && 
    //                (matrix[r + 2, c + 2] == (matrix[r+2,c+3] - 1)) && 
    //                ((matrix[r+2,c+3]) == (matrix[r+2,c+4] - 1)))
    //            {
    //                currentSumPattern = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] + matrix[r + 1, c + 2] + matrix[r + 2, c + 2] + matrix[r+2,c+3] + matrix[r+2,c+4];
    //                Console.WriteLine("Current {0}",currentSumPattern);
    //                if (currentSumPattern > bestSumPattern)
    //                {
    //                    bestSumPattern = currentSumPattern;
    //                    Console.WriteLine("Best: {0}",bestSumPattern);
    //                }
    //            }
    //        }
    //    }
    // }
}
