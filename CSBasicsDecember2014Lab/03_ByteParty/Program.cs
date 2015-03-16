using System;

class ByteParty
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int[] intArray = new int[numbersCount];
        for (int numsCnt = 0; numsCnt < numbersCount; numsCnt++)
        {
            intArray[numsCnt] = int.Parse(Console.ReadLine());
        }
        string commandInput = "";
        string[] commandArray;
        int bitPosition = 0;
        int bitValue = 0;

        while (true)
        {
            commandInput = Console.ReadLine();
            if (commandInput == "party over")
            {
                break;
            }
            commandArray = commandInput.Split(' ');
            bitPosition = int.Parse(commandArray[1]);
            for (int cnt = 0; cnt < numbersCount; cnt++)
            {
                intArray[cnt] = executeCommand(bitPosition, intArray[cnt], commandArray[0]);
            }
        }
        foreach (int x in intArray)
        {
            Console.WriteLine(x);
        }
    }

    private static int executeCommand(int bitPosition, int number, string command)
    {
        //get byte value from the num
        int numberByteValue = (number >> bitPosition) & 1;
        switch (command)
        {
            case "-1":
                if (numberByteValue == 1)
                {
                    number = number - (1 << bitPosition);
                }
                else
                {
                    number = number + (1 << bitPosition);
                }
                break;
            case "0":
                if (numberByteValue == 1)
                {
                    number = number - (1 << bitPosition);
                }
                break;
            case "1":
                if (numberByteValue == 0)
                {
                    number += (1 << bitPosition);
                }
                break;
        }

        return number;
    }
}