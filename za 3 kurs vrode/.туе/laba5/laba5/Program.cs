using System;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            task1 pt1 = new task1(100);
            task1 pt2 = new task1(200);
            task1 pt3 = pt1 - pt2;
            Console.WriteLine(pt3.ToString());
            task2 pl = new task2(8);
            pl[0] = new task2("Земля", 6378);
            pl[1] = new task2("Марс", 3488);
            pl[2] = new task2("Венера", 6052);
            pl[3] = new task2("Юпитер", 71300);
            pl[4] = new task2("Меркурий", 2439);
            pl[5] = new task2("Нептун", 24750);
            pl[6] = new task2("Сатурн", 60100);
            pl[7] = new task2("Уран", 26500);
            pl.rZ(pl[0].radius);
        }
    }
}
