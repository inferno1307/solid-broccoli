namespace RT
{
    partial class rasp1
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
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеTableAdapter = new RT.rtDataSetTableAdapters.РасписаниеTableAdapter();
            this.idрасписаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.графикРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idрасписаниеDataGridViewTextBoxColumn,
            this.idсотрудникаDataGridViewTextBoxColumn,
            this.графикРаботыDataGridViewTextBoxColumn,
            this.времяНачалаDataGridViewTextBoxColumn,
            this.времяОкончанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.расписаниеBindingSource;
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
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.rtDataSet;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // idрасписаниеDataGridViewTextBoxColumn
            // 
            this.idрасписаниеDataGridViewTextBoxColumn.DataPropertyName = "id_расписание";
            this.idрасписаниеDataGridViewTextBoxColumn.HeaderText = "id_расписание";
            this.idрасписаниеDataGridViewTextBoxColumn.Name = "idрасписаниеDataGridViewTextBoxColumn";
            // 
            // idсотрудникаDataGridViewTextBoxColumn
            // 
            this.idсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.HeaderText = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.Name = "idсотрудникаDataGridViewTextBoxColumn";
            // 
            // графикРаботыDataGridViewTextBoxColumn
            // 
            this.графикРаботыDataGridViewTextBoxColumn.DataPropertyName = "График работы";
            this.графикРаботыDataGridViewTextBoxColumn.HeaderText = "График работы";
            this.графикРаботыDataGridViewTextBoxColumn.Name = "графикРаботыDataGridViewTextBoxColumn";
            // 
            // времяНачалаDataGridViewTextBoxColumn
            // 
            this.времяНачалаDataGridViewTextBoxColumn.DataPropertyName = "Время начала";
            this.времяНачалаDataGridViewTextBoxColumn.HeaderText = "Время начала";
            this.времяНачалаDataGridViewTextBoxColumn.Name = "времяНачалаDataGridViewTextBoxColumn";
            // 
            // времяОкончанияDataGridViewTextBoxColumn
            // 
            this.времяОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Время окончания";
            this.времяОкончанияDataGridViewTextBoxColumn.HeaderText = "Время окончания";
            this.времяОкончанияDataGridViewTextBoxColumn.Name = "времяОкончанияDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rasp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "rasp1";
            this.Text = "rasp1";
            this.Load += new System.EventHandler(this.rasp1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private rtDataSet rtDataSet;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private rtDataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idрасписаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn графикРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}