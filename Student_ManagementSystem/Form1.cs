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
    

    public partial class Form1 : Form
    {
        int selectedStudentId = -1;
        MySqlConnection conn;
        string connStr = "server=localhost;user=root;database=student_management;port=3306;password=strongpassword12345";  
        public Form1()
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
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                string query = "UPDATE students SET name = @name, age = @age, gender = @gender WHERE student_id = @id"; 
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@id", selectedStudentId); 

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student updated successfully!");

                conn.Close();
                LoadStudentData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                string query = "DELETE FROM students WHERE student_id = @id";  
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedStudentId);  

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student deleted successfully!");

                conn.Close();
                LoadStudentData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedStudentId = Convert.ToInt32(row.Cells["id"].Value);
                txtName.Text = row.Cells["name"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
                txtGender.Text = row.Cells["gender"].Value.ToString();
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
