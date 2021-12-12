using System;
using System.Linq;
using System.Windows.Forms;
using DBDVS;

namespace DVSK
{
    public partial class WatchCustomer : Form
    {
        public WatchCustomer()
        {
            InitializeComponent();
        }

        private void WatchCustomer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dVSDataSet5.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter1.Fill(this.dVSDataSet5.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer AC = new AddCustomer();
            AC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBonus AB = new AddBonus();
            AB.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new DBDVS.DVSEntities2())
            {

                var customer = context.Customer.ToArray();

                dataGridView1.ColumnCount = 4;
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "ФИО";
                dataGridView1.Columns[2].Name = "Номер телефона";
                dataGridView1.Columns[3].Name = "Номер карты";

                foreach (var rec in customer)
                {
                    dataGridView1.Rows.Add(rec.Id, rec.Name, rec.TelNumber, rec.CardNum);
                }
            }
            WatchCustomer_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectCustomer SC = new SelectCustomer();
            SC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteCustomer DC = new DeleteCustomer();
            DC.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
