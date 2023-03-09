using GPManagementApp.Forms;
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
    public partial class BookAppointments : Form
    {
        public BookAppointments()
        {
            InitializeComponent();
            dateTimePicker.MaxDate = new DateTime(2300, 1, 01);
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.MinDate = DateTime.Today;
        }

            private void button1_Click(object sender, EventArgs e)
        {
            string val1 = textBox2.Text;
            string val2 = textBox6.Text;
            string val3 = textBox1.Text;
            if (val1 == "")
            {
                MessageBox.Show("Please specify the reason of the appoiment");
            }
            else if (val2 == "")
            {
                MessageBox.Show("Please insert the ID of the doctor !");
            }
            else if (val3 == "")
            {
                MessageBox.Show("Please insert the ID of the patient !");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(GPManagement.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO appoiments (date,reasonappoiment,Id_doctors,Id_patients) values (@date,@reasonappoiment,@Id_doctors,@Id_patients)", connection);

                    string newDate = dateTimePicker.Value.ToString("yyyy-MM-dd");


                    cmd.Parameters.AddWithValue("@date", newDate);
                    cmd.Parameters.AddWithValue("@reasonappoiment", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Id_doctors", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Id_patients", textBox1.Text);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("SUCCESS!!!");
                }
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
           ListPatients list = new ListPatients();
           list.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListDoctors list1 = new ListDoctors();
            list1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Appoiment = new Appointments();
            Appoiment.Closed += (s, args) => this.Close();
            Appoiment.Show();
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            
            foreach (Form form in forms)
            {
                if (form.Name == "ListDoctors" || form.Name == "ListPatients")
                {
                    form.Close();
                }
            }
        }

      
    }
}
