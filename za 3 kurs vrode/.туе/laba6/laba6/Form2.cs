using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace laba6
{
    public partial class Form2 : Form
    {
        public Form2(string name)
        {
            InitializeComponent();
            this.Text = name;
        }
        Form1 frm1 = new Form1();
        List<Bitmap> lb = new List<Bitmap>();
        public int i = -1;
        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("D:/мучеба/3 курс/.net/laba6/img/" + this.Text+"/bio.txt");
            label1.Text = sr.ReadLine();
            sr.Close();
            int j = 0;
            string[] path = Directory.GetFiles("D:/мучеба/3 курс/.net/laba6/img/" + this.Text, "*.jpg");
            while (j!=path.Length)
            {
                Bitmap img = new Bitmap(path[j]);
                lb.Add(img);
                j++;
            }
            i++;
            pictureBox1.Image = lb[i];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i < lb.Count-1)
            {
                i++;
                pictureBox1.Image = lb[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                pictureBox1.Image = lb[i];
            }
        }
    }
}
