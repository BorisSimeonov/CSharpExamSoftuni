using System;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        long sum = 0;
        int counter = 0;
        string charStr = "";

        for (char chOne = 'a'; chOne <= 'e'; chOne++)
        {
            for (char chTwo = 'a'; chTwo <= 'e'; chTwo++)
            {
                for (char chThree = 'a'; chThree <= 'e'; chThree++)
                {
                    for (char chFour = 'a'; chFour <= 'e'; chFour++)
                    {
                        for (char chFive = 'a'; chFive <= 'e'; chFive++)
                        {
                            charStr = "" + chOne + chTwo + chThree + chFour + chFive;
                            sum = getSum(charStr);
                            if (sum >= start && sum <= end)
                            {
                                Console.Write("{0} ", charStr);
                                counter++;
                            }
                        }
                    }
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static long getSum(string charStr)
    {
        string newStr = "";
        char getChar;
        bool hasMatch;
        long sum = 0;

        for (int cnt = 0, multy = 1; cnt < 5; cnt++)
        {
            hasMatch = false;
            getChar = charStr[cnt];
            foreach (char x in newStr)
            {
                if (x == getChar)
                {
                    hasMatch = true;
                }
            }
            if (!hasMatch)
            {
                newStr += getChar;
                sum += multy * value(getChar);
                multy++;
            }
        }
        return sum;
    }


    private static int value(char position)
    {
        int val = 0;
        switch (position)
        {
            case 'a':
                val = 5;
                break;
            case 'b':
                val = -12;
                break;
            case 'c':
                val = 47;
                break;
            case 'd':
                val = 7;
                break;
            case 'e':
                val = -32;
                break;
        }
        return val;
    }
}