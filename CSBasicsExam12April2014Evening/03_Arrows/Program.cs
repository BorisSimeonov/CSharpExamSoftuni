using System;

class Arrow
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int sides = size / 2;
        for (int cnt = 0; cnt < size - 1; cnt++)
        {
            Console.WriteLine(cnt != 0 ? "{0}#{1}#{0}" : "{0}{2}{0}",
                new string('.', sides), new string('.', size - 2), new string('#', size));
        }
        Console.WriteLine("{0}{1}{0}", new string('#', sides + 1), new string('.', size - 2));
        sides = 1;
        int middle = (size + (size / 2) * 2) - 4;
        for (int cntTwo = 1; cntTwo < size - 1; cntTwo++, sides++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', sides), new string('.', middle));
            middle -= 2;
        }
        Console.WriteLine("{0}#{0}", new string('.', size - 1));
    }
}