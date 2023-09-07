using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba8;
using Npgsql;
using DataModels;
namespace laba8
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
            toolTip1.SetToolTip(this.button3, "Вывести сведения о студентах, фамилии, либо имена которых начинаются на «И».");
            toolTip1.SetToolTip(this.button4, "Вывести данные об оценках студентов второго курса, отсортированные по фамилии.");
            toolTip1.SetToolTip(this.button5, "Вывести фамилии преподавателей и названия предметов которые они ведут.");
            toolTip1.SetToolTip(this.button6, "Вывести фамилии и имена студентов, обучающихся на курсе не ниже 3 и получающих наибольшую стипендию.");
            toolTip1.SetToolTip(this.button7, "Рассчитать среднюю оценку студентов, полученную на экзамене по информатике.");
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

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (var bd = new Baza1DB())
            {
                var q =
                    (from c in bd.Students
                    where c.Name.StartsWith("И") || c.Surname.StartsWith("И")
                    select c).ToList();

                dataGridView1.DataSource = q;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var bd = new Baza1DB())
            {
                var q =
                    (from c in bd.Students
                     where c.Kurs == 2
                     orderby c.Surname
                     join p in bd.ExamMarks on c.StudentId equals p.StudentId
                     select new { c.Surname, p.Mark }).ToList();

                dataGridView1.DataSource = q;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            using (var bd = new Baza1DB())
            {
                var q =
                    (from c in bd.Lectures
                     join p in bd.Subjects on c.UnivId equals p.SubjId
                     select new { c.Surname, p.SubjName }).ToList();

                dataGridView1.DataSource = q;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            using (var bd = new Baza1DB())
            {
                var maxx = bd.Students.Select(c => c.Stipend).Max();
                var q =
                    (from c in bd.Students
                     where c.Kurs>2 && c.Stipend == maxx
                     select new {c.Name, c.Surname, c.Kurs, c.Stipend}).ToList();

                dataGridView1.DataSource = q;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var bd = new Baza1DB())
            {
                var q = bd.ExamMarks.Where(c => c.SubjId == 10).Select(c => c.Mark).Average();

                MessageBox.Show(q.ToString());
            }
        }
    }
}
