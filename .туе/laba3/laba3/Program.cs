using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("D:/мучеба/.net/laba3/example.txt", false, Encoding.UTF8);
            sw.Flush();
            sw.Close();
            InnOutt innOutt = new InnOutt();
            innOutt.randarr();
            Console.WriteLine(innOutt.Inn());
            innOutt.task2();
        }
    }
}
