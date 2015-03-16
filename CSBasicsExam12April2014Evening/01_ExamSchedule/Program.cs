using System;

class ExamSchedule
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string dayPart = Console.ReadLine();
        int hoursLength = int.Parse(Console.ReadLine());
        int minutesLength = int.Parse(Console.ReadLine());

        if (dayPart == "PM" && hours < 12)
        {
            hours += 12;
        }
        DateTime startTime = new DateTime(1, 1, 1, hours, minutes, 0);
        startTime = startTime.AddHours(hoursLength);
        startTime = startTime.AddMinutes(minutesLength);

        Console.WriteLine("{0:hh:mm:tt}", startTime);
    }
}