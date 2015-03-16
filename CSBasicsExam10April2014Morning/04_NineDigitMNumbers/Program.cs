using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool check = false;
        //loops
        for (int fn = 1; fn <= 7; fn++)
        {
            for (int sn = 1; sn <= 7; sn++)
            {
                for (int tn = 1; tn <= 7; tn++)
                {
                    for (int foN = 1; foN <= 7; foN++)
                    {
                        for (int fiN = 1; fiN <= 7; fiN++)
                        {
                            for (int sixN = 1; sixN <= 7; sixN++)
                            {
                                for (int sevN = 1; sevN <= 7; sevN++)
                                {
                                    for (int en = 1; en <= 7; en++)
                                    {
                                        for (int nN = 1; nN <= 7; nN++)
                                        {
                                            if (fn + sn + tn + foN + fiN + sixN + sevN + en + nN == sum &&
                                                (foN * 100 + fiN * 10 + sixN) - (fn * 100 + sn * 10 + tn) == diff &&
                                                (sevN * 100 + en * 10 + nN) - (foN * 100 + fiN * 10 + sixN) == diff)
                                            {
                                                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}",
                                                    fn, sn, tn, foN, fiN, sixN, sevN, en, nN);
                                                check = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!check)
        {
            Console.WriteLine("No");
        }
    }
}