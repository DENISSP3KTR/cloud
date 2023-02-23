using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class Ferrari:Car
    {
        private string _name;
        private double _speed;
        public Ferrari(string name, double speed) : base(name, speed)
        {
            _name = name;
            _speed = speed;
        }
    }
}
