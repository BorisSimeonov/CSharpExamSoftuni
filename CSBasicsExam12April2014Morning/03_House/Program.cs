using System;

class House
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int halfSize = size / 2;
        int sides = halfSize - 1;
        int middle = 1;

        for (int cnt = 0; cnt <= halfSize; cnt++)
        {
            if (cnt != 0 && cnt != halfSize)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', sides), new string('.', middle));
                sides--;
                middle += 2;
            }
            else
            {
                Console.WriteLine(cnt == 0 ? "{0}*{0}" : "{1}",
                    new string('.', halfSize), new string('*', size));
            }
        }

        sides = size / 4;
        middle = size - ((sides * 2) + 2);
        for (int cnt = 0; cnt < halfSize; cnt++)
        {
            Console.WriteLine(cnt != halfSize - 1 ? "{0}*{1}*{0}" : "{0}{2}{0}",
                new string('.', sides), new string('.', middle), new string('*', middle + 2));
        }
    }
}