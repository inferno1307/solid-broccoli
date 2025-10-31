using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RT
{
    public partial class rasp1 : Form
    {
        public rasp1()
        {
            InitializeComponent();
        }

        private void rasp1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rtDataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.rtDataSet.Расписание);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
