using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet3.Информационные_системы". При необходимости она может быть перемещена или удалена.
            this.информационные_системыTableAdapter.Fill(this.yPDataSet3.Информационные_системы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet3.Информационная_безопасность". При необходимости она может быть перемещена или удалена.
            this.информационная_безопасностьTableAdapter.Fill(this.yPDataSet3.Информационная_безопасность);

        }

        private void Выход_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
