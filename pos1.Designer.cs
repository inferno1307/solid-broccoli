namespace RT
{
    partial class pos1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rtDataSet = new RT.rtDataSet();
            this.посещаемостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.посещаемостьTableAdapter = new RT.rtDataSetTableAdapters.ПосещаемостьTableAdapter();
            this.idпосещаемостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПриходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяУходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.причинаОтсутсвияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещаемостьBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idпосещаемостьDataGridViewTextBoxColumn,
            this.idсотрудникаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.времяПриходаDataGridViewTextBoxColumn,
            this.времяУходаDataGridViewTextBoxColumn,
            this.причинаОтсутсвияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.посещаемостьBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // rtDataSet
            // 
            this.rtDataSet.DataSetName = "rtDataSet";
            this.rtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // посещаемостьBindingSource
            // 
            this.посещаемостьBindingSource.DataMember = "Посещаемость";
            this.посещаемостьBindingSource.DataSource = this.rtDataSet;
            // 
            // посещаемостьTableAdapter
            // 
            this.посещаемостьTableAdapter.ClearBeforeFill = true;
            // 
            // idпосещаемостьDataGridViewTextBoxColumn
            // 
            this.idпосещаемостьDataGridViewTextBoxColumn.DataPropertyName = "id_посещаемость";
            this.idпосещаемостьDataGridViewTextBoxColumn.HeaderText = "id_посещаемость";
            this.idпосещаемостьDataGridViewTextBoxColumn.Name = "idпосещаемостьDataGridViewTextBoxColumn";
            // 
            // idсотрудникаDataGridViewTextBoxColumn
            // 
            this.idсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.HeaderText = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.Name = "idсотрудникаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // времяПриходаDataGridViewTextBoxColumn
            // 
            this.времяПриходаDataGridViewTextBoxColumn.DataPropertyName = "Время прихода";
            this.времяПриходаDataGridViewTextBoxColumn.HeaderText = "Время прихода";
            this.времяПриходаDataGridViewTextBoxColumn.Name = "времяПриходаDataGridViewTextBoxColumn";
            // 
            // времяУходаDataGridViewTextBoxColumn
            // 
            this.времяУходаDataGridViewTextBoxColumn.DataPropertyName = "Время ухода";
            this.времяУходаDataGridViewTextBoxColumn.HeaderText = "Время ухода";
            this.времяУходаDataGridViewTextBoxColumn.Name = "времяУходаDataGridViewTextBoxColumn";
            // 
            // причинаОтсутсвияDataGridViewTextBoxColumn
            // 
            this.причинаОтсутсвияDataGridViewTextBoxColumn.DataPropertyName = "Причина отсутсвия";
            this.причинаОтсутсвияDataGridViewTextBoxColumn.HeaderText = "Причина отсутсвия";
            this.причинаОтсутсвияDataGridViewTextBoxColumn.Name = "причинаОтсутсвияDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "pos1";
            this.Text = "pos1";
            this.Load += new System.EventHandler(this.pos1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещаемостьBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private rtDataSet rtDataSet;
        private System.Windows.Forms.BindingSource посещаемостьBindingSource;
        private rtDataSetTableAdapters.ПосещаемостьTableAdapter посещаемостьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idпосещаемостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПриходаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяУходаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаОтсутсвияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}