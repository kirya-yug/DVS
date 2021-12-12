using System;
using System.Windows.Forms;

namespace DVSK
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                sqlInsertCommand1.Parameters["@Mark"].Value = textBox1.Text;
                sqlInsertCommand1.Parameters["@LP"].Value = textBox2.Text;
                sqlInsertCommand1.Parameters["@CarNum"].Value = textBox3.Text;
                sqlInsertCommand1.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Уже есть");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }

            sqlConnection1.Close();
        }
    }
}
