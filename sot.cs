using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RT.UsersDBDataSetTableAdapters;

namespace RT
{
    public partial class sot : Form
    {
        public sot()
        {
            InitializeComponent();
        }

        private void sot_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rtDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.rtDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникиTableAdapter.Update(rtDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            poisk1 af = new poisk1();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DOB_sot af = new DOB_sot();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
