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
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new GPRegister();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(GPManagement.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from doctors where username=@username and password=@password", con);

            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                
                this.Hide();
                var form4 = new GPManagement();
                form4.Closed += (s, args) => this.Close();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Try again");
            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox1.Checked)
            {
                string a = textBox2.Text;
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
