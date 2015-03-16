using System;

class Explorer
{
    static void Main()
    {
        int diaSize = int.Parse(Console.ReadLine());
        int space = (diaSize / 2);
        for (int row = 0; row < diaSize; row++)
        {
            for (int col = 0; col < diaSize; col++)
            {
                if (col == space || col == (diaSize - (space + 1)))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
            if (row >= (diaSize / 2))
            {
                space++;
            }
            else
            {
                space--;
            }

        }
    }
}