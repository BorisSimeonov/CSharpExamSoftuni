using System;

class BitInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        short[] num = new short[n];
        int pos = 7;
        for (int index = 0; index < n; index++)
        {
            num[index] = byte.Parse(Console.ReadLine());
            for (; ; )
            {
                if (pos >= 0)
                {
                    num[index] = changeValue(num[index], pos);
                    pos -= step;
                }
                else
                {
                    pos += 8;
                    break;
                }
            }
            ////////////
        }
        foreach (int x in num)
        {
            Console.WriteLine(x);
        }
    }

    private static short changeValue(short num, int pos)
    {
        if ((num & (1 << pos)) != 0)
        {
            num -= (short)(1 << pos);
        }
        else
        {
            num += (short)(1 << pos);
        }
        return num;
    }
}