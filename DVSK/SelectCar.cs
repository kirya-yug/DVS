using System;
using System.Text;
using System.Windows.Forms;

namespace DVSK
{
    public partial class SelectCar : Form
    {
        public SelectCar()
        {
            InitializeComponent();
        }

        private void ГосНомер_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                dataGridView1.ColumnCount = 4;
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.Columns[0].Name = "Марка";
                dataGridView1.Columns[1].Name = "ГосНомер";
                dataGridView1.Columns[2].Name = "Вин Номер";
                dataGridView1.Columns[3].Name = "История";

                sqlSelectCommand1.Parameters["@LP"].Value = textBox1.Text;

                sqlSelectCommand1.ExecuteNonQuery();
                System.Data.SqlClient.SqlDataReader reader = sqlSelectCommand1.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {


                        string Mark = reader.GetString(1);
                        string LP = reader.GetString(2);
                        string CarNum = reader.GetString(3);
                        string story = reader.GetString(4);
                        dataGridView1.Rows.Add(Mark, LP, CarNum, story);
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
            SelectCar_Load(null, null);
        }

        private void SelectCar_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
