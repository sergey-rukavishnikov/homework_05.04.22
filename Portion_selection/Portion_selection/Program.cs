using System;

namespace Portion_selection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор объёма: 1 = маленькая, 2 = средняя, 3 = большая.");
            Console.Write("Укажите объём: ");
            string choise = Console.ReadLine();
            if (choise == "1" || choise == "маленькая")
                Console.WriteLine("Внесите в автомат 35 рублей.\nСпасибо, что нашей Машиной.");
            else if (choise == "2" || choise == "средняя")
                Console.WriteLine("Внесите в автомат 45 рублей.\nСпасибо, что нашей Машиной.");
            else if (choise == "3" || choise == "большая")
                Console.WriteLine("Внесите в автомат 55 рублей.\nСпасибо, что нашей Машиной.");
            else
                Console.WriteLine("Ошибочный ввод!");
        }
    }
}
