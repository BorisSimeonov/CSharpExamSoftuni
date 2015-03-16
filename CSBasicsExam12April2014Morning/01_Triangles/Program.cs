using System;
using System.Globalization;
using System.Threading;

class Triangle
{
    static void Main()
    {
        //initialisation
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        int[] a = new int[2];
        int[] b = new int[2];
        int[] c = new int[2];

        for (int cnt = 0, index = 0; cnt < 6; cnt++, index++)
        {
            if (index == 2)
            {
                index = 0;
            }
            if (cnt < 2)
            {
                a[index] = int.Parse(Console.ReadLine());
            }
            if (cnt < 4 && cnt > 1)
            {
                b[index] = int.Parse(Console.ReadLine());
            }
            if (cnt >= 4)
            {
                c[index] = int.Parse(Console.ReadLine());
            }
        }
        //check
        double xFirst = Math.Abs(a[0] - b[0]);
        double yFirst = Math.Abs(a[1] - b[1]);
        double firstSide = Math.Sqrt((xFirst * xFirst) + (yFirst * yFirst));

        double xSecond = Math.Abs(b[0] - c[0]);
        double ySecond = Math.Abs(b[1] - c[1]);
        double secondSide = Math.Sqrt((xSecond * xSecond) + (ySecond * ySecond));

        double xThird = Math.Abs(a[0] - c[0]);
        double yThird = Math.Abs(a[1] - c[1]);
        double thirdSide = Math.Sqrt((xThird * xThird) + (yThird * yThird));

        double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
        double areaTriangle = Math.Sqrt(halfPerimeter * ((halfPerimeter - firstSide) *
            (halfPerimeter - secondSide) * (halfPerimeter - thirdSide)));

        if (areaTriangle == 0)
        {
            Console.WriteLine("No\r\n{0:f2}", firstSide);
        }
        else
        {
            Console.WriteLine("Yes\r\n{0:f2}", areaTriangle);
        }
    }
}