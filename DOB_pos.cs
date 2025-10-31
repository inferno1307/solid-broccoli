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
    public partial class DOB_pos : Form
    {
        public DOB_pos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos main = this.Owner as pos;
            if (main != null)
            {
                DataRow nRow = main.rtDataSet.Tables["Посещаемость"].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = rc;
                nRow[2] = textBox1.Text;
                nRow[3] = textBox2.Text;
                nRow[4] = textBox3.Text;
                nRow[5] = textBox4.Text;
                main.rtDataSet.Tables["Посещаемость"].Rows.Add(nRow);
                main.посещаемостьTableAdapter.Update(main.rtDataSet.Посещаемость);
                main.rtDataSet.Tables["Посещаемость"].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
