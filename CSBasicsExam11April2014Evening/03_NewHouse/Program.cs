using System;

class Program
{
    static void Main()
    {
        int houseSize = int.Parse(Console.ReadLine());
        int roofHight = (houseSize / 2) + 1;
        int middle = 1;
        int sides = houseSize / 2;
        for (int cnt = 0; cnt < roofHight; cnt++)
        {
            Console.WriteLine("{1}{0}{1}", new string('*', middle), new string('-', sides));
            middle += 2;
            sides--;
        }
        middle = houseSize - 2;
        for (int cnt = 0; cnt < houseSize; cnt++)
        {
            Console.WriteLine("|{0}|", new string('*', middle));
        }
    }
}