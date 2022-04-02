using System;

namespace Random_light
{
    class Program
    {
        enum options
        {
            нет,
            да
        }
        enum status
        {
            погашен,
            включён
        }
        static void Main(string[] args)
        {
            Random rngen = new Random();
            int light = rngen.Next(2);
            Console.WriteLine($"Свет в комнате {(light == 0 ? status.погашен: status.включён)}.");
            Console.WriteLine($"Желаете это изменить?\n{(int)options.нет} = {options.нет}, {(int)options.да} = {options.да}");
            int.TryParse(Console.ReadLine(), out int choise);
            if (choise == 0)
                Console.WriteLine("Вы решили ничего не трогать. И правильно.");
            else
                Console.WriteLine($"Теперь в комнате {(light != 0 ? status.погашен : status.включён)} свет.");
        }
    }
}
