using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataApp
{

    public partial class Form2 : Form
    {
        public static SqlConnection connection = new SqlConnection(Form1.connectionString);
        public static DataTable dataTable = new DataTable();


        void openConnection()
        {
            connection.Open();
        }
        void closeConnection()
        {
            connection.Close();
        }
        public void fetchData()
        {
            string query = "SELECT EncId, ClienteId, Data, Total, TimestampEnc FROM Encomenda"; // Include TimestampEnc
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            try
            {
                dataTable.Rows.Clear();
                adapter.Fill(dataTable);

                // Create a new DataTable for the DataGridView that doesn't include the TimestampEnc column
                DataTable dataGridViewDataTable = dataTable.Copy();
                dataGridViewDataTable.Columns.Remove("TimestampEnc");

                dataGridView1.DataSource = dataGridViewDataTable; // Binding the DataGridView to the DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fetchData();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            closeConnection();  
        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            openConnection();
            string updateQuery = "UPDATE Encomenda SET Total = " + textBox6.Text + " WHERE EncId = " + textBox5.Text + "";
            SqlCommand command = new SqlCommand(updateQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();

            fetchData();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            //DELETE

            connection.Open();
            string deleteQuery = "DELETE FROM Encomenda WHERE EncId = " + textBox4.Text + " ";
            SqlCommand command = new SqlCommand(deleteQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();

            fetchData();
        }

        private void InserirBtn_Click(object sender, EventArgs e)
        {
            //INSERT   
            string dateString = dateTimePicker1.Text;
            string InsertQuery = "";

            if (DateTime.TryParse(dateString, out DateTime selectedDate))
            {
                // Format the date to match SQL Server's date format
                string formattedDate = selectedDate.ToString("yyyy-MM-dd");
                InsertQuery = "INSERT INTO Encomenda(EncId , ClienteId, Data, Total) VALUES (" + textBox2.Text + ", '" + textBox1.Text + "', '" + formattedDate + "', " + textBox3.Text + ");";

                // Now you can use formattedDate in your SQL query
            }

            connection.Open();
            SqlCommand command = new SqlCommand(InsertQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();

            fetchData();

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 =new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
