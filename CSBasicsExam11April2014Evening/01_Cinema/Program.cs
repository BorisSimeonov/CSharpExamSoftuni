using System;

class Program
{
    static void Main()
    {
        string projectionType = Console.ReadLine();
        int rowsCount = int.Parse(Console.ReadLine());
        int colsCount = int.Parse(Console.ReadLine());
        int allSeats = rowsCount * colsCount;
        double income = new double();
        //
        switch (projectionType)
        {
            case "Premiere": income = allSeats * 12;
                break;
            case "Normal": income = allSeats * 7.50;
                break;
            case "Discount": income = allSeats * 5;
                break;
        }
        Console.WriteLine("{0:f2} leva", income);
    }
}