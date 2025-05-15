using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_ManagementSystem
{
    public partial class UpdateUser : Form
    {
        private int userId;
        private string connStr = "server=localhost;user=root;database=student_management;port=3306;password=strongpassword12345";
        

        // Constructor to initialize the form with existing user data
        public UpdateUser(int id, string username, string email, string password)
        {
            InitializeComponent();
            userId = id;

            // Set text fields with current user data
            txtUsername.Text = username;
            txtEmail.Text = email;
            txtPassword.Text = password;
        }

        // Load event (optional logic can be added here)
        private void UpdateUser_Load(object sender, EventArgs e)
        {
            // You can add any initialization logic here if necessary
        }

        // Button click to navigate back to CRUD form
        private void btnCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD crud = new CRUD();
            crud.Show();
        }

        // Button click to navigate back to User Management form
        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
        }

        // Button click to handle user update logic
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate if all fields are filled
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // Establish connection to the database
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Update query
                    string query = "UPDATE users SET username=@username, email=@email, password=@password WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Adding parameters to the query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@id", userId);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Show success message
                    MessageBox.Show("User updated successfully!");

                    // Hide the update form and show the UserManagement form
                    this.Hide();
                    UserManagement userManagement = new UserManagement();
                    userManagement.Show();
                }
                catch (Exception ex)
                {
                    // Show error message in case of an exception
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentGrades studentgrades = new StudentGrades();
            studentgrades.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAverage studentaverage = new StudentAverage();
            studentaverage.Show();
        }
    }
}
