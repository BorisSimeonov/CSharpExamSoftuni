using System;

class Program
{
    static void Main()
    {
        string movieLine = Console.ReadLine().ToUpper();
        int illuminatiSum = 0;
        int count = 0;
        for (int idx = 0; idx < movieLine.Length; idx++)
        {
            int charValue = 0;
            switch (movieLine[idx])
            {
                case 'A':
                    charValue = 65;
                    count++;
                    break;
                case 'E':
                    charValue = 69;
                    count++;
                    break;
                case 'I':
                    charValue = 73;
                    count++;
                    break;
                case 'O':
                    charValue = 79;
                    count++;
                    break;
                case 'U':
                    charValue = 85;
                    count++;
                    break;
                default: break;
            }
            illuminatiSum = illuminatiSum + charValue;
        }
        Console.WriteLine("{0}\r\n{1}", count, illuminatiSum);
    }
}