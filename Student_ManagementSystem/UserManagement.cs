using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_ManagementSystem
{
    public partial class UserManagement : Form
    {
        string connStr = "server=localhost;user=root;database=student_management;port=3306;password=strongpassword12345";
        int selectedUserId = -1;

        public UserManagement()
        {
            InitializeComponent();
            LoadUserData();
            this.Load += new System.EventHandler(this.UserManagement_Load);
        }

        private void LoadUserData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT id, username, email, password FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewUsers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            // Any initialization code
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: handle label click
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD crud = new CRUD();
            crud.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, email, password) VALUES (@username, @email, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text); // Make sure txtPassword is in your form
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully.");
                    LoadUserData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a user is selected (id != -1)
                if (selectedUserId != -1)
                {
                    MessageBox.Show("Deleting User with ID: " + selectedUserId);  // Debugging message to see the selected ID
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string query = "DELETE FROM users WHERE id=@id";  // Make sure 'id' matches your DB column name
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedUserId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully.");
                        LoadUserData();  // Refresh data grid
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Make sure a user is selected
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            // Get current values from text boxes
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Open UpdateUser form with parameters
            this.Hide();
            UpdateUser updateUserForm = new UpdateUser(selectedUserId, username, email, password);
            updateUserForm.Show();
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["id"].Value);
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentGrades studentgrades = new StudentGrades();
            studentgrades.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAverage studentaverage = new StudentAverage();
            studentaverage.Show();
        }
    }
}
