using System;
using System.Linq;
using System.Windows.Forms;

namespace DVSK
{
    public partial class WatchCalendar : Form
    {
        public WatchCalendar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new DBDVS.DVSEntities2())
            {

                var cal = context.Calendar.ToArray();

                dataGridView1.ColumnCount = 6;
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Дата";
                dataGridView1.Columns[2].Name = "ID машины";
                dataGridView1.Columns[3].Name = "ID работника";
                dataGridView1.Columns[4].Name = "ID клиента";
                dataGridView1.Columns[5].Name = "Работа";

                foreach (var rec in cal)
                {
                    dataGridView1.Rows.Add(rec.Id, rec.Date, rec.CarId, rec.EmpId, rec.CusId, rec.TypeWork);
                }
            }
            WatchCalendar_Load(null, null);
        }

        private void WatchCalendar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dVSDataSet20.Calendar". При необходимости она может быть перемещена или удалена.
            this.calendarTableAdapter.Fill(this.dVSDataSet20.Calendar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCalendar AC = new AddCalendar();
            AC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteCalendar DC = new DeleteCalendar();
            DC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarkAsDone MSD = new MarkAsDone();
            MSD.Show();
        }
    }
}
