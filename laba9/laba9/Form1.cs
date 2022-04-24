using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
namespace laba9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFile();
        }
        public void OpenFile()
        {
            Excel excel = new Excel(@"D:\github\cloud\laba9\asd.xlsx",1);
            MessageBox.Show(excel.ReadCell(0, 0));
        }
    }
}
