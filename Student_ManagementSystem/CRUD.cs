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
    public partial class CRUD : Form
    {
        int selectedStudentId = -1;
        MySqlConnection conn;
        string connStr = "server=localhost;user=root;database=student_management;port=3306;password=strongpassword12345";

        public CRUD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                string query = "SELECT * FROM students";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                string query = "INSERT INTO students (name, age, gender) VALUES (@name, @age, @gender)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added successfully!");

                conn.Close();
                LoadStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Make sure a student is selected
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            // Get current values from text boxes
            string name = txtName.Text;
            string age = txtAge.Text;
            string gender = txtGender.Text;

            // Open UpdateStudent form with parameters
            this.Hide();
            UpdateStudent updatestudent = new UpdateStudent(selectedStudentId, name, age, gender);
            updatestudent.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedStudentId == -1)
    {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                // First, delete the enrollment (if exists)
                string deleteEnrollmentQuery = "DELETE FROM enrollments WHERE student_id = @id";
                MySqlCommand cmdDeleteEnrollment = new MySqlCommand(deleteEnrollmentQuery, conn);
                cmdDeleteEnrollment.Parameters.AddWithValue("@id", selectedStudentId);
                cmdDeleteEnrollment.ExecuteNonQuery();

                // Now, delete the student
                string deleteStudentQuery = "DELETE FROM students WHERE student_id = @id";
                MySqlCommand cmdDeleteStudent = new MySqlCommand(deleteStudentQuery, conn);
                cmdDeleteStudent.Parameters.AddWithValue("@id", selectedStudentId);
                cmdDeleteStudent.ExecuteNonQuery();

                MessageBox.Show("Student deleted successfully!");

                conn.Close();
                LoadStudentData();

                // Reset selected ID
                selectedStudentId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedStudentId = Convert.ToInt32(row.Cells["student_id"].Value);
                txtName.Text = row.Cells["name"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
                txtGender.Text = row.Cells["gender"].Value.ToString();
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            // Sidebar logic if needed
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
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
