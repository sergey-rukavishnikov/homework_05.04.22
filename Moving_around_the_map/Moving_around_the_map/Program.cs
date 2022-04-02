using System;

namespace Moving_around_the_map
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                if (i == 44)
                    Console.Write("@");
                else if (i < 9 || i > 89 || i % 10 == 0)
                    Console.Write("#");
                else if ((i + 1) % 10 == 0)
                    Console.Write("#\n");
                else
                    Console.Write(" ");
            }
            int np = 44;
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.W:
                    {
                        np -= 10;
                        break;
                    }
                case ConsoleKey.A:
                    {
                        np -= 1;
                        break;
                    }
                case ConsoleKey.S:
                    {
                        np += 10;
                        break;
                    }
                case ConsoleKey.D:
                    {
                        np += 1;
                        break;
                    }
            }
            Console.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (i == np)
                    Console.Write("@");
                else if (i < 9 || i > 89 || i % 10 == 0)
                    Console.Write("#");
                else if ((i + 1) % 10 == 0)
                    Console.Write("#\n");
                else
                    Console.Write(" ");
            }
        }
    }
}
