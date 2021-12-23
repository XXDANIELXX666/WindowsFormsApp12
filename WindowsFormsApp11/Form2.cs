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
    public partial class Form2 : Form
    {
        string constr = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=YP;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        int ID;

        public void CO(string sql)
        {

            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public Form2(int IdOrder)
        {
            InitializeComponent();
            con.ConnectionString = constr;
            cmd.Connection = con;
            ID = IdOrder;
            cmd.CommandText = "SELECT ЗАКАЗ.[Номер заказа],Клиенты.Организация, Услуги.[Наименование услуги], ЗАКАЗ.[Дата заказа], Сотрудники.ФИО, ЗАКАЗ.Цена FROM ЗАКАЗ inner join Клиенты on ЗАКАЗ.[Код организации]= Клиенты.[Код  Организации] inner join Услуги ON ЗАКАЗ.[Код улсуги]=Услуги.[Код услуги] inner join Сотрудники ON ЗАКАЗ.[Код сотрудника] = Сотрудники.[Код сотрудника]=where [Номер заказа] = " + ID;
        }

            private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string month1 = dateTimePicker1.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Month.ToString() : dateTimePicker1.Value.Month.ToString();
            string day1 = dateTimePicker1.Value.Day.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Day.ToString() : dateTimePicker1.Value.Day.ToString();
            string datest = dateTimePicker1.Value.Year + "" + month1 + "" + day1;
            cmd.CommandText = "update ЗАКАЗ set [Номер заказа] ='" + Convert.ToInt32(textBox5.Text) + "', [Код организации] = '" + comboBox2.SelectedValue + "', [Код улсуги] = '" + comboBox3.SelectedValue + "', [Дата заказа] ='" + datest + "', [Код сотрудника] = '" + comboBox4.SelectedValue + "', Цена = '" + textBox6.Text + "' where [Номер заказа] = " + ID;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Измененно");
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet8.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter1.Fill(this.yPDataSet8.Услуги);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.yPDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.yPDataSet.Сотрудники);

        }
    }
}
