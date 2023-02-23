using System;

namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bugatti bugatti = new Bugatti("Bugatti", 0);
            Toyota toyota = new Toyota("Toyota", 0);
            Ferrari ferrari = new Ferrari("Ferrari", 0);
            Radio radio = new Radio();
            Console.WriteLine(@"На какой машине сегодня поедите:
1.Bugatti
2.Toyota
3.Ferrari");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Вы выбрали:");
            switch (n)
            {
                case 1:
                    Console.WriteLine(bugatti.Name());
                    Console.Write("\n");
                    break;
                case 2:
                    Console.WriteLine(toyota.Name());
                    Console.Write("\n");
                    break;
                case 3:
                    Console.WriteLine(ferrari.Name());
                    Console.Write("\n");
                    break;
                default:
                    {
                        Console.WriteLine("Извините, нет такой машины");
                        break;
                    }
            }
            bool b = true;
            while (b)
            {
                Console.WriteLine(@"Ваши дальнейшие действия:
1.Завести машину
2.Выключить двигатель
3.Включить радио
4.Выключить радио
5.Ускориться
6.Сбавить скорость
7.Выйти из машины");
                int l = int.Parse(Console.ReadLine());
                switch (l)
                {
                    case 1:
                        if(n == 1) bugatti.Startt();
                        if(n == 2) toyota.Startt();
                        if(n == 3) ferrari.Startt();
                        break;
                    case 2:
                        if (n == 1) bugatti.Stopp();
                        if (n == 2) toyota.Stopp();
                        if (n == 3) ferrari.Stopp();
                        break;
                    case 3:
                        radio.On();
                        break;
                    case 4:
                        radio.Off();
                        break;
                    case 5:
                        if (n == 1) bugatti.SpeedUp();
                        if (n == 2) toyota.SpeedUp();
                        if (n == 3) ferrari.SpeedUp();
                        break;
                    case 6:
                        if (n == 1) bugatti.SpeedDown();
                        if (n == 2) toyota.SpeedDown();
                        if (n == 3) ferrari.SpeedDown();
                        break;
                    case 7:
                        if (n == 1) b = bugatti.speedd();
                        if (n == 2) b = toyota.speedd();
                        if (n == 3) b = ferrari.speedd();
                        break;
                    default:
                        {
                            Console.WriteLine("Вы выбрали не правильное действие");
                            break;
                        }
                }
                Console.Write("\n");
            }
        }
    }
}
