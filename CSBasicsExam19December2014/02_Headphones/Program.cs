using System;

class Headphones
{
    static void Main()
    {
        int diameter = int.Parse(Console.ReadLine());
        int size = (diameter * 2) + 1;
        int sides = diameter / 2;

        Console.WriteLine("{0}{1}{0}", new string('-', diameter / 2), new string('*', size - (sides * 2)));
        for (int cnt = 0; cnt < diameter; cnt++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', sides), new string('-', diameter));
        }

        int middle = diameter;
        int speakers = 1;
        for (int cnt = 1; cnt < diameter; cnt++)
        {
            if (cnt <= diameter / 2)
            {
                middle -= 2;
                sides--;
                speakers += 2;
            }
            else
            {
                middle += 2;
                sides++;
                speakers -= 2;
            }
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('-', sides), new string('*', speakers), new string('-', middle));
        }
    }
}