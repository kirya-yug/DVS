using System;
using System.Text;
using System.Windows.Forms;

namespace DVSK
{
    public partial class SelectCustomer : Form
    {
        public SelectCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.Columns[0].Name = "ФИО";
                dataGridView1.Columns[1].Name = "Номер телефона";
                dataGridView1.Columns[2].Name = "Номер бонусной карты";

                sqlSelectCommand1.Parameters["@TelNumber"].Value = textBox1.Text;

                sqlSelectCommand1.ExecuteNonQuery();
                System.Data.SqlClient.SqlDataReader reader = sqlSelectCommand1.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {


                        string Name = reader.GetString(1);
                        string TelNum = reader.GetString(2);
                        string CardNum = reader.GetString(3);
                        dataGridView1.Rows.Add(Name, TelNum, CardNum);
                    }
                }
                reader.Close();
            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }

            sqlConnection1.Close();
            SelectCustomer_Load(null, null);
        }

        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
