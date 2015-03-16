using System;

class BitSweeper
{
    static void Main()
    {
        uint[] intArray = new uint[4];
        for (int cnt = 0; cnt < 4; cnt++)
        {
            intArray[cnt] = uint.Parse(Console.ReadLine());
        }
        //
        while (true)
        {
            string com = Console.ReadLine();
            if (com == "End")
            {
                break;
            }
            uint bufferFirst = 0;
            uint bufferSecond = 0;
            uint[] firstCommand = { (uint)Char.GetNumericValue(com[0]), (uint)Char.GetNumericValue(com[2]) };
            com = Console.ReadLine();
            uint[] secondCommand = { (uint)Char.GetNumericValue(com[0]), (uint)Char.GetNumericValue(com[2]) };
            //get the first 4bit value and clear the 4bits
            bufferFirst = ((intArray[firstCommand[0]] >> (int)(4 * firstCommand[1])) & 15);
            intArray[firstCommand[0]] -= (bufferFirst << (int)(4 * firstCommand[1]));
            //get the second 4bit value and clear the 4bits
            bufferSecond = (intArray[secondCommand[0]] >> (int)(4 * secondCommand[1])) & 15;
            intArray[secondCommand[0]] -= (bufferSecond << (int)(4 * secondCommand[1]));
            //swap the bits
            intArray[firstCommand[0]] += (bufferSecond << (int)(4 * firstCommand[1]));
            intArray[secondCommand[0]] += (bufferFirst << (int)(4 * secondCommand[1]));
        }
        foreach (uint x in intArray)
        {
            Console.WriteLine(x);
        }
    }
}