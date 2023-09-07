using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class task1
    {
        public int x;
        public task1(int _x)
        {
            x = _x;

        }
        public static task1 operator -(task1 pl1, task1 pl2)
        {
            task1 newPoint = new task1(pl1.x + pl2.x);
            return newPoint;
        }
        public override string ToString()
        {
            return "X="+x;
        }
    }
}

