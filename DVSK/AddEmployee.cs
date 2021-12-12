using System;
using System.Windows.Forms;

namespace DVSK
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dVSDataSet6.Employee". При необходимости она может быть перемещена или удалена.
            //this.employeeTableAdapter.Fill(this.dVSDataSet6.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                sqlInsertCommand1.Parameters["@EmName"].Value = textBox1.Text;
                sqlInsertCommand1.Parameters["@PassNum"].Value = textBox2.Text;
                sqlInsertCommand1.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Уже есть");
                textBox1.Clear();
                textBox2.Clear();
            }

            sqlConnection1.Close();
        }
    }
}
