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

namespace GPManagementApp.Forms
{
    public partial class ListDoctors : Form
    {
        public ListDoctors()
        {
            InitializeComponent();
        }

        private void ListDoctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGPDataSetDoctors.doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.databaseGPDataSetDoctors.doctors);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string text = txtSearch.Text;
            if(text == ""){
                MessageBox.Show("Please input a valid doctor name!");
            }
            else
            {

                using (SqlConnection connection = new SqlConnection(GPManagement.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM doctors WHERE username = @param1", connection);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
