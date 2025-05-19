using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace loginform_web_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button click detected."); //---------- just put for testing

            string inputUsername = textBox1.Text;
            string inputPassword = textBox2.Text;

            string connString = @"Server=DESKTOP-1RCGNA6\SQLEXPRESS;Database=LoginAppDB;Trusted_Connection=True;Encrypt=False;";

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM loginapp WHERE username=@username AND password=@password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", inputUsername);
                    cmd.Parameters.AddWithValue("@password", inputPassword);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Redirecting to forgot password page...");
        }
    }
}
