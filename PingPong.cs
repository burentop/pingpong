using System;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string stringInputNumber = Console.ReadLine();
        int inputNumber = int.Parse(stringInputNumber);
        pingPong(inputNumber);
    }

    static void pingPong(int number)
    {
        for (int i = 0; i <= number; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine("ping-pong");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("pong");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("ping");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}