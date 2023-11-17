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
        public SqlConnection connection = new SqlConnection(Form1.connectionString);
     


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
            string query = "SELECT * FROM Encomenda";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable; // Binding the DataGridView to the DataTable
                connection.Close() ;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //muito obrigado ChatGPT 
        private void SaveChangesToDatabase()
        {
            try
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string tableName = "Encomenda"; // Change this to other table names as needed

                        string idColumnName = "EncId"; // Change this to other primary key column names as needed

                        // Check if the row already exists in the database
                        string checkQuery = $"SELECT COUNT(*) FROM {tableName} WHERE {idColumnName} = @{idColumnName}";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                        checkCommand.Parameters.AddWithValue($"@{idColumnName}", row.Cells[idColumnName].Value);

                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            // Row already exists, perform an UPDATE
                            string updateQuery = $"UPDATE {tableName} SET ";

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string columnName = cell.OwningColumn.Name;
                                if (columnName != idColumnName) // Skip the primary key column in the update query
                                {
                                    updateQuery += $"{columnName} = @{columnName}, ";
                                }
                            }

                            // Remove the trailing comma and space
                            updateQuery = updateQuery.TrimEnd(',', ' ');

                            updateQuery += $" WHERE {idColumnName} = @{idColumnName}";

                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string columnName = cell.OwningColumn.Name;
                                if (columnName != idColumnName)
                                {
                                    updateCommand.Parameters.AddWithValue($"@{columnName}", cell.Value);
                                }
                            }

                            updateCommand.Parameters.AddWithValue($"@{idColumnName}", row.Cells[idColumnName].Value);

                            updateCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            // Row doesn't exist, perform an INSERT
                            string insertQuery = $"INSERT INTO {tableName} (";

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                insertQuery += $"{column.Name}, ";
                            }

                            // Remove the trailing comma and space
                            insertQuery = insertQuery.TrimEnd(',', ' ');

                            insertQuery += ") VALUES (";

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                insertQuery += $"@{cell.OwningColumn.Name}, ";
                            }

                            // Remove the trailing comma and space
                            insertQuery = insertQuery.TrimEnd(',', ' ');

                            insertQuery += ")";

                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                insertCommand.Parameters.AddWithValue($"@{cell.OwningColumn.Name}", cell.Value);
                            }

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                connection.Close();
                fetchData(); // Refresh the DataGridView with updated data after saving to the database
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

            domainUpDown1.Items.Add("Connected");
            domainUpDown1.Items.Add("Disconnected");
            domainUpDown1.Text = "Connected";

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
            //UPDATE
            if (domainUpDown1.Text== "Connected")
            {
                openConnection();
                string updateQuery = "UPDATE Encomenda SET Total = " + textBox6.Text + " WHERE EncId = " + textBox5.Text + "";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();

                fetchData();
            }
            if (domainUpDown1.Text== "Disconnected")
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;

                // Check if the selected row is valid
                if (selectedIndex >= 0 && selectedIndex < dataGridView1.Rows.Count)
                {
                    // Update the DataGridView cell with the new value
                    dataGridView1.Rows[selectedIndex].Cells["Total"].Value = textBox6.Text;
                }
            }
           
        
        }

        private void button5_Click(object sender, EventArgs e)
        {


            //DELETE

            if (domainUpDown1.Text == "Connected")
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Encomenda WHERE EncId = " + textBox4.Text + " ";
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();

                fetchData();
            }
            if (domainUpDown1.Text == "Disconnected")
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;

                // Check if the selected row is valid
                if (selectedIndex >= 0 && selectedIndex < dataGridView1.Rows.Count)
                {
                    // Remove the selected row from the DataGridView
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
            }
        }

        private void InserirBtn_Click(object sender, EventArgs e)
        {
            //INSERT   
            string dateString = dateTimePicker1.Text;
            string deleteQuery = "";
            if (domainUpDown1.Text == "Connected")
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();

                fetchData();
            }
            if (domainUpDown1.Text == "Disconnected")
            {
                if (DateTime.TryParse(dateString, out DateTime selectedDate))
                {
                    // Format the date to match SQL Server's date format
                    string formattedDate = selectedDate.ToString("yyyy-MM-dd");
                    deleteQuery = "INSERT INTO Encomenda(EncId , ClienteId, Data, Total) VALUES (" + textBox2.Text + ", '" + textBox1.Text + "', '" + formattedDate + "', " + textBox3.Text + ");";

                    // Now you can use formattedDate in your SQL query
                }
                dataGridView1.Rows.Add(textBox2.Text, textBox1.Text, deleteQuery, textBox3.Text);
            }

        }

        private void SendDataBtn_Click(object sender, EventArgs e)
        {
            SaveChangesToDatabase();
            
        }
    }
}
