using System;

class OddEvenElements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); 
        string userInput = Console.ReadLine();
        string[] strArray = userInput.Split(' ');
        if (userInput == "")
        {
            strArray = new string[0];
        }
        decimal minEven = decimal.MaxValue;
        decimal maxEven = decimal.MinValue;
        decimal sumEven = 0;
        decimal minOdd = decimal.MaxValue;
        decimal maxOdd = decimal.MinValue;
        decimal sumOdd = 0;
        int counter = 0;
        decimal buffer;

        for (int cnt = 1; cnt <= strArray.Length; cnt++ )
        {
            buffer = decimal.Parse(strArray[cnt - 1]);
            if (cnt % 2 == 0)
            {

                minEven = Math.Min(minEven, buffer);
                maxEven = Math.Max(maxEven, buffer);
                sumEven += buffer;
            }
            else
            {
                minOdd = Math.Min(minOdd, buffer);
                maxOdd = Math.Max(maxOdd, buffer);
                sumOdd += buffer;
            }
            counter++;
        }

        if(userInput == "")
        {
            Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum={0}, EvenMin={0}, EvenMax={0}", "No");
        }
        else
        {
             Console.WriteLine(counter >= 2 ? 
        "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}" : 
        "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={6}, EvenMin={6}, EvenMax={6}",
            (double)sumOdd, (double)minOdd, (double)maxOdd, (double)sumEven, (double)minEven, (double)maxEven, "No");
        }
    }
}