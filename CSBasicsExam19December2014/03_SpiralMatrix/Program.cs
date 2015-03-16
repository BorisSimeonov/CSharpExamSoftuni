using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = Console.ReadLine().ToLower();
        char[,] matrix = new char[n, n];
        //---------- End of initialisation
        int row = 0;
        int col = 0;
        int maxValue = n * n;
        string printDirection = "Right";
        int wordPosition = -1;

        for (int count = 1; count <= maxValue; count++)
        {
            if (printDirection == "Right" && (col > n - 1 || matrix[row, col] != 0))
            {
                printDirection = "Down";
                col--;
                row++;
            }
            if (printDirection == "Down" && (row > n - 1 || matrix[row, col] != 0))
            {
                printDirection = "Left";
                row--;
                col--;
            }
            if (printDirection == "Left" && (col < 0 || matrix[row, col] != 0))
            {
                printDirection = "Up";
                row--;
                col++;
            }
            if (printDirection == "Up" && (row < 0 || matrix[row, col] != 0))
            {
                printDirection = "Right";
                row++;
                col++;
            }

            //Assign value
            wordPosition++;
            if (wordPosition == word.Length)
            {
                wordPosition = 0;
            }
            matrix[row, col] = word[wordPosition];
            //Movement
            if (printDirection == "Right")
            {
                col++;
            }
            if (printDirection == "Down")
            {
                row++;
            }
            if (printDirection == "Left")
            {
                col--;
            }
            if (printDirection == "Up")
            {
                row--;
            }
        }

        // Display Matrix
        int maxRowValue = int.MinValue;
        int rowIndex = 0;
        int currentRowValue = 0;

        for (int r = 0; r < n; r++)
        {
            currentRowValue = 0;
            for (int c = 0; c < n; c++)
            {
                currentRowValue += (((int)matrix[r, c] + 1 - ((int)'a')) * 10);
            }
            if (currentRowValue > maxRowValue)
            {
                maxRowValue = currentRowValue;
                rowIndex = r;
            }
        }

        Console.WriteLine("{0} - {1}", rowIndex, maxRowValue);
    }
}