using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        char isLeap = char.Parse(Console.ReadLine());
        int hollydays = int.Parse(Console.ReadLine());
        int weeksHome = int.Parse(Console.ReadLine());
        //calcualtions
        Console.WriteLine(isLeap == 't' ? "{0}" : "{1}",
            (int)(((double)hollydays / 2) + (weeksHome) + ((double)(52 - weeksHome) * 2) / 3) + 3,
             (int)(((double)hollydays / 2) + (weeksHome) + ((double)(52 - weeksHome) * 2) / 3));
    }
}