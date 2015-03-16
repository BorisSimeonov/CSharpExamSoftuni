using System;

class MagicStrings
{
    static void Main()
    {
        int counter = 0;
        int diff = int.Parse(Console.ReadLine());
        for (int fst = 0; fst < 4; fst++)
        {
            for (int snd = 0; snd < 4; snd++)
            {
                for (int trd = 0; trd < 4; trd++)
                {
                    for (int fth = 0; fth < 4; fth++)
                    {
                        for (int fifth = 0; fifth < 4; fifth++)
                        {
                            for (int sxt = 0; sxt < 4; sxt++)
                            {
                                for (int sth = 0; sth < 4; sth++)
                                {
                                    for (int eight = 0; eight < 4; eight++)
                                    {
                                        int firstSum = 0;
                                        int seondSum = 0;
                                        firstSum = getVal(fst) + getVal(snd) + getVal(trd) + getVal(fth);
                                        seondSum = getVal(fifth) + getVal(sxt) + getVal(sth) + getVal(eight);
                                        if (Math.Abs(firstSum - seondSum) == diff)
                                        {
                                            string magicStr = getStr(fst) + getStr(snd) + getStr(trd) + getStr(fth) +
                                                getStr(fifth) + getStr(sxt) + getStr(sth) + getStr(eight);
                                            Console.WriteLine(magicStr);
                                            counter++;
                                        }
                                    }
                                }
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

    private static string getStr(int x)
    {
        string str = "";
        switch (x)
        {
            case 0: str = "k";
                break;
            case 1: str = "n";
                break;
            case 2: str = "p";
                break;
            case 3: str = "s";
                break;
        }
        return str;
    }

    private static int getVal(int p)
    {
        int value = 0;
        switch (p)
        {
            case 0: value = 1;
                break;
            case 1: value = 4;
                break;
            case 2: value = 5;
                break;
            case 3: value = 3;
                break;
        }
        return value;
    }
}