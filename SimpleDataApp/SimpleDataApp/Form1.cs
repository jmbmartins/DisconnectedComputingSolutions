﻿using System;
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
    public partial class Form1 : Form
    {
        static public string connectionString;
        String hostName ;
        String databaseName ;
        String username ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "127.0.0.1";
            textBox2.Text = "Trab2_6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hostName = textBox1.Text;
            databaseName = textBox2.Text;
            username = textBox3.Text;
            String password = maskedTextBox1.Text;
            connectionString = $"Data Source={hostName};Initial Catalog={databaseName};User ID={username};Password={password};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
