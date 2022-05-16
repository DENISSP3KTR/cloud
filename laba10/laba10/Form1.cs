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
using Accord.Imaging;
using Accord.Imaging.Filters;
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
        string editapp;
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
                        //g.DrawLine(pen1, p1, p2);
                        int radx = 100;
                        Point pa = new Point();
                        //pa = minlen(p1, p2, rad);
                        int a;
                        int b;
                        //pa = minlen(p1, p2, rad / 2);
                        //int a1 = rad / 4 - pa.Y;
                        //int b1 = rad / 4 - pa.X;
                        Point pb = new Point();
                        //pb = GetNextPoint(p1, p2, rad);
                        //g.DrawEllipse(pen1, p1.X - a, p1.Y - b, rad, rad);
                        //g.DrawEllipse(pen1, pb.X - a1, pb.Y - b1, rad/2, rad/2);
                        int i = 10;
                        while (i > 0)
                        {
                            pa = minlen(p1, p2, radx);
                            a = radx / 2 - pa.Y;
                            b = radx / 2 - pa.X;
                            g.DrawEllipse(pen1, p1.X - a, p1.Y - b, radx, radx);
                            pb = GetNextPoint(p1, p2, radx);
                            radx = radx / 2;
                            p1 = pb;
                            i--;
                        }
                        
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
        }
        public static double DistanceBetweenTwoPoints(Point point1, Point point2)
        {
            int dx = point1.X - point2.X;
            int dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public int RadiusX(Point p1, Point p2)
        {
            int d = (int)DistanceBetweenTwoPoints(p1, p2);
            int x = d / 55;
            return x;
        }
        public Point GetNextPoint(Point p1, Point p2, int rad)
        {
            Point p = new Point();
            double d = DistanceBetweenTwoPoints(p1, p2);
            double mxx = p2.X - p1.X;
            double mxy = p2.Y - p1.Y;
            double mcos = mxx / d;
            double msin = mxy / d;
            double mnx = rad * mcos;
            double mny = rad * msin;
            p.X = p1.X + (int)mnx;
            p.Y = p1.Y + (int)mny;
            return p;
        }
        public Point minlen(Point p1, Point p2, double rad)
        {
            double d = DistanceBetweenTwoPoints(p1, p2);
            double a, b;
            a = p2.Y - p1.Y;
            b = p2.X - p1.X;
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
        public bool trackbarvis()
        {
            bool p = false;
            if (g != null)
            {
                trackBar1.Visible = true;
                label1.Text = trackBar1.Value.ToString();
                p = true;
            }
            else
            {
                MessageBox.Show("Создайте новый холст или откройте изображение");
            }
            return p;
        }
        private void рисованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = false;
        }

        private void яркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 50;
            if (trackbarvis())
            {
                editapp = "Яркость";
                bri = trackBar1.Value;
            }

        }

        private void контрастToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 50;
            if (trackbarvis())
            {
                editapp = "Контраст";
            }
        }

        private void насыщенностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 50;
            if (trackbarvis())
            {
                editapp = "Насыщенность";
            }
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 50;
            if (trackbarvis())
            {
                editapp = "Резкость";
            }
        }

        private void удалениеШумовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            if (trackbarvis())
            {
                editapp = "Шум";
            }
        }
        int bri = 0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            if (editapp == "Яркость")
            {
                //bri = trackBar1.Value;
                image = (Bitmap)pictureBox1.Image;
                IFilter bright = new BrightnessCorrection(trackBar1.Value - bri);
                pictureBox1.Image = bright.Apply(image);
            }
            if(editapp == "Контраст") { }
            if(editapp == "Насыщенность") { }
            if(editapp == "Резкость") { }
            if(editapp == "Шум") { }

        }
    }
}
