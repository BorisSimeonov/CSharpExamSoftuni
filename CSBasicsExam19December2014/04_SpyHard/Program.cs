using System;

class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine().ToLower();
        int msgLength = message.Length;
        int msgValue = 0;
        string result = "";
        string buffer = "";

        for (int iter = 0; iter < msgLength; iter++)
        {
            if (Char.IsLetter(message[iter]))
            {
                msgValue += Math.Abs((int)(message[iter]) - (int)'a') + 1;
            }
            else
            {
                msgValue += (int)message[iter];
            }
        }
        result += key.ToString() + msgLength;

        if (key == 2 || key == 10)
        {
            result += Convert.ToString(msgValue, key);
        }
        else
        {
            int value = msgValue;
            int leftover = 0;

            while (value > 0)
            {
                leftover = value % key;
                value -= leftover;
                value /= key;
                buffer = buffer + leftover;
            }
            char[] chArray = buffer.ToCharArray();
            Array.Reverse(chArray);
            buffer = new string(chArray);
        }


        Console.WriteLine(result + buffer);
    }
}