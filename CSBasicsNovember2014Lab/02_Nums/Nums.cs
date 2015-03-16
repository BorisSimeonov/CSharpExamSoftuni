using System;

class Nums
{
    static void Main(string[] args)
    {
        int n, m;
        n = int.Parse(Console.ReadLine());
        m = int.Parse(Console.ReadLine());
        double result = 0;
        for (int cnt = n; cnt <= m; cnt++ )
        {
            if (cnt % 2 != 0)
            {
                result = Math.Pow(cnt, 2);
            }
            else
            {
                result = Math.Sqrt(cnt);
            }
            Console.WriteLine("{0:F03}", result);
        }
    }
}