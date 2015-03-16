using System;

class Pairs
{
    static void Main()
    {
        string stringInput = Console.ReadLine();
        string[] strArray = stringInput.Split(' ');
        int[] numArray = new int[strArray.Length];
        numArray = Array.ConvertAll(strArray, int.Parse);
        //check
        int value = numArray[0] + numArray[1];
        int maxPair = value;
        int minPair = value;
        int maxDiff = 0;
        for (int cnt = 2; cnt < numArray.Length - 1; cnt += 2)
        {
            int currentValue = numArray[cnt] + numArray[cnt + 1];
            int difference = Math.Abs(value - currentValue);
            maxDiff = Math.Max(difference, maxDiff);
            value = currentValue;
        }

        Console.WriteLine(maxDiff == 0 ? "Yes, value={0}" : "No, maxdiff={1}",
            value, maxDiff);
    }
}