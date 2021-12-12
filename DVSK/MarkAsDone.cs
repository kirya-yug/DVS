using System;
using System.Windows.Forms;

namespace DVSK
{
    public partial class MarkAsDone : Form
    {
        public MarkAsDone()
        {
            InitializeComponent();
        }

        private void MarkAsDone_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dVSDataSet21.Calendar". При необходимости она может быть перемещена или удалена.
            this.calendarTableAdapter.Fill(this.dVSDataSet21.Calendar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                sqlDeleteCommand1.Parameters["@Id"].Value = comboBox1.Text;

                sqlDeleteCommand1.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Что-то не так");
            }
            sqlConnection1.Close();
        }
    }
}
