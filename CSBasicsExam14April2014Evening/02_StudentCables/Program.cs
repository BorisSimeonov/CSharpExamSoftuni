using System;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int joinedLength = 0;
        int cableCount = 0;
        for (int index = 0; index < n; index++)
        {
            int length = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (measure == "meters")
            {
                length *= 100;
                joinedLength += length;
                cableCount++;
            }

            if (length >= 20 && measure == "centimeters")
            {
                joinedLength += length;
                cableCount++;
            }
        }
        joinedLength = joinedLength - (cableCount - 1) * 3;
        Console.WriteLine("{0}\r\n{1}", joinedLength / 504, joinedLength % 504);
    }
}