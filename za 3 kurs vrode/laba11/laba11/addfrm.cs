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
namespace laba11
{
    public partial class addfrm : Form
    {
        public addfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xdoc.Load(opd.FileName);
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            XmlNode root = xdoc.DocumentElement;
            foreach(XmlNode node in root.ChildNodes)
            {
                if(node.Name == "Студенты")
                {
                    XmlElement elem = xdoc.CreateElement("Студент");
                    node.AppendChild(elem);
                    XmlAttribute atr1 = xdoc.CreateAttribute("Номер_Студки");
                    atr1.Value = textBox1.Text;
                    elem.Attributes.Append(atr1);

                    XmlAttribute atr2 = xdoc.CreateAttribute("Фамилия");
                    atr2.Value = textBox2.Text;
                    elem.Attributes.Append(atr2);

                    XmlAttribute atr3 = xdoc.CreateAttribute("Имя");
                    atr3.Value = textBox3.Text;
                    elem.Attributes.Append(atr3);

                    XmlAttribute atr4 = xdoc.CreateAttribute("Отчество");
                    atr4.Value = textBox4.Text;
                    elem.Attributes.Append(atr4);

                    XmlAttribute atr5 = xdoc.CreateAttribute("Курс");
                    atr5.Value = textBox5.Text;
                    elem.Attributes.Append(atr5);

                    XmlAttribute atr6 = xdoc.CreateAttribute("Стипендия");
                    atr6.Value = textBox6.Text;
                    elem.Attributes.Append(atr6);
                }
            }
            xdoc.Save(opd.FileName);
            this.Close();
            MessageBox.Show("Успешно добавлено");
            Form1 frm = new Form1();
            frm.InitTable();
        }
    }
}
