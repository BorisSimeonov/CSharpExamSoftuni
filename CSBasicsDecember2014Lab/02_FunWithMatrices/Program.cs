using System;

class FunWithMatrices
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
        new System.Globalization.CultureInfo("en-US");

        double[,] dblMatrix = new double[4, 4];
        double startNum = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());
        string command = "";
        string[] commandArray = new string[4];
        int rowPos = 0;
        int colPos = 0;
        double manipulationValue = 0d;
        //assign values to the matrix
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                dblMatrix[row, col] = startNum;
                startNum += step;
            }
        }
        //execute commands
        while (true)
        {
            command = Console.ReadLine();
            //end the user data stream
            if (command == "Game Over!")
            {
                break;
            }
            commandArray = command.Split(' ');
            rowPos = int.Parse(commandArray[0]);
            colPos = int.Parse(commandArray[1]);
            manipulationValue = double.Parse(commandArray[3]);
            switch (commandArray[2])
            {
                case "multiply":
                    dblMatrix[rowPos, colPos] *= manipulationValue;
                    break;
                case "sum":
                    dblMatrix[rowPos, colPos] += manipulationValue;
                    break;
                case "power":
                    dblMatrix[rowPos, colPos] = Math.Pow(dblMatrix[rowPos, colPos], manipulationValue);
                    break;
            }
        }

        double maxSum = double.MinValue;
        double currentSum = 0;
        string maxLineName = "";
        //check row value
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                currentSum += dblMatrix[row, col];
            }
            if (maxSum < currentSum)
            {
                maxSum = Math.Max(maxSum, currentSum);
                maxLineName = "ROW[" + row + "]";
            }
            currentSum = 0;
        }
        //check columns
        for (int col = 0; col < 4; col++)
        {
            for (int row = 0; row < 4; row++)
            {
                currentSum += dblMatrix[row, col];
            }
            if (maxSum < currentSum)
            {
                maxSum = Math.Max(maxSum, currentSum);
                maxLineName = "COLUMN[" + col + "]";
            }
            currentSum = 0;
        }
        //check left diagonal
        for (int iteration = 0; iteration < 4; iteration++)
        {
            currentSum += dblMatrix[iteration, iteration];
        }
        if (currentSum > maxSum)
        {
            maxSum = Math.Max(currentSum, maxSum);
            maxLineName = "LEFT-DIAGONAL";
        }
        currentSum = 0;
        //check Right Diagonal
        for (int row = 3, col = 0; row >= 0; )
        {
            currentSum += dblMatrix[row, col];
            row--;
            col++;
        }
        if (currentSum > maxSum)
        {
            maxSum = Math.Max(currentSum, maxSum);
            currentSum = 0;
            maxLineName = "RIGHT-DIAGONAL";
        }
        //display
        Console.WriteLine("{0} = {1:f2}", maxLineName, maxSum);
    }
}