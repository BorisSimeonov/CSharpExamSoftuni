using System;

class BitKiller
{
    static void Main(string[] args)
    {
        int numsCount = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int userInput;
        int result = 0;
        int outputCount = 0;
        int position = 0;

        for (int cnt = 0; cnt < numsCount; cnt++)
        {
            userInput = int.Parse(Console.ReadLine());
            for (int index = 7; index >= 0; index--)
            {
                if (!((position % step == 1) || (step == 1 && position > 0)))
                {
                    int value = (userInput >> index) & 1;
                    result = result << 1;
                    result = result | value;
                    outputCount++;
                    if (outputCount == 8)
                    {
                        Console.WriteLine(result);
                        result = 0;
                        outputCount = 0;
                    }
                }
                position++;
            }
        }
        if (outputCount > 0)
        {
            result = result << (8 - outputCount);
            Console.WriteLine(result);
        }
    }
}