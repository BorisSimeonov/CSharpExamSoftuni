using System;

class Budget
{
    static void Main()
    {
        int money = int.Parse(Console.ReadLine());
        int weekDaysOut = int.Parse(Console.ReadLine());
        int weekendHome = int.Parse(Console.ReadLine());
        int moneyNeeded = 0;
        int weekends = 4 - weekendHome;
        int weekdays = 22 - weekDaysOut;
        double percent = (money * 0.03);

        moneyNeeded = ((weekends * 2) * 20) + (weekdays * 10) + (weekDaysOut * (int)(10 + percent)) + 150;
        if (money >= moneyNeeded)
        {
            Console.WriteLine(money == moneyNeeded ? "Exact Budget." : "Yes, leftover {0}.", money - moneyNeeded);
        }
        else
        {
            Console.WriteLine("No, not enough {0}.", moneyNeeded - money);
        }
    }
}