using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace laba7
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsDigitsOnly(textBox1.Text) && IsDigitsOnly(textBox4.Text))
            {
                int stud_id = Convert.ToInt32(textBox1.Text);
                string fam = textBox2.Text;
                string name = textBox3.Text;
                double stipa = Convert.ToDouble(textBox4.Text);
                int kurs = Convert.ToInt32(numericUpDown1.Value);
                string home = textBox5.Text;
                DateTime date = dateTimePicker1.Value;
                int univ_id = Convert.ToInt32(comboBox1.SelectedValue);
                DB db = new DB();
                NpgsqlCommand comm = new NpgsqlCommand("insert into student(student_id, surname, name, stipend, kurs, city, birthday, univ_id) VALUES(@stud_id, @fam, @name, @stipa, @kurs, @city, @birth, @univ_id);", db.GetConnection());
                comm.Parameters.Add("@stud_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = stud_id;
                comm.Parameters.Add("@fam", NpgsqlTypes.NpgsqlDbType.Text).Value = fam;
                comm.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Text).Value = name;
                comm.Parameters.Add("@stipa", NpgsqlTypes.NpgsqlDbType.Double).Value = stipa;
                comm.Parameters.Add("@kurs", NpgsqlTypes.NpgsqlDbType.Integer).Value = kurs;
                comm.Parameters.Add("@city", NpgsqlTypes.NpgsqlDbType.Text).Value = home;
                comm.Parameters.Add("@birth", NpgsqlTypes.NpgsqlDbType.Date).Value = date;
                comm.Parameters.Add("@univ_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = univ_id;
                db.opencon();
                if (comm.ExecuteNonQuery() > 0)
                {
                    this.Hide();
                    MessageBox.Show("Вы успешно добавили");
                }
                else MessageBox.Show("Не удалось зарегистрироваться");
                db.closecon();
            }
            else
            {
                MessageBox.Show("Ошибочные данные");
            }

        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            db.opencon();
            NpgsqlDataAdapter da = null;
            DataTable table = null; 
            da = new NpgsqlDataAdapter("select distinct univ_id, univ_name from university", db.GetConnection());
            table = new DataTable();
            da.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "univ_name";
            comboBox1.ValueMember = "univ_id";
            comboBox1.SelectedIndex = -1;
            db.closecon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
