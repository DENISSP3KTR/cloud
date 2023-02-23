using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class Car
    {
        private string _name;
        private double _speed;
        public double _speed2;
        public Car(string name, double speed)
        {
            _name = name;
            _speed = speed;
        }
        public int p = 0;
        public string Name()
        {
            return _name;
        }
        public void Startt()
        {
            p = 1;
            Console.WriteLine("Машина завелась");
        }
        public void Stopp()
        {
            if (p == 0)
            {
                Console.WriteLine("Машина не заведена");
            }
            else
            {
                _speed = 0;
                Console.WriteLine("Машина остановилась");
            }
        }
        public virtual void SpeedUp()
        {
            if (p == 0) Console.WriteLine("Машина не заведена");
            else
            {
                _speed += 50;
                Console.WriteLine("Скорость машины увеличина на 50 км/ч");
                Console.WriteLine("Скорость равна " + _speed);
                _speed2 = _speed;
            }
        }
        public void SpeedDown()
        {
            if (p == 0) Console.WriteLine("Машина не заведена");
            else
            {
                if (_speed > 50)
                {
                    _speed -= 50;
                    Console.WriteLine("Cкорость равна " + _speed);
                }
                else
                {
                    Stopp();
                }
            }
        }
        public bool speedd()
        {
            bool b = true;
            if (_speed > 0) Console.WriteLine("Вы не можете выйти в пути. Сбавьте скорость");
            else { Console.WriteLine("Вы вышли из машины, Досвидания"); b = false; }
            return b;
        }
    }
}
