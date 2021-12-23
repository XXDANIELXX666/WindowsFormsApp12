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
    public partial class Form1 : Form
    {
        static string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
        SqlConnection cod = new SqlConnection();
        SqlCommand cmt = new SqlCommand();

        public void CO(string sql)
        {
            
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        

        public Form1()
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            InitializeComponent();
            string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            DataSet ds = new DataSet();
            string sql = "SELECT ЗАКАЗ.[Номер заказа],Клиенты.Организация, Услуги.[Наименование услуги], ЗАКАЗ.[Дата заказа], Сотрудники.ФИО, ЗАКАЗ.Цена FROM ЗАКАЗ inner join Клиенты on ЗАКАЗ.[Код организации]= Клиенты.[Код  Организации] inner join Услуги ON ЗАКАЗ.[Код улсуги]=Услуги.[Код услуги] inner join Сотрудники ON ЗАКАЗ.[Код сотрудника] = Сотрудники.[Код сотрудника]";
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            comboBox1.SelectedIndex = 2;
            cod.ConnectionString = constr;
            cmt.Connection = cod;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet8.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter2.Fill(this.yPDataSet8.Услуги);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet7._Записать_на_услугу_". При необходимости она может быть перемещена или удалена.
            this.записать_на_услугу_TableAdapter1.Fill(this.yPDataSet7._Записать_на_услугу_);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.yPDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.yPDataSet.Клиенты);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet.ЗАКАЗ". При необходимости она может быть перемещена или удалена.
            this.зАКАЗTableAdapter.Fill(this.yPDataSet.ЗАКАЗ);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string month1 = dateTimePicker1.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Month.ToString() : dateTimePicker1.Value.Month.ToString();
            string day1 = dateTimePicker1.Value.Day.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Day.ToString() : dateTimePicker1.Value.Day.ToString();
            string datest = dateTimePicker1.Value.Year + "" + month1 + "" + day1;
            cod.Open();
            cmt.CommandText = "insert into ЗАКАЗ values (N'" + textBox5.Text + "','" + comboBox2.SelectedValue + "', N'" + comboBox3.SelectedValue + "', '" + datest + "', '" + comboBox4.SelectedValue + "', '" + textBox6.Text + "' )";
            cmt.ExecuteNonQuery();
            cod.Close();
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql = "DELETE from ЗАКАЗ where[Номер заказа]= " + dataGridView1.CurrentRow.Cells[0].Value;
                    string constring = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
                    using (SqlConnection col = new SqlConnection(constring))
                    {
                        col.Open();
                        SqlCommand cmdd = new SqlCommand(sql, col);
                        sql = "SELECT * from ЗАКАЗ";
                        cmdd.ExecuteNonQuery();
                        DataSet ds = new DataSet();
                        SqlDataAdapter ad = new SqlDataAdapter(sql, constring);
                        ad.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        col.Close();
                    }
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
            string sql = "SELECT ЗАКАЗ.[Номер заказа],Клиенты.Организация, Услуги.[Наименование услуги], ЗАКАЗ.[Дата заказа], Сотрудники.ФИО, ЗАКАЗ.Цена FROM ЗАКАЗ inner join Клиенты on ЗАКАЗ.[Код организации]= Клиенты.[Код  Организации] inner join Услуги ON ЗАКАЗ.[Код улсуги]=Услуги.[Код услуги] inner join Сотрудники ON ЗАКАЗ.[Код сотрудника] = Сотрудники.[Код сотрудника]";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox7.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                        dataGridView1.Rows[i].Selected = false;
                    }
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "SELECT ЗАКАЗ.[Номер заказа],Клиенты.Организация, Услуги.[Наименование услуги], ЗАКАЗ.[Дата заказа], Сотрудники.ФИО, ЗАКАЗ.Цена FROM ЗАКАЗ inner join Клиенты on ЗАКАЗ.[Код организации]= Клиенты.[Код  Организации] inner join Услуги ON ЗАКАЗ.[Код улсуги]=Услуги.[Код услуги] inner join Сотрудники ON ЗАКАЗ.[Код сотрудника] = Сотрудники.[Код сотрудника] where Клиенты.Организация  Like N'%" + textBox8.Text + "%' OR  Сотрудники.ФИО Like N'%" + textBox8.Text + "%'";
            CO(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void организацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 zap = new Form11();
            zap.Show();
            this.Hide();
        }

        private void наименованиеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 zap = new Form12();
            zap.Show();
            this.Hide();
        }

        private void фИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 zap = new Form13();
            zap.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

