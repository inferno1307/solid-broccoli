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
    public partial class pos1 : Form
    {
        public pos1()
        {
            InitializeComponent();
        }

        private void pos1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rtDataSet.Посещаемость". При необходимости она может быть перемещена или удалена.
            this.посещаемостьTableAdapter.Fill(this.rtDataSet.Посещаемость);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
