using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace laba9_1
{
    public class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }
        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return "";
        }
        public void WriteCell(string s, int i, int j)
        {
            ws.Cells[i, j].Value2 = s;
        }
        public void Stylee()
        {
            ws.Columns.ColumnWidth = 20;
            ws.Cells[1, 3].Font.Name = "Times New Roman";
            ws.Cells[1, 3].Font.Bold = true;
            ws.Cells[1, 3].Font.Size = 16;
            ws.Cells[1, 3].HorizontalAlignment = Constants.xlCenter;
            Range r = ws.get_Range("b3","d3");
            r.Font.Name = "Times New Roman";
            r.Font.Bold = true;
            r.Font.Size = 14;
            r.HorizontalAlignment = Constants.xlCenter;
            Range r1 = ws.get_Range("b4", "b6");
            r1.Font.Name = "Times New Roman";
            r1.HorizontalAlignment = Constants.xlRight;
            Range r2 = ws.get_Range("c4", "c6");
            r2.Font.Italic = true;
            r2.HorizontalAlignment = Constants.xlLeft;
            Range r3 = ws.get_Range("d4", "d6");
            r2.HorizontalAlignment = Constants.xlRight;
        }
        public void clos(string path)
        {
            wb.SaveAs(path);
            wb.Close();
            excel.Quit();
        }
    }
}
