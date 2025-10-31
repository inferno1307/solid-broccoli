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
    public partial class sot1 : Form
    {
        public sot1()
        {
            InitializeComponent();
        }

        private void sot1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rtDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.rtDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
