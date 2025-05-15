using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_ManagementSystem
{
    public partial class StudentGrades : Form
    {
        private string connStr = "server=localhost;user=root;database=student_management;port=3306;password=strongpassword12345";

        public StudentGrades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentGrades studentgrades = new StudentGrades();
            studentgrades.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD crud = new CRUD();
            crud.Show();
        }

        private void StudentGrades_Load(object sender, EventArgs e)
        {
            // Load students into the ComboBox
            LoadStudents();

            // Load subjects into ComboBox
            cmbSubjects.Items.Add("Math");
            cmbSubjects.Items.Add("Science");
            cmbSubjects.Items.Add("English");

            // Set up DataGridView columns
            dgvStudentGrades.Columns.Add("full_name", "Full Name");
            dgvStudentGrades.Columns.Add("subject", "Subject");
            dgvStudentGrades.Columns.Add("grade", "Grade");
            dgvStudentGrades.Columns.Add("grade_category", "Grade Category");
        }

        // Add this method to load students from the database
        private void LoadStudents()
        {
            cmbStudents.Items.Clear(); // Clear previous entries, if any

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT student_id, name FROM students"; // Adjusted query to select 'name' column
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader(); // Fixed reader declaration

                // Add students to ComboBox
                while (reader.Read())
                {
                    // Add student as a ComboBox item (using KeyValuePair for easy access)
                    cmbStudents.Items.Add(new KeyValuePair<int, string>(Convert.ToInt32(reader["student_id"]), reader["name"].ToString()));
                }
            }
        }

        // Method to load student grades into the DataGridView
        private void LoadStudentGrades()
        {
            dgvStudentGrades.Rows.Clear(); // Clear previous rows, if any

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT s.name, g.subject, g.grade, g.grade_category " +
                               "FROM grades g " +
                               "JOIN students s ON g.student_id = s.student_id"; // Make sure 'student_id' matches the correct column

                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                // Add rows to DataGridView
                while (reader.Read())
                {
                    dgvStudentGrades.Rows.Add(
                        reader["name"].ToString(),  // Full name of the student
                        reader["subject"].ToString(),
                        reader["grade"].ToString(),
                        reader["grade_category"].ToString() // Display the grade category
                    );
                }
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedItem == null || cmbSubjects.SelectedItem == null || string.IsNullOrEmpty(txtGrade.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Get student_id, subject, and grade
            KeyValuePair<int, string> selectedStudent = (KeyValuePair<int, string>)cmbStudents.SelectedItem;
            int studentId = selectedStudent.Key;
            string subject = cmbSubjects.SelectedItem.ToString();
            int grade;
            if (!int.TryParse(txtGrade.Text, out grade))
            {
                MessageBox.Show("Please enter a valid grade.");
                return;
            }

            // Determine grade category
            string gradeCategory = grade >= 90 ? "Excellent" : "Passing";

            // Insert grade into the database
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO grades (student_id, subject, grade, grade_category) VALUES (@studentId, @subject, @grade, @gradeCategory)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.Parameters.AddWithValue("@gradeCategory", gradeCategory); // Insert grade category
                cmd.ExecuteNonQuery();
            }

            // Reload student grades into the DataGridView
            LoadStudentGrades();
        }

        // Handle the event when a cell is clicked
        private void dgvStudentGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked column is the grade column
            if (e.ColumnIndex == dgvStudentGrades.Columns["grade"].Index)
            {
                var gradeValue = dgvStudentGrades.Rows[e.RowIndex].Cells["grade"].Value;

                // Ensure it's a valid grade value
                if (gradeValue != null && int.TryParse(gradeValue.ToString(), out int grade))
                {
                    // Change cell color based on grade value
                    if (grade < 75)
                    {
                        dgvStudentGrades.Rows[e.RowIndex].Cells["grade"].Style.BackColor = Color.Red;
                        dgvStudentGrades.Rows[e.RowIndex].Cells["grade"].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        dgvStudentGrades.Rows[e.RowIndex].Cells["grade"].Style.BackColor = Color.Green;
                        dgvStudentGrades.Rows[e.RowIndex].Cells["grade"].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {
            // Optional: You can add validation here to allow only numeric values
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD crud = new CRUD();
            crud.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD crud = new CRUD();
            crud.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAverage studentaverage = new StudentAverage();
            studentaverage.Show();


        }
    }
}
