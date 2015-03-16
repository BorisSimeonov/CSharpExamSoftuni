using System;

class NewWierdCombinations
{
    static void Main()
    {
        string input = Console.ReadLine();
        int counter = int.Parse(Console.ReadLine());
        int actualCounter = 0;
        bool check = false;

        foreach (char c1 in input)
        {
            foreach (char c2 in input)
            {
                foreach (char c3 in input)
                {
                    foreach (char c4 in input)
                    {
                        foreach (char c5 in input)
                        {
                            if (counter == actualCounter)
                            {
                                Console.WriteLine("{0}{1}{2}{3}{4}",
                                    c1, c2, c3, c4, c5);
                                check = true;
                            }
                            actualCounter++;
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