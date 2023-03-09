using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPManagementApp
{
    public partial class ListPatients : Form
    {
        public ListPatients()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListPatients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGPDataSetatients.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.databaseGPDataSetatients.patients);

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (text == "")
            {
                MessageBox.Show("Please input a valid patient name!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(GPManagement.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM patients WHERE name = @param1", connection);
                    command.Parameters.AddWithValue("@param1", txtSearch.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = table;
                    connection.Close();


                }
            }
        }
    }
}
