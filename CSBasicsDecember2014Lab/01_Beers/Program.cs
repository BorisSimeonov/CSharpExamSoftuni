using System;

class Beers
{
    static void Main()
    {
        string[] userInput = new string[2];
        int beersCount = 0;
        int stacksCount = 0;
        while (true)
        {
            userInput = Console.ReadLine().Split(' ');
            if (userInput[0] == "End")
            {
                break;
            }
            if (userInput[1] == "stacks")
            {
                beersCount += (int.Parse(userInput[0]) * 20);
            }
            else
            {
                beersCount += int.Parse(userInput[0]);
            }
        }
        stacksCount = beersCount / 20;
        beersCount = beersCount % 20;
        Console.WriteLine("{0} stacks + {1} beers", stacksCount, beersCount);
    }
}