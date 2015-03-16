using System;

class Program
{
    static void Main()
    {
        int firstTrib = int.Parse(Console.ReadLine());
        int seondTrib = int.Parse(Console.ReadLine());
        int thirdTrib = int.Parse(Console.ReadLine());
        int firstNum = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int fb = firstTrib;
        int sb = seondTrib;
        int tb = thirdTrib;


        bool crossingValue = false;
        int maxMovement = 0;
        if (firstNum == firstTrib || firstNum == seondTrib || firstNum == thirdTrib
            || firstNum == (firstTrib + seondTrib + thirdTrib))
        {
            Console.WriteLine(firstNum);
            crossingValue = true;
        }
        if (!crossingValue)
        {
            while (!crossingValue)
            {
                maxMovement++;
                for (int cnt = 0; cnt < 2; cnt++)
                {
                    firstNum += maxMovement * step;
                    if (firstNum > 1000000)
                    {
                        break;
                    }
                    crossingValue = checkTribonacci(firstTrib, seondTrib, thirdTrib, firstNum);
                    if (crossingValue)
                    {
                        break;
                    }
                    if (firstNum == fb || firstNum == sb || firstNum == tb)
                    {
                        Console.WriteLine(firstNum);
                        crossingValue = true;
                        break;
                    }
                }
                if (crossingValue || firstNum > 1000000)
                {
                    break;
                }
            }
            if (!crossingValue)
            {
                Console.WriteLine("No");
            }
        }
    }

    private static bool checkTribonacci(int firstTrib, int seondTrib, int thirdTrib, int firstNum)
    {
        bool result = false;
        int nextTribNum = -1000001;
        while (firstNum + 1 > nextTribNum)
        {
            nextTribNum = firstTrib + seondTrib + thirdTrib;
            if (firstNum == nextTribNum)
            {
                result = true;
                Console.WriteLine(firstNum);
                break;
            }
            firstTrib = seondTrib;
            seondTrib = thirdTrib;
            thirdTrib = nextTribNum;
        }
        return result;
    }
}