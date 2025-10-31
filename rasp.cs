using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RT.rtDataSetTableAdapters;

namespace RT
{
    public partial class rasp : Form
    {
        public rasp()
        {
            InitializeComponent();
        }

        private void rasp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rtDataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.rtDataSet.Расписание);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            расписаниеTableAdapter.Update(rtDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            poisk2 af = new poisk2();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DOB_rasp af = new DOB_rasp();
            af.Owner = this;
            af.Show();
        }
    }
}
