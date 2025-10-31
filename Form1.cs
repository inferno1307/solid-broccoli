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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sot af = new sot();
            af.Owner = this;
            af.Show();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rasp af = new rasp();
            af.Owner = this;
            af.Show();
        }

        private void посещаемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos af = new pos();
            af.Owner = this;
            af.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPolz af = new FormPolz();
            af.Owner = this;
            af.Show();
        }
    }
}
