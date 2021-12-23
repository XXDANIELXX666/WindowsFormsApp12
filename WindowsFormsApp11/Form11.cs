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

    public partial class Form11 : Form
    {
        

        public Form11()
        {
            InitializeComponent();
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            DataSet ds = new DataSet();
            string sql = "SELECT * From [Клиенты]";
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form11_Load(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            string sql = "Insert into [Клиенты] (Организация,Город,Адресс,Телефон,ФИО,[Код записи]) Values (N'" + textBox2.Text + "', N'" + textBox3.Text + "', N'" + textBox4.Text + "', N'" + textBox5.Text + "', N'" + textBox6.Text + "',N'" + textBox1.Text + "')";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables["Клиенты"];
            }
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from [Клиенты] where [Код Организации] = " + dataGridView1.CurrentRow.Cells[0].Value;
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                sql = "SELECT * From [Клиенты]";
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            DataSet ds = new DataSet();
            string sql = "SELECT * From Клиенты";
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
