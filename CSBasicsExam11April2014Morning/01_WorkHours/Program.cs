using System;

class EXAMWorkHours
{
    static void Main()
    {
        int hourForProject = int.Parse(Console.ReadLine());
        int daysAvaliable = int.Parse(Console.ReadLine());
        double productivityPercent = double.Parse(Console.ReadLine());
        productivityPercent /= 100;
        //--------------
        double hoursAvailable = (daysAvaliable * 0.90) * 12;
        int check = (int)(Math.Floor(hoursAvailable * productivityPercent));
        Console.WriteLine(check >= hourForProject ? "Yes\r\n{0}" : "No\r\n-{0}", Math.Abs(check - hourForProject));
    }
}