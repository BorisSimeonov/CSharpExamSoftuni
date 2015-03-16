using System;

class HalfSum
{
    static void Main()
    {
        int halfNum = int.Parse(Console.ReadLine()) * 2;
        int[] intArray = new int[halfNum];
        int firstHalf = 0;
        int secHalf = 0;
        for (int cnt = 0; cnt < halfNum; cnt++)
        {
            intArray[cnt] = int.Parse(Console.ReadLine());
            if (cnt * 2 < halfNum)
            {
                firstHalf += intArray[cnt];
            }
            else
            {
                secHalf += intArray[cnt];
            }
        }
        Console.WriteLine(firstHalf == secHalf ? "Yes, sum={0}" : "No, diff={1}",
            firstHalf, Math.Abs(firstHalf - secHalf));
    }
}