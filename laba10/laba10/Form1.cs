using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace laba10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap image;
        Graphics g;
        Pen pen;
        Pen pen1;
        SolidBrush b;
        Point p1;
        Point p2;
        bool cl1 = true;
        bool cl2 = false;
        public void новоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = image;
            g = Graphics.FromImage(image);
            g.Clear(Color.White);
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(opd.FileName);
                    Bitmap image2 = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = image2;
                    pictureBox1.Invalidate();
                    g = Graphics.FromImage(image2);
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog svd = new SaveFileDialog();
                svd.Title = "Сохранить картинку как...";
                svd.OverwritePrompt = true;
                svd.CheckPathExists = true;
                svd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                svd.ShowHelp = true;
                if (svd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(svd.FileName, ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (g != null)
            {
                if (b != null)
                {
                    Random r = new Random();
                    int re = r.Next(100);
                    b.Color = Randcolor();
                    g.FillEllipse(b, e.X, e.Y, re, re);
                }
                else if (pen != null)
                {
                    Random r = new Random();
                    int rad = r.Next(20, 150), x, y;
                    for (int i=rad; i>=10; i -= 5)
                    {
                        x = e.X - i;
                        y = e.Y - i;
                        g.DrawEllipse(pen, x, y, i * 2, i * 2);
                    }
                }
                else if (pen1 != null)
                {
                    if (cl1)
                    {
                        p1 = e.Location;
                        cl1 = false;
                    }
                    if (cl2)
                    {
                        p2 = e.Location;
                        cl1 = true;
                        g.DrawLine(pen1, p1, p2);
                        int rad = 100;
                        Point pa = new Point();
                        pa = minlen(p1, p2, rad);
                        int a = rad / 2 - pa.Y;
                        int b = rad / 2 - pa.X;
                        g.DrawEllipse(pen1, p1.X - a, p1.Y - b, rad, rad);
                    } 
                }
                else
                {
                    MessageBox.Show("Выберите что рисовать");
                }
            }
            else
            {
                MessageBox.Show("Создайте новый холст или откройте изображение");
            }
            pictureBox1.Invalidate();
            label1.Text = p1.X.ToString() + " " + p1.Y.ToString();
            label2.Text = p2.X.ToString() + " " + p2.Y.ToString();
        }
        public static double DistanceBetweenTwoPoints(Point point1, Point point2)
        {
            int dx = point1.X - point2.X;
            int dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public Point minlen(Point p1, Point p2, double rad)
        {
            double d = DistanceBetweenTwoPoints(p1, p2);
            double a, b;
            a = Math.Abs(p2.Y - p1.Y);
            b = Math.Abs(p2.X - p1.X);
            double sinalf, cosalf;
            Point p = new Point();
            sinalf = a / d;
            cosalf = b / d;
            a = rad / 2 * sinalf;
            b = rad / 2 * cosalf;
            p.X = (int)a;
            p.Y = (int)b;
            return p;
        }
        public void wPointdraw(Point p1, Point p2)
        {
            g.DrawLine(pen1, p1.X, p1.Y, p2.X, p2.Y);
        }
        private void рандомныйКругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen = null;
            pen1 = null;
            Color c = Randcolor();
            b = new SolidBrush(c);
        }
        public Color Randcolor()
        {
            Color c = new Color();
            Random r = new Random();
            c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            return c;
        }

        private void концентрическиеКругиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = null;
            pen1 = null;
            pen = new Pen(Randcolor(), 3.0f);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void кругиНаОтрезкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = null;
            pen = null;
            pen1 = new Pen(Randcolor(), 2.0f);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!cl1)
            {
                cl2 = true;
            }
            else
            {
                cl2 = false;
            }
        }
    }
}
