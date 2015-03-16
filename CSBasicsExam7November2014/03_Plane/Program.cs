using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //head
        Console.WriteLine("{0}*{0}", new string('.', n + (n / 2)));
        int middleSpace = 1;
        int sideSpace = n + ((n / 2) - 1);

        for (int cnt = 0; cnt < n - ((n / 2) - 1); cnt++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', sideSpace), new string('.', middleSpace));
            middleSpace += 2;
            sideSpace--;
        }

        middleSpace += 2;
        sideSpace--;
        for (int cnt = 1; cnt < n / 2; cnt++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', sideSpace), new string('.', middleSpace));
            middleSpace += 4;
            sideSpace -= 2;
        }
        //middle
        middleSpace = n;
        sideSpace = middleSpace - 2;
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', sideSpace), new string('.', middleSpace));

        int innerSide = sideSpace - 2;
        sideSpace = 1;
        for (int cnt = 0; cnt < (n - 2) / 2; cnt++)
        {
            Console.WriteLine("*{2}*{1}*{0}*{1}*{2}*", new string('.', middleSpace),
                new string('.', sideSpace), new string('.', innerSide));
            sideSpace += 2;
            innerSide -= 2;
        }
        //tail
        sideSpace = n - 1;
        for (int cnt = 0; cnt < n - 1; cnt++)
        {
            Console.WriteLine("{1}*{0}*{1}", new string('.', middleSpace), new string('.', sideSpace));
            sideSpace--;
            middleSpace += 2;
        }
        Console.WriteLine("{0}", new string('*', n * 3));
    }
}