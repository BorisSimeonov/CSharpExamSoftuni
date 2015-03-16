using System;

class MagicDates
{
    static void Main(string[] args)
    {
        DateTime startDate = new DateTime(int.Parse(Console.ReadLine()), 01, 01);
        DateTime endDate = new DateTime(int.Parse(Console.ReadLine()), 12, 31);
        int magicSum = int.Parse(Console.ReadLine());
        bool hasMagicDates = false;
        string currnetDate;
        int currentSum;
        while (startDate <= endDate)
        {
            currnetDate = "" + startDate.Day + startDate.Month + startDate.Year;
            currnetDate = currnetDate.Replace("0", String.Empty);
            currentSum = 0;
            for (int index = 0; index < currnetDate.Length - 1; index++)
            {
                for (int indexTwo = index + 1; indexTwo < currnetDate.Length; indexTwo++)
                {
                    currentSum += (
                        (int.Parse(currnetDate[index].ToString()) *
                        int.Parse(currnetDate[indexTwo].ToString()))
                        );
                }
            }
            if (currentSum == magicSum)
            {
                Console.WriteLine("{0:dd-MM-yyyy}", startDate);
                hasMagicDates = true;
            }
            startDate = startDate.AddDays(1);
        }
        if (!hasMagicDates)
        {
            Console.WriteLine("No");
        }
    }
}