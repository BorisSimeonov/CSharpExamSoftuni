using System;

class BitRoller
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int bitPosition = 18 - int.Parse(Console.ReadLine());
        int steps = int.Parse(Console.ReadLine());
        string strNum = Convert.ToString(number, 2).PadLeft(19, '0');
        char[] chArray = strNum.ToCharArray();
        char buffer;
        //
        for (int cnt = 0; cnt < steps; cnt++)
        {
            buffer = ' ';
            for (int pos = 0; pos < 19; pos++)
            {
                if (buffer == ' ' && pos != bitPosition)
                {
                    buffer = chArray[pos];
                    if (bitPosition != 18)
                    {
                        chArray[pos] = chArray[chArray.Length - 1];
                    }
                    else
                    {
                        chArray[pos] = chArray[17];
                    }
                    continue;
                }
                if (pos == bitPosition)
                {
                    continue;
                }
                char middleBuffer = chArray[pos];
                chArray[pos] = buffer;
                buffer = middleBuffer;
            }
        }
        strNum = "";
        foreach (char x in chArray)
        {
            strNum += x;
        }
        Console.WriteLine(Convert.ToInt32(strNum, 2));
    }
}