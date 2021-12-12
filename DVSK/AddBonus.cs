using System;
using System.Windows.Forms;

namespace DVSK
{
    public partial class AddBonus : Form
    {
        public AddBonus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int val = rnd.Next(0, 100000);
            sqlConnection1.Open();
            try
            {
                sqlUpdateCommand1.Parameters["@TelNumber"].Value = textBox1.Text;
                sqlUpdateCommand1.Parameters["@CardNum"].Value = Convert.ToString(val);
                sqlUpdateCommand1.ExecuteNonQuery();
                textBox1.Clear();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Уже есть");
                textBox1.Clear();
            }

            sqlConnection1.Close();
        }
    }
}
