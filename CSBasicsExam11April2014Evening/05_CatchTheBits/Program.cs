using System;

class Program
{
    static void Main()
    {
        int numCount = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string nums = null;
        int numsLength = 0;
        for (int cnt = 0; cnt < numCount; cnt++)
        {
            nums += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
        }
        numsLength = nums.Length;
        string newNums = "";
        for (int cnt = 1; cnt <= numsLength - 1; )
        {
            newNums += nums[cnt];
            cnt += step;
        }
        if (newNums.Length % 8 != 0)
        {
            int addBits = 8 - newNums.Length % 8;
            newNums += new string('0', addBits);
        }
        //------------------------        
        string separateNum = "";
        for (int cnt = 1; cnt <= newNums.Length; cnt++)
        {
            separateNum += newNums[cnt - 1];
            if (cnt % 8 == 0)
            {
                Console.WriteLine(Convert.ToInt32(separateNum, 2));
                separateNum = "";
            }
        }
    }
}