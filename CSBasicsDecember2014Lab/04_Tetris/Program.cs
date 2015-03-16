using System;

class Tetris
{
    static void Main()
    {
        string[] rowCol = Console.ReadLine().Split(' ');
        int[] rowColsInt = Array.ConvertAll(rowCol, int.Parse);
        string[,] strMatrix = new string[rowColsInt[0], rowColsInt[1]];
        string rowInput = "";
        int iCount = 0;
        int lCount = 0;
        int jCount = 0;
        int oCount = 0;
        int zCount = 0;
        int sCount = 0;
        int tCount = 0;


        for (int row = 0; row < rowColsInt[0]; row++)
        {
            rowInput = Console.ReadLine();
            for (int col = 0; col < rowColsInt[1]; col++)
            {
                strMatrix[row, col] = rowInput[col].ToString();
            }
        }

        //check I
        if (rowColsInt[0] >= 4)
        {
            for (int row = 0; row <= rowColsInt[0] - 4; row++)
            {
                for (int col = 0; col < rowColsInt[1]; col++)
                {
                    if (strMatrix[row, col] == "o" && strMatrix[row + 1, col] == "o" &&
                        strMatrix[row + 2, col] == "o" && strMatrix[row + 3, col] == "o")
                    {
                        iCount++;
                    }
                }
            }
        }

        if (rowColsInt[1] > 2)
        {
            //check l
            for (int row = 0; row <= rowColsInt[0] - 3; row++)
            {
                for (int col = 0; col < rowColsInt[1] - 1; col++)
                {
                    if (strMatrix[row, col] == "o" && strMatrix[row + 1, col] == "o" &&
                        strMatrix[row + 2, col] == "o" && strMatrix[row + 2, col + 1] == "o")
                    {
                        lCount++;
                    }
                }
            }
            //check j
            for (int row = 0; row <= rowColsInt[0] - 3; row++)
            {
                for (int col = 1; col < rowColsInt[1]; col++)
                {
                    if (strMatrix[row, col] == "o" && strMatrix[row + 1, col] == "o" &&
                        strMatrix[row + 2, col] == "o" && strMatrix[row + 2, col - 1] == "o")
                    {
                        jCount++;
                    }
                }
            }
        }

        if (rowColsInt[0] > 2)
        {
            //check z
            for (int row = 0; row <= rowColsInt[0] - 2; row++)
            {
                for (int col = 0; col < rowColsInt[1] - 2; col++)
                {
                    if (strMatrix[row, col] == "o" && strMatrix[row, col + 1] == "o" &&
                        strMatrix[row + 1, col + 1] == "o" && strMatrix[row + 1, col + 2] == "o")
                    {
                        zCount++;
                    }
                }
            }
            //check s
            for (int row = 0; row <= rowColsInt[0] - 2; row++)
            {
                for (int col = 0; col < rowColsInt[1] - 2; col++)
                {
                    if (strMatrix[row + 1, col] == "o" && strMatrix[row + 1, col + 1] == "o" &&
                        strMatrix[row, col + 1] == "o" && strMatrix[row, col + 2] == "o")
                    {
                        sCount++;
                    }
                }
            }
            //check t
            for (int row = 0; row <= rowColsInt[0] - 2; row++)
            {
                for (int col = 0; col < rowColsInt[1] - 2; col++)
                {
                    if (strMatrix[row, col] == "o" && strMatrix[row, col + 1] == "o" &&
                        strMatrix[row, col + 2] == "o" && strMatrix[row + 1, col + 1] == "o")
                    {
                        tCount++;
                    }
                }
            }
        }
        //check o
        for (int row = 0; row <= rowColsInt[0] - 2; row++)
        {
            for (int col = 0; col < rowColsInt[1] - 1; col++)
            {
                if (strMatrix[row, col] == "o" && strMatrix[row, col + 1] == "o" &&
                    strMatrix[row + 1, col] == "o" && strMatrix[row + 1, col + 1] == "o")
                {
                    oCount++;
                }
            }
        }


        Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}",
            iCount, lCount, jCount, oCount, zCount, sCount, tCount);
    }
}