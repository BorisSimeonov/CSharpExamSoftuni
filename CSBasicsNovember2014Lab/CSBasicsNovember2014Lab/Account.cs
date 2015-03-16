using System;

class Account
{
    static void Main(string[] args)
    {
        string[] inLine = new string[4];
        for (int cnt = 0; cnt < 4; cnt++ )
        {
            inLine[cnt] = Console.ReadLine();
        }
        double sum = Double.Parse(inLine[3]);
        Console.WriteLine("Hello, {0} {1}\nClient id: {2}\nTotal balance: {3:F2}"
            , inLine[0], inLine[1], inLine[2], sum);
        Console.WriteLine(sum >= 0 ? "Active: yes" : "Active: no");
    }
}