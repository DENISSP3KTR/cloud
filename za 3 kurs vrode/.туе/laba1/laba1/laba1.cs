using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class laba1
    {
        public void z1()
        {
            double a, b;
            Console.WriteLine("ax+b=0");
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                Console.WriteLine("x=" + (-b / a));
            }
            else
            {
                Console.WriteLine("a не может быть равна 0");
                return;
            }
        }
        public void z2()
        {
            double a, b;
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            if (a > b) { Console.WriteLine("a>b"); }
            else if (b < a) { Console.WriteLine("a<b"); }
            else { Console.WriteLine("a=b"); }
        }
        public void z3()
        {
            int k;
            Console.Write("k=");
            k = Convert.ToInt32(Console.ReadLine());
            string s = "грибов";
            if ((k % 10 == 1) && (k%100 != 11))
            {
                s = "гриб";
            }
            if (k % 10 > 1 && k % 10 < 5 && k % 100 != 12 && k % 100 != 13 && k % 100 != 14)
            {
                s = "гриба";
            }
            Console.WriteLine("Мы нашли" + " " + k + " " + s + " " + "в лесу");
        }
        public void z4()
        {
            double skv, skr;
            Console.Write("Площадь квадрат:");
            skv = Convert.ToDouble(Console.ReadLine());
            Console.Write("Площадь круга:");
            skr = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(skr / Math.PI);
            double a = Math.Sqrt(skv);
            double dkv = Math.Sqrt(a * a + a * a);
            double dkr = 2 * r;
            if (a >= r)
            {
                Console.WriteLine("Круг умещается в квадрат");
            }
            else if (dkr >= dkv)
            {
                Console.WriteLine("Круг описывает квадрат");
            }
            else { Console.WriteLine("не верно"); }
        }
        public void z5()
        {
            double kmh, ms;
            Console.Write("Скорость в км/ч:");
            kmh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Скорость в м/с:");
            ms = Convert.ToDouble(Console.ReadLine());
            double ms2 = kmh * 3.6;
            if (ms > ms2) { Console.WriteLine("м/с>км/ч"); }
            else if(ms < ms2){ Console.WriteLine("м/с<км/ч"); }
            else { Console.WriteLine("равны"); }
        }
        public void z6()
        {
            DateTime dataNow = new DateTime();
            dataNow = DateTime.Now;
            int yearNow = dataNow.Year;
            int monthNow = dataNow.Month;
            DateTime data = new DateTime();
            Console.WriteLine("Дата рождения:");
            data = Convert.ToDateTime(Console.ReadLine());
            int ydata = data.Year;
            int mdata = data.Month;
            int year = yearNow - ydata;
            if (monthNow < mdata)
            {
                year--;
            }
            Console.WriteLine("Возраст:" + year);
        }
        public void z7()
        {
            Console.Write("Фамилия:");
            string fam = Console.ReadLine();
            string s = fam.Substring(fam.Length - 2);
            string s2 = fam.Substring(fam.Length - 3);
            if (s == "ов")
            {
                Console.WriteLine("Здравствуйте господин"+", "+fam+"!");
            }
            else if (s2 == "ова")
            {
                Console.WriteLine("Здравствуйте госпожа"+", "+fam+"!");
            }
            else
            {
                Console.WriteLine("Здравствуйте господин(госпожа)" + ", " + fam + "!");
            }
        }
        public void z8()
        {
            Console.WriteLine("Введите день недели:");
            string s = Console.ReadLine();
            switch (s)
            {
                case "Понедельник":
                case "понедельник":
                case "1":
                    Console.WriteLine("Программирование на языке Python (Лабораторная работа)");
                    Console.WriteLine("Программирование на платформе .NET (Лабораторная работа)");
                    break;
                case "Вторник":
                case "вторник":
                case "2":
                    Console.WriteLine("Программирование на платформе .NET (лекция)");
                    Console.WriteLine("Компьютерная и инженерная графика (Лабораторная работа)");
                    Console.WriteLine("Вычислительные методы (Лабораторная работа)");
                    break;
                case "Среда":
                case "среда":
                case "3":
                    Console.WriteLine("Элективные дисциплины по физической культуре и спорту (практика)");
                    Console.WriteLine("Вычислительные методы (лекция)");
                    break;
                case "Четверг":
                case "четверг":
                case "4":
                    Console.WriteLine("Программная инженерия (практика)");
                    Console.WriteLine("Программная инженерия (лекция)");
                    Console.WriteLine("Администрирование ОС Windows (лекция)");
                    break;
                case "Пятница":
                case "пятница":
                case "5":
                    Console.WriteLine("Электротехника и электроника (Лабораторная работа)");
                    Console.WriteLine("Программная инженерия (Лабораторная работа)");
                    break;
                case "Суббота":
                case "суббота":
                case "6":
                    Console.WriteLine();
                    break;
                case "Воскресенье":
                case "воскресенье":
                case "7":
                    Console.WriteLine("Элективные дисциплины по физической культуре и спорту (практика)");
                    Console.WriteLine("Технологии сети Интернет (Лабораторная работа)");
                    Console.WriteLine("Проектная деятельность (практика)");
                    break;
                default:
                    Console.WriteLine("Указали неправильный день");
                    break;
            }
        }
    }
}
