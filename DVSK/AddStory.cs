using System;
using System.Windows.Forms;

namespace DVSK
{
    public partial class AddStory : Form
    {
        public AddStory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                sqlUpdateCommand1.Parameters["@LP"].Value = textBox1.Text;
                sqlUpdateCommand1.Parameters["@Story"].Value = (" " + textBox2.Text);
                sqlUpdateCommand1.ExecuteNonQuery();
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
