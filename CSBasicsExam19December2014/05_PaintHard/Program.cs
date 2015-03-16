using System;

class PaintBall
{
    static void Main()
    {
        int[] intMatrix = new int[10];
        int shotColor = 0;
        for (int pos = 0; pos < 10; pos++)
        {
            intMatrix[pos] = 1023;
        }
        string shot = "";
        int[] shotParameters = new int[3];
        int startRow = 0;
        int endRow = 9;
        int startIndex = 0;
        int endIndex = 9;

        while (true)
        {
            startRow = 0;
            endRow = 9;
            startIndex = 0;
            endIndex = 9;
            shot = Console.ReadLine();
            if (shot == "End")
            {
                break;
            }
            shotParameters = Array.ConvertAll(shot.Split(' '), int.Parse);
            //check splash size
            if (shotParameters[0] - shotParameters[2] >= 0)
            {
                startRow = shotParameters[0] - shotParameters[2];
            }
            if (shotParameters[0] + shotParameters[2] <= 9)
            {
                endRow = shotParameters[0] + shotParameters[2];
            }
            if (shotParameters[1] - shotParameters[2] >= 0)
            {
                startIndex = shotParameters[1] - shotParameters[2];
            }
            if (shotParameters[1] + shotParameters[2] <= 9)
            {
                endIndex = shotParameters[1] + shotParameters[2];
            }
            //change values
            for (int row = startRow; row <= endRow; row++)
            {
                for (int index = startIndex; index <= endIndex; index++)
                {
                    intMatrix[row] = changeByte(intMatrix[row], index, shotColor);
                }
            }
            //change the color of the ball
            if (shotColor == 1)
            {
                shotColor = 0;
            }
            else
            {
                shotColor = 1;
            }
        }
        //calculate values
        long sum = 0;
        foreach (int x in intMatrix)
        {
            sum += x;
        }
        Console.WriteLine(sum);
    }

    private static int changeByte(int number, int index, int newValue)
    {
        //check value
        int byteValue = (number >> index) & 1;
        if (byteValue == newValue)
        {
            return number;
        }
        else
        {
            if (byteValue == 1)
            {
                number -= (1 << index);
            }
            else
            {
                number += (1 << index);
            }
        }
        return number;
    }
}