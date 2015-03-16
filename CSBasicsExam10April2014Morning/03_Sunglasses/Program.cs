using System;

class Program
{
    static void Main()
    {
        int glassSize = int.Parse(Console.ReadLine());
        char frame = '*';
        char bridge = '|';
        char lenses = '/';
        char freeSpace = ' ';
        //printing
        for (int row = 1; row <= glassSize; row++)
        {
            for (int col = 1; col <= glassSize * 5; col++)
            {
                if ((row == 1 || row == glassSize) && (col <= glassSize * 2 || col > glassSize * 3))
                {
                    Console.Write(frame);
                    continue;
                }
                else if (col == 1 || col == glassSize * 2 || col == (glassSize * 3) + 1 || col == glassSize * 5)
                {
                    Console.Write("*");
                    continue;
                }
                else if (col > glassSize * 2 && col <= glassSize * 3)
                {
                    Console.Write(row == (glassSize / 2) + 1 ? bridge : freeSpace);
                }
                else
                {
                    Console.Write(lenses);
                }
            }
            Console.WriteLine();
        }
    }
}