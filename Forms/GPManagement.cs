using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;

namespace GPManagementApp
{
    public partial class GPManagement : Form
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cosmi\OneDrive - De Montfort University\GPManagementApp\GPManagementApp\DatabaseGP.mdf;Integrated Security=True";

        public GPManagement()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Yes");
                this.Hide();
                var form1 = new login();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientRegister f3 = new PatientRegister();
            f3.ShowDialog();

        }


        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGPDataSet1.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.databaseGPDataSet1.patients);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (text == "")
            {
                MessageBox.Show("You need to input the name of the patient !");
            }
            else
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM patients WHERE name = @param1", connection);
                    command.Parameters.AddWithValue("@param1", txtSearch.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                    dataGridView1.Visible = true;
                    connection.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            

            DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE patients SET name = @param1, address = @param2, phone_number = @param4 , gender = @param5 WHERE Id_patients = @param0 ", connection);
                    command.Parameters.AddWithValue("@param0", dataGridView1.CurrentRow.Cells[0].Value);
                    command.Parameters.AddWithValue("@param1", dataGridView1.CurrentRow.Cells[1].Value);
                    command.Parameters.AddWithValue("@param2", dataGridView1.CurrentRow.Cells[3].Value);
                    command.Parameters.AddWithValue("@param4", dataGridView1.CurrentRow.Cells[4].Value);
                    command.Parameters.AddWithValue("@param5", dataGridView1.CurrentRow.Cells[5].Value);
                    
                    patientsBindingSource.ResetBindings(false);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Console.WriteLine("Yes");
               
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this patient ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Yes");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM patients WHERE Id_patients = @param1", connection);
                    command.Parameters.AddWithValue("@param1", dataGridView1.CurrentRow.Cells[0].Value);
                    command.ExecuteNonQuery();

                    connection.Close();
                    
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Yes");
                dataGridView1.Visible = true;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM patients", connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Appoiment = new Appointments();
            Appoiment.Closed += (s, args) => this.Close();
            Appoiment.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM patients", connection))
                {
                    
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;


                    dataGridView1.DataSource = bSource;
                }
                connection.Close();
            }
            
           
            
        }
    }

}
