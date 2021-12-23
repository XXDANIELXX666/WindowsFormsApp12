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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yPDataSet3.Разработка_и_сопровождение_сайтов". При необходимости она может быть перемещена или удалена.
            this.разработка_и_сопровождение_сайтовTableAdapter.Fill(this.yPDataSet3.Разработка_и_сопровождение_сайтов);

        }

        private void Выход_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
