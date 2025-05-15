using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel; // Using ClosedXML now

namespace Student_ManagementSystem
{
    public partial class StudentAverage : Form
    {
        private string connStr = "server=localhost;user=root;database=student_management;port=3306;password=strongpassword12345";

        public StudentAverage()
        {
            InitializeComponent();
            // No need to set ExcelPackage.License here anymore
        }

        private void StudentAverage_Load(object sender, EventArgs e)
        {
            LoadStudents();

            if (dgvGrades.Columns.Count == 0)
            {
                dgvGrades.Columns.Add("Subject", "Subject");
                dgvGrades.Columns.Add("Grade", "Grade");
            }
        }

        private void LoadStudents()
        {
            comboBox1.Items.Clear();

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT student_id, name FROM students";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(new ComboBoxItem
                    {
                        Text = reader["name"].ToString(),
                        Value = Convert.ToInt32(reader["student_id"])
                    });
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            dgvGrades.Rows.Clear();

            int studentId = ((ComboBoxItem)comboBox1.SelectedItem).Value;
            double total = 0;
            int count = 0;

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT subject, grade FROM grades WHERE student_id = @studentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string subject = reader["subject"].ToString();
                    double grade = Convert.ToDouble(reader["grade"]);
                    dgvGrades.Rows.Add(subject, grade);

                    total += grade;
                    count++;
                }
            }

            double average = count > 0 ? total / count : 0;
            string category = average >= 90 ? "Excellent" :
                              average >= 75 ? "Passing" : "Needs Improvement";

            dgvGrades.Rows.Add("", "");
            dgvGrades.Rows.Add("Average", average.ToString("F2"));
            dgvGrades.Rows.Add("Category", category);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateExcelReport();
        }

        private void GenerateExcelReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Student Report");

                // Header row
                worksheet.Cell(1, 1).Value = "student_id";
                worksheet.Cell(1, 2).Value = "name";
                worksheet.Cell(1, 3).Value = "gender";
                worksheet.Cell(1, 4).Value = "age";
                worksheet.Cell(1, 5).Value = "subject";
                worksheet.Cell(1, 6).Value = "grade";
                worksheet.Cell(1, 7).Value = "average_grade";

                string query = @"
                    SELECT s.student_id, s.name, s.gender, s.age, 
                           g.subject, g.grade,
                           AVG(g.grade) OVER (PARTITION BY s.student_id) AS average_grade
                    FROM students s
                    INNER JOIN grades g ON s.student_id = g.student_id";

                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int row = 2;
                    while (reader.Read())
                    {
                        worksheet.Cell(row, 1).Value = Convert.ToInt32(reader["student_id"]); // Convert to int
                        worksheet.Cell(row, 2).Value = reader["name"].ToString(); // Convert to string
                        worksheet.Cell(row, 3).Value = reader["gender"].ToString(); // Convert to string
                        worksheet.Cell(row, 4).Value = Convert.ToInt32(reader["age"]); // Convert to int
                        worksheet.Cell(row, 5).Value = reader["subject"].ToString(); // Convert to string
                        worksheet.Cell(row, 6).Value = Convert.ToDouble(reader["grade"]); // Convert to double
                        worksheet.Cell(row, 7).Value = Convert.ToDouble(reader["average_grade"]).ToString("F2");
                        row++;
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Student Report"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    workbook.SaveAs(filePath);
                    MessageBox.Show("Excel report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
