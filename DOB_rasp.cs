using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RT
{
    public partial class DOB_rasp : Form
    {
        public DOB_rasp()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rasp main = this.Owner as rasp;
            if (main != null)
            {
                DataRow nRow = main.rtDataSet.Tables["Расписание"].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = rc;
                nRow[2] = textBox1.Text;
                nRow[3] = textBox2.Text;
                nRow[4] = textBox3.Text;

                main.rtDataSet.Tables["Расписание"].Rows.Add(nRow);
                main.расписаниеTableAdapter.Update(main.rtDataSet.Расписание);
                main.rtDataSet.Tables["Расписание"].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
