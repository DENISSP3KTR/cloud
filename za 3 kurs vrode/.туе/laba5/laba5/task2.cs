using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class task2
    {
        public int radius;
        public string name;
        private task2[] arrPlanet;
        public task2(int i)
        {
            arrPlanet = new task2[i];
        }
        public task2(string _name, int _rad)
        {
            name = _name;
            radius = _rad;
        }
        public task2 this[int pos]
        {
            get { return arrPlanet[pos]; }
            set { arrPlanet[pos] = value; }
        }
        public void rZ(int st)
        {
            for (int i = 0; i < arrPlanet.Length; i++)
            {
                if (arrPlanet[i].radius > st)
                {
                    Console.WriteLine(arrPlanet[i].name);
                }
            }
        }
    }
}
