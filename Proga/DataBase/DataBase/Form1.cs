using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainBaseDataSet.ZP_2". При необходимости она может быть перемещена или удалена.
            this.zP_2TableAdapter.Fill(this.mainBaseDataSet.ZP_2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stud st = new Stud();
            st.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Block st2 = new Block();
            st2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cena st3 = new Cena();
            st3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Arhive st4 = new Arhive();
            st4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 st5 = new Form2();
            st5.ShowDialog();
        }
    }
}
