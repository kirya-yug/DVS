using System;
using System.Windows.Forms;

namespace DVSK
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int val = rnd.Next(0, 100000);
            sqlConnection1.Open();
            try
            {
                sqlInsertCommand1.Parameters["@Name"].Value = textBox1.Text;
                sqlInsertCommand1.Parameters["@TelNumber"].Value = textBox2.Text;
                if (radioButton1.Checked == true)
                {
                    sqlInsertCommand1.Parameters["@CardNum"].Value = Convert.ToString(val);
                }
                else
                {
                    sqlInsertCommand1.Parameters["@CardNum"].Value = 0;
                }
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
