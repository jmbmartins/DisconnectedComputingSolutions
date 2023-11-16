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
         int selected_id;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = Encomendagrid.SelectedCells[0].RowIndex;
            selected_id = (int)Encomendagrid.Rows[row].Cells[0].Value;
            Updaterino();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Updaterino()
        {
            
            try
            {
            //    DataTable dataTable2 = new DataTable();
              //  sqlDataAdapter2.Fill(dataTable2);
                //EncLinhagrid.DataSource = dataTable2;
                
            }
            catch
            {
                MessageBox.Show("Erro (a BD foi abaixo provavelmente)");
                System.Windows.Forms.Application.ExitThread();
            }

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Queres fechar? Vais perder as cenas", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                // Close the SqlConnection when the form is closing
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

    }
}
