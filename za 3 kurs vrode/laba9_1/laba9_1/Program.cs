using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace laba9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Student\Desktop\cloud\laba9_1\asd.xlsx";
            Excel excel = new Excel(path, 1);
            Console.WriteLine(excel.ReadCell(0, 0));
            excel.WriteCell("Почта", 1, 3);
            excel.WriteCell("Номер", 3, 2);
            excel.WriteCell("Наименование", 3, 3);
            excel.WriteCell("Дата отправки", 3, 4);
            excel.WriteCell("1290", 4, 2);
            excel.WriteCell("764", 5, 2);
            excel.WriteCell("6526", 6, 2);
            excel.WriteCell("посылка", 4, 3);
            excel.WriteCell("бандероль", 5, 3);
            excel.WriteCell("письмо", 6, 3);
            excel.WriteCell("12.10.2015", 4, 4);
            excel.WriteCell("04.11.2012", 5, 4);
            excel.WriteCell("05.10.2012", 6, 4);
            excel.Stylee();
            Console.ReadKey();
            excel.clos(path);
        }
    }
}
