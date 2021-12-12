using System;
using System.Linq;
using System.Windows.Forms;
using DBDVS;
namespace DVSK
{
    public partial class WatchEmployee : Form
    {
        public WatchEmployee()
        {
            InitializeComponent();

            using(var context = new DBDVS.DVSEntities2())
            {

                var employee = context.Employee.ToArray();

                dataGridView1.ColumnCount = 3;
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "ФИО";
                dataGridView1.Columns[2].Name = "Номер договора";

                foreach (var rec in employee)
                {
                    dataGridView1.Rows.Add(rec.Id, rec.EmName, rec.PassNum);
                }
            }
            WatchEmployee_Load(null, null);
        }

        private void WatchEmployee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dVSDataSet7.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter1.Fill(this.dVSDataSet7.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee AE = new AddEmployee();
            AE.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new DBDVS.DVSEntities2())
            {

                var employee = context.Employee.ToArray();

                dataGridView1.ColumnCount = 3;
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "ФИО";
                dataGridView1.Columns[2].Name = "Номер договора";

                foreach (var rec in employee)
                {
                    dataGridView1.Rows.Add(rec.Id, rec.EmName, rec.PassNum);
                }
            }
            WatchEmployee_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteEmployee AE = new DeleteEmployee();
            AE.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
