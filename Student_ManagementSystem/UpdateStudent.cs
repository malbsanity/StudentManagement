using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_ManagementSystem
{
    public partial class UpdateStudent : Form
    {
        private string connStr = "server=localhost;user=root;database=student_management;port=3306;password=strongpassword12345";
        private int studentId;

        public UpdateStudent(int id, string name, string age, string gender)
        {
            InitializeComponent();
            studentId = id;

            // Set text fields with current student data
            txtName.Text = name;
            txtAge.Text = age;
            txtGender.Text = gender;
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            // Optional: You can add logic here if needed when the form loads
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle changes in name textbox
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD crud = new CRUD();
            crud.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string age = txtAge.Text.Trim();
            string gender = txtGender.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE students SET name = @name, age = @age, gender = @gender WHERE student_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@id", studentId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student updated successfully!");
                    this.Hide(); // hide the update form
                    CRUD crud = new CRUD();
                    crud.Show(); // re-open the main CRUD form
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
