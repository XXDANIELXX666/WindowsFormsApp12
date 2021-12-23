using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp11
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            DataSet ds = new DataSet();
            string sql = "SELECT * From Сотрудники";
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.yPDataSet.Сотрудники);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            string sql = "Insert into Сотрудники ([Код сотрудника], ФИО, Телефон, Отдел, [Код должности]) Values (N'" + textBox1.Text + "',N'" + textBox2.Text + "', N'" + textBox3.Text + "', N'" + textBox4.Text + "', N'" + textBox5.Text + "')";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables["Сотрудники"];
            }
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            DataSet ds = new DataSet();
            string sql = "SELECT * From Сотрудники";
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from Сотрудники where [Код сотрудника] = " + dataGridView1.CurrentRow.Cells[0].Value;
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                sql = "SELECT * From Сотрудники";
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }
    }
}
