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
    public partial class Cena : Form
    {
        public Cena()
        {
            InitializeComponent();
        }

        private void Cena_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainBaseDataSet.ZP_2". При необходимости она может быть перемещена или удалена.
            this.zP_2TableAdapter.Fill(this.mainBaseDataSet.ZP_2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
