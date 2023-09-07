using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class Toyota:Car
    {
        private string _name;
        private double _speed;
        public Toyota(string name, double speed) : base(name, speed)
        {
            _name = name;
            _speed = speed;
        }
        private const int MaxSpeed = 300;
        public override void SpeedUp()
        {
            base.SpeedUp();
            if (_speed2 >= MaxSpeed)
            {
                Console.WriteLine("Скорость достигла до максимального значения");
                SpeedDown();
            }
        }
    }
}
