using System;
using System.Linq;
using System.Windows.Forms;

namespace DVSK
{
    public partial class WatchCar : Form
    {
        public WatchCar()
        {
            InitializeComponent();
        }

        private void WatchCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dVSDataSet3.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.dVSDataSet3.Car);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCar AC = new AddCar();
            AC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new DBDVS.DVSEntities2())
            {

                var car = context.Car.ToArray();

                dataGridView1.ColumnCount = 5;
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Марка";
                dataGridView1.Columns[2].Name = "ГосНомер";
                dataGridView1.Columns[3].Name = "ВинНомер";
                dataGridView1.Columns[4].Name = "История обслуживания";

                foreach (var rec in car)
                {
                    dataGridView1.Rows.Add(rec.Id, rec.Mark, rec.LP, rec.CarNum, rec.Story);
                }
            }
            WatchCar_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStory AC = new AddStory();
            AC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectCar AC = new SelectCar();
            AC.Show();
        }
    }
}
