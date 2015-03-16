using System;

class TravellerBob
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());
        double contrTravels = 0;
        double familyTravels = 0;
        double normalTravels = (double)(12 - (contractMonths + familyMonths));
        double leap = 0;
        double total = 0;

        contrTravels = 12 * contractMonths;
        familyTravels = 4 * familyMonths;
        normalTravels = ((12 * normalTravels) / 5) * 3;
        total = contrTravels + normalTravels + familyTravels;

        if (yearType == "leap")
        {
            leap = total * 0.05d;
            total += leap;
        }

        Console.WriteLine((int)total);
    }
}