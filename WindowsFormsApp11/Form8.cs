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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet3.Инфраструктура". При необходимости она может быть перемещена или удалена.
            this.инфраструктураTableAdapter.Fill(this.yPDataSet3.Инфраструктура);

        }

        private void Выход_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
