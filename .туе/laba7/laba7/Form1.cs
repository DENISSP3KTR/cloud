using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba7;
using Npgsql;
namespace laba7
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        NpgsqlDataAdapter da = null;
        DataTable table = null;
        public Form1()
        {
            InitializeComponent();
            db.opencon();
            da = new NpgsqlDataAdapter("select distinct city, univ_id from lectures", db.GetConnection());
            table = new DataTable();
            da.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "city";
            comboBox1.ValueMember = "univ_id";
            comboBox1.SelectedIndex = -1;
            db.closecon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = "Преподы";
            string whereStr = String.Format("where lectures.city='{0}' and university.univ_id=lectures.univ_id",this.comboBox1.Text);
            string query = String.Format("select lectures.surname as Фамилия, lectures.name as Имя, lectures.city as Город, university.univ_name as Университет from lectures, university " + " {0}", whereStr);
            db.opencon();
            da = new NpgsqlDataAdapter(query, db.GetConnection());
            table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            db.closecon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "Студенты";
            table = new DataTable();
            table.Clear();
            db.opencon();
            da = new NpgsqlDataAdapter("select student.surname as Фамилия, student.name as Имя, university.univ_name as Университет from student, university where student.univ_id=university.univ_id;", db.GetConnection());
            da.Fill(table);
            dataGridView1.DataSource = table;
            db.closecon();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label3.Text = "Идентификационный номер: ";
            label4.Text = "Курс: ";
            label5.Text = "Место проживания: ";
            label6.Text = "Дата рождения: ";
            if (label8.Text == "Студенты" && dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                table = new DataTable();
                table.Clear();
                db.opencon();
                string whereStr1 = String.Format("where surname='{0}' ", dataGridView1.CurrentCell.Value.ToString());
                string whereStr2 = String.Format("and name='{0}';", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                string whereStr = whereStr1 + whereStr2;
                string query = String.Format("select student_id, kurs, city, birthday from student" + " {0}", whereStr);
                NpgsqlCommand comm = new NpgsqlCommand(query, db.GetConnection());
                da = new NpgsqlDataAdapter(comm);
                da.Fill(table);
                NpgsqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    label3.Text += dr["student_id"].ToString();
                    label4.Text += dr["kurs"].ToString();
                    label5.Text += dr["city"].ToString();
                    label6.Text += dr["birthday"].ToString();
                }
                db.closecon();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent frm = new AddStudent();
            frm.ShowDialog();
        }
    }
}
