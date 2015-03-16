using System;

class Program
{
    static void Main()
    {
        int setCount = int.Parse(Console.ReadLine());
        int numCount = int.Parse(Console.ReadLine());
        string numType = Console.ReadLine();
        int highestCount = 0;
        int highestSet = 0;
        string setName = "";

        for (int set = 0; set < setCount; set++)
        {
            int countBuffer = 0;
            for (int num = 0; num < numCount; num++)
            {
                int numberBuffer = int.Parse(Console.ReadLine());
                if (numType == "odd" && numberBuffer % 2 != 0)
                {
                    countBuffer++;
                }
                else if (numType == "even" && numberBuffer % 2 == 0)
                {
                    countBuffer++;
                }
            }

            if (countBuffer > highestCount)
            {
                highestCount = countBuffer;
                highestSet = set;
            }
        }
        //visualization
        setName = getSetName(highestSet);
        if (highestCount != 0)
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", setName, numType, highestCount);
        }
        else
        {
            Console.WriteLine("No");
        }

    }

    private static string getSetName(int highestSet)
    {
        string x = "";
        switch (highestSet)
        {
            case 0: x = "First";
                break;
            case 1: x = "Second";
                break;
            case 2: x = "Third";
                break;
            case 3: x = "Fourth";
                break;
            case 4: x = "Fifth";
                break;
            case 5: x = "Sixth";
                break;
            case 6: x = "Seventh";
                break;
            case 7: x = "Eighth";
                break;
            case 8: x = "Ninth";
                break;
            case 9: x = "Tenth";
                break;
        }
        return x;
    }
}