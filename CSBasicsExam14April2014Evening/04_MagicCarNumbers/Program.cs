using System;

class MagicCarNumbers
{
    static void Main()
    {
        int magNum = int.Parse(Console.ReadLine());
        int startValue = 40;
        int[] charValues = {10,20,30,50,80,110, 130,160, 200, 240 };
        int counter = 0;
        for (int fst = 0; fst <= 9; fst++ )
        {
            for (int snd = 0; snd <= 9; snd++)
            {
                for (int trd = 0; trd <= 9; trd++)
                {
                    for (int fth = 0; fth <= 9; fth++)
                    {
                        //Chars
                        for (int fstLett = 0; fstLett < 10; fstLett++ )
                        {
                            for (int sndLett = 0; sndLett < 10; sndLett++ )
                            {
                                if (startValue + fst + snd + trd + fth +
                                    charValues[fstLett] + charValues[sndLett] == magNum)
                                {
                                    if((fst == snd && snd == trd) || (snd == trd && trd == fth) ||
                                        (fst == trd && snd == fth) || (fst == snd && snd == trd && trd == fth) ||
                                        (fst == snd && trd == fth) || (fst == fth && snd == trd))
                                    {
                                        counter++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}