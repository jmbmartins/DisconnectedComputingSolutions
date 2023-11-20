using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleDataApp
{
    public partial class Form3 : Form
    {
        public DataTable dataTable = Form2.dataTable;

        public SqlConnection connection = new SqlConnection(Form1.connectionString);

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
                        string checkQuery = $"SELECT COUNT(*) FROM {tableName} WHERE {idColumnName} = @{idColumnName} AND TimestampEnc = @TimestampEnc";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                        checkCommand.Parameters.AddWithValue($"@{idColumnName}", row.Cells[idColumnName].Value);
                        checkCommand.Parameters.AddWithValue("@TimestampEnc", row.Cells["TimestampEnc"].Value);


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

                            updateQuery += $" WHERE {idColumnName} = @{idColumnName} AND TimestampEnc = @TimestampEnc";

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
                            updateCommand.Parameters.AddWithValue("@TimestampEnc", row.Cells["TimestampEnc"].Value);

                            int rowsUpdated = updateCommand.ExecuteNonQuery();
                            if (rowsUpdated == 0)
                            {
                                // Conflict occurred
                                MessageBox.Show("Conflict occurred. The row was updated by someone else.");

                                // Fetch the updated data
                                string selectQuery = $"SELECT * FROM {tableName} WHERE {idColumnName} = @{idColumnName}";
                                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                                selectCommand.Parameters.AddWithValue($"@{idColumnName}", row.Cells[idColumnName].Value);
                                SqlDataReader reader = selectCommand.ExecuteReader();

                                if (reader.Read())
                                {
                                    // Store the updated data
                                    List<object> updatedData = new List<object>();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        updatedData.Add(reader.GetValue(i));
                                    }

                                    // Show both versions of the data to the user
                                    string originalDataString = string.Join(", ", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value));
                                    string updatedDataString = string.Join(", ", updatedData);
                                    DialogResult result = MessageBox.Show($"Original data: {originalDataString}\nUpdated data: {updatedDataString}\nDo you want to overwrite the original data with the updated data?", "Conflict occurred", MessageBoxButtons.YesNo);

                                    if (result == DialogResult.Yes)
                                    {
                                        // Update the DataGridView row with the updated data
                                        for (int i = 0; i < reader.FieldCount; i++)
                                        {
                                            row.Cells[i].Value = updatedData[i];
                                        }

                                        // Try to update the database again
                                        bool updateSuccessful = false;
                                        while (!updateSuccessful)
                                        {
                                            try
                                            {
                                                rowsUpdated = updateCommand.ExecuteNonQuery();
                                                if (rowsUpdated > 0)
                                                {
                                                    updateSuccessful = true;
                                                }
                                                else
                                                {
                                                    // Conflict occurred again, fetch the updated data again
                                                    reader = selectCommand.ExecuteReader();
                                                    if (reader.Read())
                                                    {
                                                        updatedData.Clear();
                                                        for (int i = 0; i < reader.FieldCount; i++)
                                                        {
                                                            updatedData.Add(reader.GetValue(i));
                                                        }
                                                    }
                                                    reader.Close();

                                                    // Show the updated data to the user again
                                                    updatedDataString = string.Join(", ", updatedData);
                                                    result = MessageBox.Show($"Another conflict occurred. The updated data is now: {updatedDataString}\nDo you want to overwrite the original data with the updated data?", "Conflict occurred", MessageBoxButtons.YesNo);

                                                    if (result == DialogResult.Yes)
                                                    {
                                                        // Update the DataGridView row with the updated data
                                                        for (int i = 0; i < reader.FieldCount; i++)
                                                        {
                                                            row.Cells[i].Value = updatedData[i];
                                                        }
                                                    }
                                                    else
                                                    {
                                                        // User chose not to overwrite, break the loop
                                                        break;
                                                    }
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                // Handle any exceptions that occur when trying to update the database
                                                MessageBox.Show("Error: " + ex.Message);
                                                break;
                                            }
                                        }
                                    }
                                }

                                reader.Close();
                            }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable Form2Datatable = Form2.dataTable;
            dataGridView1.DataSource = Form2Datatable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void InserirBtn_Click(object sender, EventArgs e)
        {
            // Store the existing data source, assuming it's a DataTable
            DataTable existingData = (DataTable)dataGridView1.DataSource;

            // Unbind the DataGridView
            dataGridView1.DataSource = null;

            string dateString = dateTimePicker1.Text;
            string insertQuery = "";

            if (DateTime.TryParse(dateString, out DateTime selectedDate))
            {
                string formattedDate = selectedDate.ToString("yyyy-MM-dd");
                insertQuery = "INSERT INTO Encomenda(EncId, ClienteId, Data, Total) VALUES (" + textBox2.Text + ", '" + textBox1.Text + "', '" + formattedDate + "', " + textBox3.Text + ");";

                // Create a new row with the values
                DataRow newRow = existingData.NewRow();
                newRow["EncId"] = textBox2.Text;
                newRow["ClienteId"] = textBox1.Text;
                newRow["Data"] = formattedDate;
                newRow["Total"] = textBox3.Text;
               

                // Add the new row to the existing DataTable
                existingData.Rows.Add(newRow);

                // Rebind the DataGridView
                dataGridView1.DataSource = existingData;
            }
            else
            {
                MessageBox.Show("Invalid date.");
            }


        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(textBox5.Text, out int idToUpdate))
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Assuming the ID column index in the DataGridView is 0
                    if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int idFromRow) && idFromRow == idToUpdate)
                    {
                        // Update the "Total" cell in the found row
                        row.Cells["Total"].Value = textBox6.Text;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("ID not found in the DataGridView.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for ID.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int idToDelete))
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Assuming the ID column index in the DataGridView is 0
                    if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int idFromRow) && idFromRow == idToDelete)
                    {
                        dataGridView1.Rows.Remove(row);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("ID not found in the DataGridView.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendDataBtn_Click(object sender, EventArgs e)
        {
            SaveChangesToDatabase();
        }
    }
}
