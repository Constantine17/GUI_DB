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
    public partial class Block : Form
    {
        public Block()
        {
            InitializeComponent();
        }

        private void Block_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainBaseDataSet.Komnati". При необходимости она может быть перемещена или удалена.
            this.komnatiTableAdapter.Fill(this.mainBaseDataSet.Komnati);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.komnatiTableAdapter.Update(this.mainBaseDataSet.Komnati);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
