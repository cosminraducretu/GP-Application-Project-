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
    public partial class GPRegister : Form
    {
        public GPRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new login();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val0 = textBox1.Text;
            string val1 = textBox4.Text;
            string val2 = textBox5.Text;
            string val3 = textBox6.Text;
            string pass1 = textBox2.Text;
            string pass2 = textBox3.Text;

            if (val0 == "")
            {
                MessageBox.Show("You need to fill username section ");
            }
            else if (pass1 == "")
            {
                MessageBox.Show("You need to fill password section ");
            }
            else if (val1 == "")
            {
                MessageBox.Show("You need to fill age section ");
            }
            
            else if (val2 == "")
            {
                MessageBox.Show("you need to fill speciality section ");

            }
            else if (val3 == "")
            {
                MessageBox.Show("You need to fill experience section ");

            }
            else
            {
                SqlConnection con = new SqlConnection(GPManagement.connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO doctors (username,password,age,experience,speciality) values (@username,@password,@age,@experience,@speciality)", con);

                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(textBox4.Text));
                cmd.Parameters.AddWithValue("@experience", textBox5.Text);
                cmd.Parameters.AddWithValue("@speciality", textBox6.Text);

                if (pass1 != pass2)
                {
                    MessageBox.Show("Passwords are not the same !");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SUCCESS!!!");
                }
                con.Close();

                this.Hide();
                var form1 = new login();
                form1.Closed += (s, args) => this.Close();
                form1.Show();

            }
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numeric values.", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.MaxLength = 3;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string a = textBox2.Text;
                string b = textBox3.Text;
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {


                textBox2.PasswordChar = '\0';

            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {


                textBox3.PasswordChar = '\0';

            }
            else
            {
                textBox3.PasswordChar = '*';
            }
        }
    }
}
