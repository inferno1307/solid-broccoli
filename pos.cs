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
    public partial class pos : Form
    {
        public pos()
        {
            InitializeComponent();
        }

        private void pos_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rtDataSet.Посещаемость". При необходимости она может быть перемещена или удалена.
            this.посещаемостьTableAdapter.Fill(this.rtDataSet.Посещаемость);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            посещаемостьTableAdapter.Update(rtDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            poisk3 af = new poisk3();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DOB_pos af = new DOB_pos();
            af.Owner = this;
            af.Show();
        }
    }
}
