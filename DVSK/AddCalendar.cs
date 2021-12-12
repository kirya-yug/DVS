using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DVSK
{
    public partial class AddCalendar : Form
    {
        public AddCalendar()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCalendar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dVSDataSet15.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter1.Fill(this.dVSDataSet15.Car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dVSDataSet14.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter1.Fill(this.dVSDataSet14.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dVSDataSet13.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.dVSDataSet13.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                sqlInsertCommand1.Parameters["@Date"].Value = dateTimePicker1.Text;
                sqlInsertCommand1.Parameters["@TypeWork"].Value = textBox2.Text;
                sqlInsertCommand1.Parameters["@EmpNum"].Value = comboBox2.Text;
                sqlInsertCommand1.Parameters["@CusNum"].Value = comboBox3.Text;
                sqlInsertCommand1.Parameters["@CarNum"].Value = comboBox1.Text;

                sqlInsertCommand1.ExecuteNonQuery();
                textBox2.Clear();

            }
            catch (SqlException)
            {
                MessageBox.Show("Уже есть");

                textBox2.Clear();
            }
            sqlConnection1.Close();
        }
    }
}
