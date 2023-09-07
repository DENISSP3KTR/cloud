using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba3
{
    public class InnOutt
    {
        public void randarr()
        {
            char[] alph = new char[52];
            int j = 0;
            for (char i = 'A'; i < 'Z'; i++)
            {
                alph[j] = i;
                j++;
            }
            for (char i = 'a'; i < 'z'; i++)
            {
                alph[j] = i;
                j++;
            }
            Random rand = new Random();
            int t = rand.Next(1, 10);
            char[][] arr = new char[t][];
            StreamWriter sw = new StreamWriter("D:/мучеба/.net/laba3/example.txt", true, Encoding.UTF8);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new char[rand.Next(1, 26)];
                for (int m = 0; m<arr[i].Length; m++)
                {
                    string st = alph[rand.Next(0, 52)].ToString();
                    arr[i][m] = char.Parse(st);   
                }
                sw.WriteLine(arr[i]);
            }
            sw.Close();
        }
        public string Inn()
        {
            StreamReader sr = new StreamReader("D:/мучеба/.net/laba3/example.txt", Encoding.UTF8);
            string str = sr.ReadToEnd();
            sr.Close();
            return str;
        }
        public void task2()
        {
            StreamReader sr = new StreamReader("D:/мучеба/.net/laba3/example.txt", Encoding.UTF8);
            while (sr.Peek() != -1)
            {
                int s = 0;
                string str = sr.ReadLine();
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 's' || str[i] == 'S')
                    {
                        s++;
                    }
                }
                Console.WriteLine(s);
            }
        }
    }
}
