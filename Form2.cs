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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sot1 af = new sot1();
            af.Owner = this;
            af.Show();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rasp1 af = new rasp1();
            af.Owner = this;
            af.Show();
        }

        private void посещаемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos1 af = new pos1();
            af.Owner = this;
            af.Show();
        }
    }
}
