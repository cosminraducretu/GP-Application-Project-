using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GPManagementApp
{
    public partial class PatientRegister : Form
    {
        public PatientRegister()
        {
            InitializeComponent();
            dateTimePicker.MinDate = new DateTime(1900, 1, 01);

        }
        private void PatientRegister_Load(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val1 = textBox1.Text;
            string val2 = textBox3.Text;
            string val3 = textBox4.Text;

            if (val1 == "")
            {
                MessageBox.Show("Please write the name of the pacient ");
            }
            else if (val2 == "")
            {
                MessageBox.Show("Please insert a valid address!");
            }
            else if (val3 == "")
            {
                MessageBox.Show("Please insert a valid emergency number !");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to add this pacient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Console.WriteLine("Yes");
                    SqlConnection con = new SqlConnection(GPManagement.connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO patients (name,date_of_birth,address,phone_number,gender) values (@name,@date_of_birth,@address,@phone_number,@gender)", con);

                    string newDate = dateTimePicker.Value.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@date_of_birth", newDate);
                    cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("address", textBox3.Text);
                    cmd.Parameters.AddWithValue("@phone_number", textBox4.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SUCCESS!!!");

                    con.Close();

                }
                else
                {
                    Console.WriteLine("No");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numeric values.", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.MaxLength = 15;
            }
        }

    }
}
