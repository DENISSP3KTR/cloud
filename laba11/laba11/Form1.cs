using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace laba11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = @"D:\github\cloud\123.xml";
        private void button1_Click(object sender, EventArgs e)
        {
            addfrm frm = new addfrm();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTable();
        }
        public void InitTable()
        {
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(path);
                dataGridView1.DataSource = ds.Tables[1];
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog svd = new SaveFileDialog();
            svd.Title = "Сохранить xml как...";
            svd.OverwritePrompt = true;
            svd.CheckPathExists = true;
            svd.Filter = "Xml Files(*.xml)|*.xml";
            svd.ShowHelp = true;
            if (svd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlTextWriter wr = new XmlTextWriter(svd.FileName, Encoding.UTF8);
                    wr.WriteStartDocument();
                    wr.WriteStartElement("ИВТ-19-1");
                        wr.WriteStartElement("Студенты");
                            wr.WriteStartElement("Студент");
                                wr.WriteAttributeString("Номер_Студки", "191256");
                                wr.WriteAttributeString("Фамилия", "Осипов");
                                wr.WriteAttributeString("Имя", "Денис");
                                wr.WriteAttributeString("Отчество", "Евгеньевич");
                                wr.WriteAttributeString("Курс", "3");
                                wr.WriteAttributeString("Стипендия", "7000");
                            wr.WriteEndElement();
                        wr.WriteEndElement();
                    wr.WriteEndElement();
                    wr.WriteEndDocument();
                    wr.Close();
                    MessageBox.Show("Файл создался");
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить xml", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            InitTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InitTable();
        }
    }
}
