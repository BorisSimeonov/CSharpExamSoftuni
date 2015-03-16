using System;

class BitSifting
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        int iterations = int.Parse(Console.ReadLine());
        long buffer = 0;
        int count = 0;
        long siftNum = 0;
        if (iterations > 0)
        {
            for (int cnt = 0; cnt < iterations; cnt++)
            {
                siftNum = siftNum | long.Parse(Console.ReadLine());
            }
            for (int bit = 63; bit >= 0; bit--)
            {
                if (((num >> bit) & 1) == 1 && ((siftNum >> bit) & 1) == 0)
                {
                    count++;
                    buffer += (long)(1 << bit);
                }
            }
            Console.WriteLine(count);
        }
        else
        {
            for (int bit = 0; bit <= 63; bit++)
            {
                if (((num >> bit) & 1) == 1 && ((siftNum >> bit) & 1) == 0)
                {
                    buffer += (long)(1 << bit);
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}