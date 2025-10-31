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
    public partial class DOB_sot : Form
    {
        public DOB_sot()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sot main = this.Owner as sot;
            if (main != null)
            {
                DataRow nRow = main.rtDataSet.Tables["Сотрудники"].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;
                main.rtDataSet.Tables["Сотрудники"].Rows.Add(nRow);
                main.сотрудникиTableAdapter.Update(main.rtDataSet.Сотрудники);
                main.rtDataSet.Tables["Сотрудники"].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
    }

