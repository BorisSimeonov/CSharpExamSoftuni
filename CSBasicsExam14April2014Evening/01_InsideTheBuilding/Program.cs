using System;

class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int[] xSpots = new int[10];
        int[] ySpots = new int[10];
        string[] results = new string[5];
        for (int cnt = 0; cnt < 5; cnt++)
        {
            xSpots[cnt] = int.Parse(Console.ReadLine());
            ySpots[cnt] = int.Parse(Console.ReadLine());

            if ((xSpots[cnt] <= h * 3 && ySpots[cnt] <= h && xSpots[cnt] >= 0 && ySpots[cnt] >= 0) ||
                (xSpots[cnt] >= h && xSpots[cnt] <= h * 2 && ySpots[cnt] >= h && ySpots[cnt] <= h * 4))
            {
                results[cnt] = "inside";
            }
            else
            {
                results[cnt] = "outside";
            }
        }
        //
        foreach (string x in results)
        {
            Console.WriteLine(x);
        }
    }
}