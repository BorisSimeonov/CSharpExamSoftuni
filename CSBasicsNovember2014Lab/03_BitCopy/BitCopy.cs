using System;

class BitCopy
{
    static void Main()
    {
        int primeNum = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        //Get the bit value
        int bit = (primeNum >> position) & 1;
        int bitPosTwo = (primeNum >> 2) & 1;
        if(bit != bitPosTwo && bit < bitPosTwo)
        {
            primeNum -= (1 << 2);
        }
        else if(bit != bitPosTwo && bit > bitPosTwo)
        {
            primeNum += (1 << 2);
        }
        Console.WriteLine(primeNum);
    }
}