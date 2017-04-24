namespace DataBase
{
    partial class Cena
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
            this.komnataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countZP1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zP2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainBaseDataSet = new DataBase.MainBaseDataSet();
            this.zP_2TableAdapter = new DataBase.MainBaseDataSetTableAdapters.ZP_2TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zP2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.komnataDataGridViewTextBoxColumn,
            this.countZP1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zP2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 140);
            this.dataGridView1.TabIndex = 0;
            // 
            // komnataDataGridViewTextBoxColumn
            // 
            this.komnataDataGridViewTextBoxColumn.DataPropertyName = "Komnata";
            this.komnataDataGridViewTextBoxColumn.HeaderText = "Komnata";
            this.komnataDataGridViewTextBoxColumn.Name = "komnataDataGridViewTextBoxColumn";
            // 
            // countZP1DataGridViewTextBoxColumn
            // 
            this.countZP1DataGridViewTextBoxColumn.DataPropertyName = "Count - ZP_1";
            this.countZP1DataGridViewTextBoxColumn.HeaderText = "Count - ZP_1";
            this.countZP1DataGridViewTextBoxColumn.Name = "countZP1DataGridViewTextBoxColumn";
            // 
            // zP2BindingSource
            // 
            this.zP2BindingSource.DataMember = "ZP_2";
            this.zP2BindingSource.DataSource = this.mainBaseDataSet;
            // 
            // mainBaseDataSet
            // 
            this.mainBaseDataSet.DataSetName = "MainBaseDataSet";
            this.mainBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zP_2TableAdapter
            // 
            this.zP_2TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "*данна форма еще не позволяет производить расчеты стоимости!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Требуються дынные. Ждите следуещего обновления программы";
            // 
            // Cena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cena";
            this.Text = "Cena";
            this.Load += new System.EventHandler(this.Cena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zP2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MainBaseDataSet mainBaseDataSet;
        private System.Windows.Forms.BindingSource zP2BindingSource;
        private MainBaseDataSetTableAdapters.ZP_2TableAdapter zP_2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn komnataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countZP1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}