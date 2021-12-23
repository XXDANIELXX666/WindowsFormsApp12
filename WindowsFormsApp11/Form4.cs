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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 zap = new Form6();
            zap.Show();
            
         }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 zap = new Form7();
            zap.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 zap = new Form8();
            zap.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 zap = new Form9();
            zap.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 zap = new Form10();
            zap.Show();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Выход_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 zap = new Form14();
            zap.Show();
            this.Hide();
        }
    }
}
