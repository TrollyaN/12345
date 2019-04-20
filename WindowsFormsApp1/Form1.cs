using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Menedger". При необходимости она может быть перемещена или удалена.
            this.menedgerTableAdapter.Fill(this.database1DataSet.Menedger);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Master". При необходимости она может быть перемещена или удалена.
            this.masterTableAdapter.Fill(this.database1DataSet.Master);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.database1DataSet.Klient);

        }

        private void klientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
