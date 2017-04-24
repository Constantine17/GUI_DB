namespace DataBase
{
    partial class Block
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
            this.komnatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komnatiTableAdapter = new DataBase.MainBaseDataSetTableAdapters.KomnatiTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolkomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komnatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.obshDataGridViewTextBoxColumn,
            this.kolkomDataGridViewTextBoxColumn,
            this.projivDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.komnatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainBaseDataSet
            // 
            this.mainBaseDataSet.DataSetName = "MainBaseDataSet";
            this.mainBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // komnatiBindingSource
            // 
            this.komnatiBindingSource.DataMember = "Komnati";
            this.komnatiBindingSource.DataSource = this.mainBaseDataSet;
            // 
            // komnatiTableAdapter
            // 
            this.komnatiTableAdapter.ClearBeforeFill = true;
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
            // obshDataGridViewTextBoxColumn
            // 
            this.obshDataGridViewTextBoxColumn.DataPropertyName = "Obsh";
            this.obshDataGridViewTextBoxColumn.HeaderText = "Obsh";
            this.obshDataGridViewTextBoxColumn.Name = "obshDataGridViewTextBoxColumn";
            // 
            // kolkomDataGridViewTextBoxColumn
            // 
            this.kolkomDataGridViewTextBoxColumn.DataPropertyName = "Kol_kom";
            this.kolkomDataGridViewTextBoxColumn.HeaderText = "Kol_kom";
            this.kolkomDataGridViewTextBoxColumn.Name = "kolkomDataGridViewTextBoxColumn";
            // 
            // projivDataGridViewTextBoxColumn
            // 
            this.projivDataGridViewTextBoxColumn.DataPropertyName = "Projiv";
            this.projivDataGridViewTextBoxColumn.HeaderText = "Projiv";
            this.projivDataGridViewTextBoxColumn.Name = "projivDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Block
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Block";
            this.Text = "Блоки";
            this.Load += new System.EventHandler(this.Block_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komnatiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MainBaseDataSet mainBaseDataSet;
        private System.Windows.Forms.BindingSource komnatiBindingSource;
        private MainBaseDataSetTableAdapters.KomnatiTableAdapter komnatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolkomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projivDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}