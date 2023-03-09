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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GPManagementApp
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var GPManagement = new GPManagement();
            GPManagement.Closed += (s, args) => this.Close();
            GPManagement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BookAppoiment = new BookAppointments();
            BookAppoiment.Closed += (s, args) => this.Close();
            BookAppoiment.Show();
        }

        private void Appoiment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGPDataSet.appoiments' table. You can move, or remove it, as needed.
            this.appoimentsTableAdapter.Fill(this.databaseGPDataSet.appoiments);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this appoiment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(GPManagement.connectionString))
                {
                    Console.WriteLine("Yes");
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM appoiments WHERE IdAppoiment = @param1", connection);
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

        private void button4_Click(object sender, EventArgs e)
        {

            string val1 = textBox1.Text;
            if (val1 == "")
            {
                MessageBox.Show("Please be sure to include the patient's or the applicant's ID!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(GPManagement.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM appoiments where  IdAppoiment= @param1 OR Id_patients = @param2 OR Id_doctors = @param3 ", connection);
                    command.Parameters.AddWithValue("@param1", textBox1.Text);
                    command.Parameters.AddWithValue("@param2", textBox1.Text);
                    command.Parameters.AddWithValue("@param3", textBox1.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                    dataGridView1.Visible = true;
                    connection.Close();
                }
            }
        }
    }
}
