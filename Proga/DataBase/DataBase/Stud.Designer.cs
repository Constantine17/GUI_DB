namespace DataBase
{
    partial class Stud
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
            this.mainBaseDataSet = new DataBase.MainBaseDataSet();
            this.glavstudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glav_studTableAdapter = new DataBase.MainBaseDataSetTableAdapters.Glav_studTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaselenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viezdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komnataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.добовлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavstudBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.pasportDataGridViewTextBoxColumn,
            this.tipeDataGridViewTextBoxColumn,
            this.zaselenieDataGridViewTextBoxColumn,
            this.viezdDataGridViewTextBoxColumn,
            this.komnataDataGridViewTextBoxColumn,
            this.добовлениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.glavstudBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mainBaseDataSet
            // 
            this.mainBaseDataSet.DataSetName = "MainBaseDataSet";
            this.mainBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // glavstudBindingSource
            // 
            this.glavstudBindingSource.DataMember = "Glav_stud";
            this.glavstudBindingSource.DataSource = this.mainBaseDataSet;
            // 
            // glav_studTableAdapter
            // 
            this.glav_studTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // pasportDataGridViewTextBoxColumn
            // 
            this.pasportDataGridViewTextBoxColumn.DataPropertyName = "Pasport";
            this.pasportDataGridViewTextBoxColumn.HeaderText = "Pasport";
            this.pasportDataGridViewTextBoxColumn.Name = "pasportDataGridViewTextBoxColumn";
            // 
            // tipeDataGridViewTextBoxColumn
            // 
            this.tipeDataGridViewTextBoxColumn.DataPropertyName = "Tipe";
            this.tipeDataGridViewTextBoxColumn.HeaderText = "Tipe";
            this.tipeDataGridViewTextBoxColumn.Name = "tipeDataGridViewTextBoxColumn";
            // 
            // zaselenieDataGridViewTextBoxColumn
            // 
            this.zaselenieDataGridViewTextBoxColumn.DataPropertyName = "Zaselenie";
            this.zaselenieDataGridViewTextBoxColumn.HeaderText = "Zaselenie";
            this.zaselenieDataGridViewTextBoxColumn.Name = "zaselenieDataGridViewTextBoxColumn";
            // 
            // viezdDataGridViewTextBoxColumn
            // 
            this.viezdDataGridViewTextBoxColumn.DataPropertyName = "Viezd";
            this.viezdDataGridViewTextBoxColumn.HeaderText = "Viezd";
            this.viezdDataGridViewTextBoxColumn.Name = "viezdDataGridViewTextBoxColumn";
            // 
            // komnataDataGridViewTextBoxColumn
            // 
            this.komnataDataGridViewTextBoxColumn.DataPropertyName = "Komnata";
            this.komnataDataGridViewTextBoxColumn.HeaderText = "Komnata";
            this.komnataDataGridViewTextBoxColumn.Name = "komnataDataGridViewTextBoxColumn";
            // 
            // добовлениеDataGridViewTextBoxColumn
            // 
            this.добовлениеDataGridViewTextBoxColumn.DataPropertyName = "Добовление";
            this.добовлениеDataGridViewTextBoxColumn.HeaderText = "Добовление";
            this.добовлениеDataGridViewTextBoxColumn.Name = "добовлениеDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сахранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(907, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stud";
            this.Text = "Проживающие";
            this.Load += new System.EventHandler(this.Stud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavstudBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MainBaseDataSet mainBaseDataSet;
        private System.Windows.Forms.BindingSource glavstudBindingSource;
        private MainBaseDataSetTableAdapters.Glav_studTableAdapter glav_studTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaselenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viezdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn komnataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn добовлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}