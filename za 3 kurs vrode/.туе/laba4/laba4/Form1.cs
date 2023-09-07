using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    public partial class Form1 : Form
    {
        bool b = false;
        bool b2 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                child("Сведения о студентах");
                b = true;
            }
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b2 == false)
            {
                child("Сведения о преподавателях");
                b2 = true;
            }
        }

        private void выъодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form acchild = this.ActiveMdiChild;
            
            if (acchild.Text != null)
            {
                if (acchild.Text == "Сведения о студентах")
                {
                    b = false;
                }
                if (acchild.Text == "Сведения о преподавателях")
                {
                    b2 = false;
                }
                acchild.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextMenu contextMenu1;
            MenuItem menuItem1;
            contextMenu1 = new ContextMenu();
            menuItem1 = new MenuItem();
            contextMenu1.MenuItems.Add("Развернуть", menuItem1_Click1);
            contextMenu1.MenuItems.Add("Выход", menuItem1_Click2);
            
            notifyIcon1.ContextMenu = contextMenu1;
        }
        private void menuItem1_Click1(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
        private void menuItem1_Click2(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы точно хотите выйти?", "", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void свернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
        public void child(string str)
        {
            Form2 form2 = new Form2(str);
            form2.MdiParent = this;
            form2.LayoutMdi(MdiLayout.Cascade);
            form2.Show();
        }
    }
}
