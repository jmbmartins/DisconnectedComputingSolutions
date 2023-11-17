using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataApp
{

    public partial class Form2 : Form
    {
        int selected_id = -1;
        int selected_line = -1;
        int selected_product = -1;
        int rows_encomenda;
        int rows_linhas;
        string update_query = "";
        public void fetchData()
        {
            using (SqlConnection connection = new SqlConnection(Form1.connectionString))
            {
                string query = "SELECT * FROM Encomenda";
                string query2 = "SELECT * FROM LinhaEnc";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlDataAdapter adapter2 = new SqlDataAdapter(query2, connection);
                DataTable dataTable = new DataTable();
                DataTable dataTable2 = new DataTable();
                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    adapter2.Fill(dataTable2);
                    Encomendagrid.DataSource = dataTable; // Binding the DataGridView to the DataTable
                    EncLinhagrid.DataSource = dataTable2;
                    rows_encomenda = Encomendagrid.RowCount - 1;
                    rows_linhas = EncLinhagrid.RowCount - 1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public Form2()
        {
            InitializeComponent();

        }

        private void Encomenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = Encomendagrid.SelectedCells[0].RowIndex;
            selected_id = (int)Encomendagrid.Rows[row].Cells[0].Value;
        }
        private void EncLinha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = EncLinhagrid.SelectedCells[0].RowIndex;
            selected_line = (int)EncLinhagrid.Rows[row].Cells[0].Value;
            selected_product = (int)EncLinhagrid.Rows[row].Cells[1].Value;

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void cierra(object sender, EventArgs e)
        {
            if (update_query != "")
            {
                // Check if the user really wants to close the form
                DialogResult result = MessageBox.Show("Queres fechar? vais perder os updates", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.ExitThread();
                }
            }
        }
        private void udpdatedb(object sender, EventArgs e)
        {
            if (update_query != "")
            {
                // Create a SqlConnection object
                using (SqlConnection connection = new SqlConnection(Form1.connectionString))
                {
                    // Create a SqlCommand object with the delete query and connection
                    using (SqlCommand command = new SqlCommand(update_query, connection))
                    {
                        try
                        {
                            // Open the database connection
                            connection.Open();

                            // Execute the delete query
                            int rowsAffected = command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                update_query = "";
            }
            fetchData();

        }

        private void deleter(object sender, EventArgs e)
        {   //esta query apaga a encomenda, se a encomenda tiver linhas nao deixa ser apagada, mudar isto para apagar da linha primeiro
            if (selected_id != -1)
                update_query += "DELETE FROM Encomenda WHERE EncId = " + selected_id + "\n";
        }
        private void linedeleter(object sender, EventArgs e)
        {
            if (selected_line != -1)
                update_query += "DELETE FROM LinhaEnc WHERE EncId = " + selected_line + " AND ProdutoId = " + selected_product + "\n";
        }
        private void Inserir_Encomendas(object sender, EventArgs e)
        {
            for (int i = rows_encomenda; i < Encomendagrid.RowCount - 1; i++)
            {
                // Original date and time string
                string dateString = Encomendagrid.Rows[i].Cells[2].Value.ToString();

                // Convert the string to a DateTime object
                if (DateTime.TryParseExact(dateString, "dd-MMM-yy HH:mm:ss", null, DateTimeStyles.None, out DateTime dateTime))
                {
                    update_query += "INSERT INTO Encomenda (EncId, ClienteId, Data, Total) VALUES(" + Encomendagrid.Rows[i].Cells[0].Value.ToString() + ", " + Encomendagrid.Rows[i].Cells[1].Value.ToString() + ", \'" + dateTime.ToString("yyyy-MM-dd") + "\', " + Encomendagrid.Rows[i].Cells[3].Value.ToString() + "); ";
                }
            }
        }

        private void Inserir_linhas(object sender, EventArgs e)
        {
            for (int i = rows_linhas; i < EncLinhagrid.RowCount - 1; i++)
            {
                update_query += "INSERT INTO LinhaEnc (EncId, ProdutoId, Qtd) VALUES( " + EncLinhagrid.Rows[i].Cells[0].Value.ToString() + ", " + EncLinhagrid.Rows[i].Cells[1].Value.ToString() + ", " + EncLinhagrid.Rows[i].Cells[2].Value.ToString() + "); ";
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (update_query != "")
            {
                // Check if the user really wants to close the form
                DialogResult result = MessageBox.Show("Queres fechar? vais perder os updates", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    // If the user clicked "No," cancel the form closing event
                    e.Cancel = true;
                }
            }

        }

    }
}
