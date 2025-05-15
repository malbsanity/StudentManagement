using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_ManagementSystem
{
    public partial class ForgotPassword : Form
    {
        string connStr = "server=localhost;user=root;database=student_management;port=3306;password=strongpassword12345";

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            // Optional: Initialize or load anything here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (username == "" || email == "" || newPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Check if user exists
                    string checkQuery = "SELECT * FROM users WHERE username = @username AND email = @email";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@email", email);

                    MySqlDataReader reader = checkCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close(); // Close before reusing connection

                        // Update password
                        string updateQuery = "UPDATE users SET password = @newPassword WHERE username = @username";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@username", username);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Password reset successfully!");
                       // this.Close(); Optionally, redirect to login
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or email.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }
    }
}
