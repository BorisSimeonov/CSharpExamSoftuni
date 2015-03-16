using System;

class BitFlipper
{
    static void Main()
    {
        int length = 62;
        ulong num = ulong.Parse(Console.ReadLine());
        ulong bitCheckValue = 7; //binary - 0111

        while (length > 0)
        {
            length--;
            ulong checker = (num >> length) & 7;
            if (checker == 0 || checker == 7)
            {
                num = ((bitCheckValue << length) ^ num);
                length -= 2;
            }
        }
        Console.WriteLine(num);
    }
}