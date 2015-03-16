using System;

class pDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        int pointer = 3;
        string direction = "out";
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= 7; col++)
            {
                if (col > pointer && col <= 7 - pointer)
                {
                    if (ch > (char)71)
                    {
                        ch = (char)65;
                    }
                    Console.Write(ch);
                    ch++;
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            if (pointer == 0)
            {
                direction = "in";
            }

            if (pointer == 3 && row % 7 < 1 && row != 1)
            {
                continue;
            }
            if (pointer == 3)
            {
                direction = "out";
            }
            //
            if (direction == "out")
            {
                pointer--;
            }
            if (direction == "in")
            {
                pointer++;
            }
        }
    }
}