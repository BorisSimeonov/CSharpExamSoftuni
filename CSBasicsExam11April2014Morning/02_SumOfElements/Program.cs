using System;

class SumOfElements
{
    static void Main()
    {
        string intString = Console.ReadLine();
        string[] bufferStr = intString.Split(' ');
        long[] intNums = Array.ConvertAll(bufferStr, delegate(string s) { return long.Parse(s); });
        long sumOfAllElements = 0;
        uint sumOfItem = 0;
        uint biggestNum = 0;
        foreach (long x in intNums)
        {
            sumOfAllElements += x;
        }
        for (int cnt = 0; cnt < intNums.Length; cnt++)
        {
            if (intNums[cnt] == (sumOfAllElements - intNums[cnt]))
            {
                sumOfItem = (uint)intNums[cnt];
            }
            if (intNums[cnt] > biggestNum)
            {
                biggestNum = (uint)intNums[cnt];
            }
        }
        Console.WriteLine(sumOfItem == (sumOfAllElements - sumOfItem) ?
            "Yes, sum={0}" : "No, diff={1}", sumOfItem, Math.Abs(biggestNum - (sumOfAllElements - biggestNum)));
    }
}