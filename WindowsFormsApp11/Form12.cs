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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            DataSet ds = new DataSet();
            string sql = "SELECT * From Услуги";
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.yPDataSet.Услуги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            string sql = "Insert into Услуги ([Код услуги], [Наименование услуги]) Values (N'" + textBox1.Text + "',N'" + textBox2.Text + "')";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables["Услуги"];
            }
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            DataSet ds = new DataSet();
            string sql = "SELECT * From Услуги";
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from Услуги where [Код услуги] = " + dataGridView1.CurrentRow.Cells[0].Value;
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                sql = "SELECT * From Услуги";
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
