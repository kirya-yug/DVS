using System;
using System.Windows.Forms;

namespace DVSK
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                sqlDeleteCommand1.Parameters["@Id"].Value = Convert.ToInt32(textBox1.Text);

                sqlDeleteCommand1.ExecuteNonQuery();
                textBox1.Clear();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Что-то не так");
                textBox1.Clear();
            }
            sqlConnection1.Close();
        }
    }
}
